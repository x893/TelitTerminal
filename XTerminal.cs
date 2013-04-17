using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using System.Globalization;

namespace TelitTerminal
{
	public partial class XTerminal : Form
	{
		private const string PYTHON_INSTALL_KEY = @"SOFTWARE\Python\PythonCore\1.5\InstallPath";
		private const string CMD_LSCRIPT = "#LSCRIPT:";

		private string portName = "";
		private int baud = 115200;
		private string protocol = "RTS";
		private string folder = string.Empty;
		private SerialPort serialPort = null;

		private string pythonExe = string.Empty;
		private string pythonPath = string.Empty;

		private char[] CHAR_CR = new char[] { '\r' };
		private char[] CHAR_LF = new char[] { '\n' };
		private char[] CHAR_SEMICOMMA = new char[] { ';' };
		private char[] CHAR_QUOTE = new char[] { '"' };

		private bool waitForResponse = false;
		private string deviceResponse = string.Empty;
		private bool deviceLineMode = true;
		private bool readBinary = false;
		private string bufferData = string.Empty;

		private int windowX, windowY, windowW, windowH;
		private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
		private Settings settings = null;
		private ButtonDefinition button_def = new ButtonDefinition();
		private EventHandler btnCmd_Click_handler;
		private KeyEventHandler defineCmd_KeyUp_handler;
		private MouseEventHandler defineCmd_handler;
		public XTerminal()
		{
			InitializeComponent();
		}

		#region frmMain_Load(...) 
		private void frmMain_Load(object sender, EventArgs e)
		{
			loadSettings();
			loadPorts();
			folderSelected.Text = folder.Trim();
			loadFolder();

			btnCmd_Click_handler = new EventHandler(btnCmd_Click);
			defineCmd_KeyUp_handler = new KeyEventHandler(defineCmd_KeyUp);
			defineCmd_handler = new MouseEventHandler(defineCmd);
			setXButtons(this.Controls);

			pythonPath = pythonExe = string.Empty;

			string compilerPath = substitudeVars(compiler.Text);

			if (compiler.Text.Length > 0 && File.Exists(compilerPath))
			{
				pythonPath = Path.GetDirectoryName(compilerPath);
				pythonExe = Path.Combine(pythonPath, "python.exe");
			}

			if (string.IsNullOrEmpty(pythonExe))
			{
				RegistryKey hklm = Registry.LocalMachine;
				RegistryKey pythonInstall = hklm.OpenSubKey(PYTHON_INSTALL_KEY, false);
				if (pythonInstall != null)
					pythonPath = pythonInstall.GetValue("") as string;
				else
					errorProvider.SetError(btnSelectCompiler, string.Format(cultureInfo, "Can't find registry key {0}", PYTHON_INSTALL_KEY));

				if (!string.IsNullOrEmpty(pythonPath))
				{
					pythonExe = Path.Combine(pythonPath, "python.exe");
					if (!File.Exists(pythonExe))
					{
						errorProvider.SetError(btnSelectCompiler, string.Format(cultureInfo, "Can't find {0}", pythonExe));
						pythonPath = pythonExe = string.Empty;
					}
					else
						compiler.Text = pythonExe;
				}
			}

			if (string.IsNullOrEmpty(pythonExe))
			{
				errorProvider.SetError(btnSelectCompiler, "Python not found.");
				compiler.ForeColor = Color.Red;
				btnCompile.Enabled = false;
			}
			else
				btnCompile.Enabled = true;

			cbWordWrap_CheckedChanged(sender, e);
		}

		private void setXButtons(Control.ControlCollection controlCollection)
		{
			foreach (Control control in controlCollection)
			{
				if (control is XButton)
				{
					control.Click += btnCmd_Click_handler;
					control.KeyUp += defineCmd_KeyUp_handler;
					control.MouseUp += defineCmd_handler;
				}
				else if (control.HasChildren)
					setXButtons(control.Controls);
			}
		}

		void control_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region substitudeVars(string text) 
		/// <summary>
		/// Substiture environment variables %var%
		/// </summary>
		/// <param name="text">Text with variable names</param>
		/// <returns>Text with substituted values</returns>
		private static string substitudeVars(string text)
		{
			if (!string.IsNullOrEmpty(text))
			{
				int i = text.IndexOf("%", StringComparison.Ordinal);
				while (i >= 0)
				{
					int j = text.IndexOf("%", i + 1, StringComparison.Ordinal);
					if (j > 0)
					{
						string var = text.Substring(i + 1, j - i - 1);
						var = Environment.GetEnvironmentVariable(var);
						if (var != null)
						{
							if (i > 0)
								text = text.Substring(0, i - 1) + var + text.Substring(j + 1, text.Length - 1);
							else
								text = var + text.Substring(j + 1, text.Length - j - 1);
							j = i + var.Length;
						}
						i = text.IndexOf("%", j + 1, StringComparison.Ordinal);
						continue;
					}
					break;
				}
			}
			return text;
		}
		#endregion

		#region formClosing(...)
		/// <summary>
		/// Form closing. Save settings and exit on success.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void formClosing(object sender, FormClosingEventArgs e)
		{
			disconnect();
			if (!saveSettings() && MessageBox.Show("Settings not save.\n\nExit anyway ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
				e.Cancel = true;
		}
		#endregion

		#region loadFolder() 

		private void loadFolder()
		{
			loadFolder(string.Empty);
		}

		private string watchFolder;
		private FileSystemWatcher watcher;

		private void loadFolder(string skip)
		{
			if (this.InvokeRequired)
				this.BeginInvoke(new Action<string>(loadFolder), string.Empty);
			else
			{
				if (!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
				{
					if (watcher != null && watcher.Path != folder)
					{
						watcher.Dispose();
						watcher = null;
					}

					watcher = new FileSystemWatcher(folder, "*.*");

					refreshFiles();

					watcher.EnableRaisingEvents = true;
					watcher.IncludeSubdirectories = true;
					watcher.Changed += new FileSystemEventHandler(watcher_changed);
					watcher.Created += new FileSystemEventHandler(watcher_changed);
					watcher.Deleted += new FileSystemEventHandler(watcher_changed);
					watcher.Renamed += new RenamedEventHandler(watcher_Renamed);
				}
				else if (watcher != null)
				{
					filesHost.Items.Clear();
					watcher.EnableRaisingEvents = false;
					watcher.Dispose();
					watcher = null;
				}
				else
					filesHost.Items.Clear();
			}
		}

		private void removeItems(ListView.ListViewItemCollection items)
		{
		}

		private void removeItems(ListViewEx list)
		{
			ListView.ListViewItemCollection items = list.Items;
			for (int i = items.Count - 1; i >= 0; i--)
				if (items[i].Checked)
					items[i].Checked = false;
				else
					items.RemoveAt(i);
		}

		private void refreshFiles()
		{
			if (this.InvokeRequired)
				this.BeginInvoke(new MethodInvoker(refreshFiles));
			else
			{
				filesHost.SuspendLayout();
				foreach (ListViewItem item in filesHost.Items)
					item.Checked = false;

				DirectoryInfo d = new DirectoryInfo(watcher.Path);
				foreach (FileInfo f in d.GetFiles())
				{
					string size = f.Length.ToString();
					bool append = true;
					foreach (ListViewItem item in filesHost.Items)
						if (item.Text == f.Name)
						{
							if (item.SubItems[1].Text != size)
							{
								item.SubItems[1].Text = size;
								item.Font = new Font(item.Font, FontStyle.Bold); // .BackColor = Color.FromKnownColor(KnownColor.HotTrack);
							}
							append = false;
							item.Checked = true;
							break;
						}
					if (append)
					{
						string ext = f.Extension.ToUpperInvariant();

						ListViewItem item = new ListViewItem(f.Name);
						item.SubItems.Add(size);
						item.Checked = true;

						ListViewGroup other = null;
						foreach (ListViewGroup group in filesHost.Groups)
						{
							if (group.Tag == null)
							{
								other = group;
							}
							else if ((group.Tag as string) == ext)
							{
								item.Group = group;
								other = null;
								break;
							}
						}
						if (other != null)
						{
							item.Group = other;
						}
						filesHost.Items.Add(item);
					}
				}
				removeItems(filesHost);
				filesHost.ResumeLayout(true);
			}
		}

		void watcher_Renamed(object sender, RenamedEventArgs e)
		{
			refreshFiles();
		}

		void watcher_changed(object sender, FileSystemEventArgs e)
		{
			refreshFiles();
		}
		#endregion

		#region disconnect() 
		/// <summary>
		/// Disconnect from COM port
		/// </summary>
		private void disconnect()
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke((MethodInvoker)delegate { disconnect(); });
			}
			else if (serialPort != null)
			{
				if (serialPort.IsOpen)
				{
					try
					{
						if (cbDTR.Checked)
							serialPort.DtrEnable = false;
						serialPort.Close();
					}
					catch { }
				}
				serialPort.Dispose();
				serialPort = null;
				btnOpen.Text = "F2 - &Open";
			}
		}
		#endregion

		#region Load/Save Settings() 

		private string getSettingFile()
		{
			return Path.Combine(Application.StartupPath, Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".cfg");
		}
		#region loadSettings() 
		/// <summary>
		/// Load settings from user.settings file
		/// </summary>
		private void loadSettings()
		{
			try
			{
				settings = Settings.Load(getSettingFile());
			}
			catch (Exception ex)
			{
				SetStatus(ex.Message);
				settings = new Settings();
			}

			portName = settings.PortName;
			baud = settings.Baud;
			protocol = settings.Protocol;
			folder = settings.Folder;

			foreach (CmdButton cmd in CmdButtons(this.Controls))
				setCmdUser(cmd, settings.GetCommand(cmd.Index));
			
			cbDTR.Checked = settings.DTR;
			editor.Text = settings.Editor;
			compiler.Text = settings.Compiler;

			windowX = settings.WindowX;
			windowY = settings.WindowY;
			windowW = settings.WindowW;
			windowH = settings.WindowH;
			if (windowW > 0 && windowH > 0)
			{
				this.Width = windowW;
				this.Height = windowH;
				this.Location = new Point(windowX, windowY);
			}
			cbEcho.Checked = settings.Echo;
			cbWordWrap.Checked = settings.WordWrap;
			cbLSCRIPT.Checked = settings.AutoLSCRIPT;
		}

		private void setCmdUser(CmdButton cmd, string text)
		{
			cmd.Text = text.Replace("&", "&&");
			cmd.Command = text;
			if (!string.IsNullOrEmpty(text))
			{
				if (cmd.Index >= 0 && cmd.Index <= 9)
					cmd.Text = string.Format("({0}) - ", cmd.Index) + cmd.Text;
			}
		}
		#endregion

		private IEnumerable<CmdButton> CmdButtons(Control.ControlCollection controls)
		{
			foreach (Control control in controls)
			{
				if (control is CmdButton)
					yield return (control as CmdButton);
				else if (control.HasChildren)
				{
					foreach (CmdButton cmd in CmdButtons(control.Controls))
						yield return cmd;
				}
			}
		}

		#region saveSettings()
		/// <summary>
		/// Save settings to file if any changes.
		/// </summary>
		/// <returns>True on success, False if fail.</returns>
		private bool saveSettings()
		{
			if (settings == null)
				return true;

			bool change = false;
			string msg = string.Empty;

			change |= (portName != settings.PortName);
			change |= (baud != settings.Baud);
			change |= (protocol != settings.Protocol);
			change |= (folder != settings.Folder);
			change |= (editor.Text != settings.Editor);
			change |= (compiler.Text != settings.Compiler);
			change |= (cbDTR.Checked != settings.DTR);
			change |= (this.Location.X != settings.WindowX);
			change |= (this.Location.Y != settings.WindowY);
			change |= (this.Width != settings.WindowW);
			change |= (this.Height != settings.WindowH);
			change |= (cbEcho.Checked != settings.Echo);
			change |= (cbWordWrap.Checked != settings.WordWrap);
			change |= (cbLSCRIPT.Checked != settings.AutoLSCRIPT);

			foreach(CmdButton cmd in CmdButtons(this.Controls))
				change |= (cmd.Command != settings.GetCommand(cmd.Index));

			if (change)
			{
				settings.PortName = portName;
				settings.Baud = baud;
				settings.Protocol = protocol;
				settings.Folder = folder;
				settings.Editor = editor.Text;
				settings.Compiler = compiler.Text;
				settings.DTR = cbDTR.Checked;
				settings.WindowX = this.Location.X;
				settings.WindowY = this.Location.Y;
				settings.WindowW = this.Width;
				settings.WindowH = this.Height;
				settings.Echo = cbEcho.Checked;
				settings.WordWrap = cbWordWrap.Checked;
				settings.AutoLSCRIPT = cbLSCRIPT.Checked;

				try
				{
					foreach (CmdButton cmd in CmdButtons(this.Controls))
						settings.SetCommand(cmd.Index, cmd.Command);
					msg = Settings.Save(getSettingFile(), settings);
						
				}
				catch (Exception ex)
				{
					msg = ex.Message;
				}

				if (msg.Length > 0)
				{
					MessageBox.Show(msg,
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error,
						MessageBoxDefaultButton.Button1
						);
					return false;
				}
			}
			return true;
		}
		#endregion

		#endregion

		#region loadPorts()
		/// <summary>
		/// Load COM ports to combo box.
		/// </summary>
		private void loadPorts()
		{
			cbPorts.Items.Clear();
			SortedList<string, string> ports = new SortedList<string, string>();
			foreach (string port in SerialPort.GetPortNames())
			{
				if(!ports.ContainsKey(port))
					ports.Add(port, port);
			}

			foreach (string port in ports.Values)
			{
				cbPorts.Items.Add(port);
				if (!string.IsNullOrEmpty(portName) && port == portName)
					cbPorts.SelectedIndex = cbPorts.Items.Count - 1;
			}

			if (cbPorts.SelectedIndex < 0 && cbPorts.Items.Count > 0)
				cbPorts.SelectedIndex = 0;

			setBaudrate(baud);
			setProtocol(protocol);
		}

		private bool setProtocol(string new_protocol)
		{
			cbProtocol.SelectedIndex = -1;
			if (!string.IsNullOrEmpty(protocol))
			{
				for (int i = 0; i < cbProtocol.Items.Count; i++)
				{
					string item = cbProtocol.Items[i] as string;
					switch (item)
					{
						case "Hardware":
							if (new_protocol == "RTS")
								cbProtocol.SelectedIndex = i;
							break;
						case "None":
							if (new_protocol == "none")
								cbProtocol.SelectedIndex = i;
							break;
						default:
							continue;
					}
					if (cbProtocol.SelectedIndex >= 0)
						break;
				}
				if (cbProtocol.SelectedIndex >= 0)
				{
					protocol = new_protocol;
					return true;
				}
				SetStatus(string.Format(cultureInfo, "Bad protocol: {0}", new_protocol));
			}
			else
				SetStatus(string.Format(cultureInfo, "Protocol can't be empty."));
			return false;
		}

		private bool setBaudrate(int new_baud)
		{
			cbSpeed.SelectedIndex = -1;
			if (new_baud > 0)
			{
				string speed = new_baud.ToString(cultureInfo);
				for (int i = 0; i < cbSpeed.Items.Count; i++)
					if (speed == (cbSpeed.Items[i] as string))
					{
						cbSpeed.SelectedIndex = i;
						baud = new_baud;
						break;
					}
				if (cbSpeed.SelectedIndex < 0)
					SetStatus(string.Format(cultureInfo, "Bad baudrate: {0}", new_baud));
				else
					return true;
			}
			else
				SetStatus("Baudrate must be great zero");
			return false;
		}
		#endregion

		#region appendToLog(string data) 
		/// <summary>
		/// Append text to log text.
		/// </summary>
		/// <param name="msg">Text to append</param>
		protected void AppendToLog(string msg)
		{
			if (this.InvokeRequired)
				this.BeginInvoke(new Action<string>(AppendToLog), msg);
			else
			{
				if (msg != null && msg.Length > 0)
				{
					log.SuspendLayout();
					log.Text += msg;
					log.SelectionStart = log.Text.Length;
					log.ScrollToCaret();
					log.ResumeLayout();
				}
			}
		}
		#endregion

		#region splitLines(string str) 
		/// <summary>
		/// Split text with Line Feed (\n) and remove Carriage Return (\r) at the end of each string.
		/// </summary>
		/// <param name="text">Text to split.</param>
		/// <returns>Array of strings.</returns>
		private string[] splitLines(string text)
		{
			string[] lines = text.Split(CHAR_LF, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < lines.Length; i++)
			{
				lines[i] = lines[i].TrimEnd(CHAR_CR);
			}
			return lines;
		}
		#endregion

		#region sendToDevice(...) 
		/// <summary>
		/// Send command and wait for standard response with timeout.
		/// </summary>
		/// <param name="cmd">command to send</param>
		/// <param name="ms_timeout">timeout for response</param>
		/// <returns>True if response recieved</returns>
		private bool sendToDeviceOK(string cmd, int ms_timeout)
		{
			return sendToDevice(cmd, "OK\r\n;ERROR\r\n;+CME ERROR", ms_timeout, true);
		}

		/// <summary>
		/// Send command and wait for standard response with 5 seconds timeout.
		/// </summary>
		/// <param name="cmd">command to send</param>
		/// <param name="ms_timeout">timeout for response</param>
		/// <returns>True if response recieved</returns>
		private bool sendToDeviceOK(string cmd)
		{
			return sendToDeviceOK(cmd, 1000);
		}

		/// <summary>
		/// Send command and wait for standard response with timeout.
		/// </summary>
		/// <param name="cmd">command to send</param>
		/// <param name="waitFor">responses with ; delimiter</param>
		/// <param name="ms_timeout">timeout for response</param>
		/// <param name="linemode">True if linemode, False for stream mode (upload, download)</param>
		/// <returns>True if response recieved</returns>
		private bool sendToDevice(string cmd, string waitFor, int ms_timeout, bool linemode)
		{
			if (!connect())
				return false;

			if (ms_timeout > 0)
			{
				progress.Value = progress.Minimum;
				progress.Increment(1);
				SetStatus(string.Format(cultureInfo, "Sending \"{0}\"...", cmd));

				waitForResponse = true;
				deviceResponse = string.Empty;
				deviceLineMode = linemode;
			}
			string[] waitsFor = waitFor.Split(CHAR_SEMICOMMA, StringSplitOptions.RemoveEmptyEntries);

			if(!string.IsNullOrEmpty(cmd))
				sendToDevice(cmd);

			if (serialPort == null)
				return false;

			if (ms_timeout <= 0)
				return true;

			int delay = 10;

			while (ms_timeout > 0)
			{
				int timeout = (ms_timeout > delay ? delay : ms_timeout);
				Thread.Sleep(timeout);
				foreach (string wait in waitsFor)
				{
					if (wait.StartsWith("+", StringComparison.Ordinal) &&
						deviceResponse.IndexOf(wait, StringComparison.Ordinal) >= 0)
					{
						waitForResponse = false;
						progress.Value = progress.Minimum;
						SetStatus(string.Format(cultureInfo, "Sent \"{0}\".", cmd));
						return true;
					}
					else if (deviceResponse.EndsWith(wait, StringComparison.Ordinal))
					{
						waitForResponse = false;
						progress.Value = progress.Minimum;
						SetStatus(string.Format(cultureInfo, "Sent \"{0}\".", cmd));
						return true;
					}
				}

				progress.Increment(1);
				if (progress.Value == progress.Maximum)
					progress.Value = progress.Minimum;

				ms_timeout -= timeout;
				delay = 50;
				Application.DoEvents();
			}

			progress.Value = progress.Minimum;
			waitForResponse = false;
			SetStatus(string.Format(cultureInfo, "Timeout for \"{0}\".", cmd));
			return false;
		}

		/// <summary>
		/// Send data to COM port.
		/// </summary>
		/// <param name="data">Data to send</param>
		private void sendToDevice(string data)
		{
			if (serialPort != null)
			{
				try
				{
					if (cbEcho.Checked)
					{
						AppendToLog(data);
						AppendToLog("\r\n");
					}
					serialPort.WriteTimeout = 1000;
					serialPort.Write(data + "\r\n");
				}
				catch (InvalidOperationException ex)
				{
					SetStatus(ex.Message);
					disconnect();
				}
				catch (IOException ex)
				{
					SetStatus(ex.Message);
					disconnect();
				}
				catch (TimeoutException ex)
				{
					SetStatus(ex.Message);
					disconnect();
				}
			}
		}
		#endregion

		#region port_DataReceived(...) 
		/// <summary>
		/// COM port recieve data handler.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
				if (serialPort.BytesToRead > 0 && !readBinary)
				{
					string data = serialPort.ReadExisting();
					AppendToLog(data);
					if (waitForResponse)
					{
						if (deviceLineMode)
						{
							bufferData += data;
							int i = bufferData.LastIndexOf("\r\n", StringComparison.Ordinal);
							if (i >= 0)
							{
								deviceResponse += bufferData.Substring(0, i + 2);
								bufferData = bufferData.Substring(i + 2);
							}
						}
						else
							deviceResponse += data;
					}
				}
			}
			catch (Exception ex)
			{
				disconnect();
				SetStatus(ex.Message);
			}
		}
		#endregion

		#region SetStatus 
		private delegate void EventSetStatusHandler(string line);
		private void SetStatus(string text)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new Action<string>(SetStatus), text);
			}
			else
				Status.Text = text;
		}
		#endregion

		#region connect() 
		/// <summary>
		/// Conect to COM port.
		/// </summary>
		/// <param name="new_baud">Baud rate</param>
		/// <param name="new_protocol">Handshake protocol</param>
		/// <returns>True on success, False if fail.</returns>
		private bool connect(int new_baud, string new_protocol)
		{
			if (setBaudrate(new_baud) && setProtocol(new_protocol))
				return connect();
			return false;
		}

		private bool connect()
		{
			return connect(cbLSCRIPT.Checked);
		}

		private bool connect(bool lscript)
		{
			if (serialPort != null)
				return true;

			if (cbPorts.SelectedIndex < 0)
			{
				SetStatus("Select serial port.");
				cbPorts.Focus();
				return false;
			}

			portName = cbPorts.Items[cbPorts.SelectedIndex] as string;
			try
			{
				serialPort = new SerialPort(portName);
				baud = int.Parse(cbSpeed.Items[cbSpeed.SelectedIndex] as string, cultureInfo);
				serialPort.BaudRate = baud;
				serialPort.Parity = Parity.None;
				serialPort.DtrEnable = true;
				protocol = cbProtocol.Items[cbProtocol.SelectedIndex] as string;
				switch (protocol)
				{
					case "Hardware":
						serialPort.Handshake = Handshake.RequestToSend;
						protocol = "RTS";
						break;
					case "None":
						serialPort.Handshake = Handshake.None;
						protocol = "none";
						break;
				}
				serialPort.StopBits = StopBits.Two;
				serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
				serialPort.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				serialPort = null;
			}

			if (serialPort != null)
			{
				btnOpen.Text = "F2 - &Close";
				if (lscript)
					refreshDevice();
				return true;
			}
			return false;
		}
		#endregion

		#region btnPortsRefresh_Click(...) 
		/// <summary>
		/// Disconnect and reload COM ports combobox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPortsRefresh_Click(object sender, EventArgs e)
		{
			disconnect();
			loadPorts();
		}
		#endregion

		#region btnRefresh_Click(...) 
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			folder = folderSelected.Text.Trim();
			loadFolder();
		}
		#endregion

		#region btnDelete_Click(...) 
		private void btnDelete_Click(object sender, EventArgs e)
		{
			deleteDevice(null);
		}

		private void deleteDevice(string skip)
		{
			if (filesDevice.SelectedIndices.Count == 0)
				SetStatus("Select file(s) to delete.");
			else
			{
				string msg = filesDevice.SelectedIndices.Count == 1
					? string.Format("Delete file {0} from device ?", filesDevice.Items[filesDevice.SelectedIndices[0]])
					: "Delete selected file(s) from device ?"
					;
				if (MessageBox.Show(msg,
					"Warning",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button2) == DialogResult.OK
					)
				{
					foreach (int idx in filesDevice.SelectedIndices)
					{
						string fileName = filesDevice.Items[idx].Text;
						if (sendToDeviceOK(string.Format(cultureInfo, "AT#DSCRIPT=\"{0}\"", fileName), 120000))
							SetStatus(string.Format(cultureInfo, "Delete file: {0}", fileName));
						else
							break;
					}
				}
				refreshDevice();
			}
		}
		#endregion

		#region btnOpen_Click(...) 
		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (serialPort == null)
				connect();
			else
				disconnect();
		}
		#endregion

		#region btnCmd_Click(...)
		private void btnCmd_Click(object sender, EventArgs e)
		{
			CmdButton cmd = sender as CmdButton;
			if (cmd != null)
			{
				if (!string.IsNullOrEmpty(cmd.Command) && connect())
					sendToDeviceOK(cmd.Command, 0);
			}
		}
		#endregion

		#region btnRefreshDevice_Click(...) 
		/// <summary>
		/// Refresh GE865 flash files list.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRefreshDevice_Click(object sender, EventArgs e)
		{
			refreshDevice();
		}

		private bool refreshDevice()
		{
			if (serialPort == null && !connect())
				return false;
			if (!sendToDeviceOK("AT#LSCRIPT"))
				return false;

			SortedList<string, int> list = new SortedList<string, int>();
			foreach (string line in splitLines(deviceResponse))
				if (line.StartsWith(CMD_LSCRIPT, StringComparison.Ordinal) &&
					!line.StartsWith("#LSCRIPT: free bytes:", StringComparison.Ordinal)
					)
				{
					int idx = line.IndexOf(",", CMD_LSCRIPT.Length, StringComparison.Ordinal);
					int size = 0;
					string fileName;
					if (idx > 0)
					{
						fileName = line.Substring(CMD_LSCRIPT.Length, idx - CMD_LSCRIPT.Length);
						int.TryParse(line.Substring(idx + 1), out size);
					}
					else
					{
						fileName = line.Substring(CMD_LSCRIPT.Length);
					}
					fileName = fileName.Trim().Trim(CHAR_QUOTE);
					list.Add(fileName, size);
				}

			List<string> selected = new List<string>();
			foreach (ListViewItem item in filesDevice.SelectedItems)
				selected.Add(item.Text);

			filesDevice.Items.Clear();
			foreach (KeyValuePair<string,int> pair in list)
			{
				ListViewItem item = new ListViewItem(new string[] { pair.Key, pair.Value.ToString()});
				filesDevice.Items.Add(item);
				foreach (string select in selected)
					if (select == pair.Key)
					{
						item.Selected = true;
						break;
					}
			}
			return true;
		}
		#endregion

		#region btnEdit_Click(...) 
		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (filesHost.SelectedIndices.Count == 0)
				SetStatus("Select file(s) to edit.");
			else
			{
				foreach (int idx in filesHost.SelectedIndices)
					if (!editFile(filesHost.Items[idx].Text))
						break;
			}
		}
		private bool editFile(string fileName)
		{
			// Change extension from .pyo to .py
			if (Path.GetExtension(fileName).ToLower(cultureInfo) == ".pyo")
				fileName = Path.GetFileNameWithoutExtension(fileName) + ".py";

			string folderName = folderSelected.Text;
			string filePath = Path.Combine(folderName, fileName);

			if (!File.Exists(filePath))
			{
				SetStatus(string.Format(cultureInfo, "File not found: {0}", fileName));
				return false;
			}

			try
			{
				Process process = new Process();
				ProcessStartInfo start = process.StartInfo;
				start.FileName = string.Format(cultureInfo, "\"{0}\"", substitudeVars(editor.Text));
				start.Arguments = string.Format(cultureInfo, settings.EditorOptions, filePath);
				start.WindowStyle = ProcessWindowStyle.Normal;
				start.WorkingDirectory = folderName;
				process.EnableRaisingEvents = true;

				if (!process.Start())
				{
					SetStatus("Can't start editor.");
					return false;
				}
				return true;
			}
			catch (Exception ex)
			{
				SetStatus(ex.Message);
			}
			return false;
		}
		#endregion

		#region btnCompile_Click(...) 
		private void btnCompile_Click(object sender, EventArgs e)
		{
			if (filesHost.SelectedIndices.Count == 0)
				SetStatus("Select file(s) to compile.");
			else
			{
				List<string> processed = new List<string>();
				foreach (int idx in filesHost.SelectedIndices)
				{
					string fileName = filesHost.Items[idx].Text;
					if (string.IsNullOrEmpty(fileName) || fileName.Trim().Length == 0)
						continue;

					if (!compileFile(fileName.Trim(), processed))
						break;
				}
				loadFolder();
			}
		}

		private bool compileFile(string fileName, List<string> processed)
		{
			if (string.IsNullOrEmpty(pythonPath))
			{
				SetStatus("Compiler path not set.");
				return false;
			}
			if (!File.Exists(pythonExe))
			{
				SetStatus(string.Format(cultureInfo, "Compiler not found ({0}).", pythonExe));
				return false;
			}

			// Change extension from .pyo to .py
			if (Path.GetExtension(fileName).ToLower(cultureInfo) == ".pyo")
				fileName = Path.GetFileNameWithoutExtension(fileName) + ".py";

			string folderName = folderSelected.Text;
			string filePath = Path.Combine(folderName, fileName);

			if (!File.Exists(filePath))
			{
				SetStatus(string.Format(cultureInfo, "File not found: {0}", fileName));
				return false;
			}

			if (processed != null && processed.Contains(fileName))
				return true;

			AppendToLog("\r\n");

			try
			{
				Process process = new Process();

				ProcessStartInfo startInfo = process.StartInfo;
				startInfo.FileName = string.Format(cultureInfo, "\"{0}\"", pythonExe);
				startInfo.Arguments = string.Format(cultureInfo, settings.CompilerOptions, pythonPath, filePath);
				startInfo.WindowStyle = ProcessWindowStyle.Minimized;
				startInfo.WorkingDirectory = folderName;
				startInfo.RedirectStandardOutput = true;
				startInfo.RedirectStandardError = true;
				startInfo.UseShellExecute = false;

				if (!process.Start())
				{
					SetStatus("Can't start compiler.");
					return false;
				}

				btnCompile.Enabled = false;
				process.WaitForExit(30000);

				using (StreamReader s = process.StandardError)
				{
					string data = s.ReadToEnd();
					AppendToLog(data);
					s.Close();
				}

				using (StreamReader s = process.StandardOutput)
				{
					string data = s.ReadToEnd();
					AppendToLog(data);
					s.Close();
				}
				if (processed != null)
					processed.Add(fileName);
				return true;
			}
			catch (Exception ex)
			{
				SetStatus(ex.Message);
			}
			finally
			{
				btnCompile.Enabled = true;
			}
			return false;
		}
		#endregion

		#region btnClearLog_Click(...) 
		private void btnClearLog_Click(object sender, EventArgs e)
		{
			log.Text = "";
		}
		#endregion

		#region btnDownload_Click(...) 
		private void btnDownload_Click(object sender, EventArgs e)
		{
			if (serialPort == null && !connect(115200, "RTS"))
				return;
			if (baud != 115200 || protocol != "RTS")
			{
				SetStatus("You need select speed 115200 and Hardware protocol.");
				return;
			}
			if (filesDevice.SelectedIndices.Count > 0)
			{
				string fileName = filesDevice.Items[filesDevice.SelectedIndices[0]].Text;
				string filePath = Path.Combine(folderSelected.Text, fileName);
				if (File.Exists(filePath))
				{
					if (MessageBox.Show(
						string.Format(cultureInfo, "File {0} already exists\n\nOverwrite file ?", fileName),
						"Warning",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning,
						MessageBoxDefaultButton.Button1) != DialogResult.OK)
						return;
				}

				if (sendToDeviceOK("AT#LSCRIPT"))
				{
					string search = string.Concat(CMD_LSCRIPT, " \"", fileName, "\",");
					int fileSize = 0;
					foreach (string line in splitLines(deviceResponse))
						if (line.StartsWith(search, StringComparison.Ordinal))
						{
							search = line.Substring(search.Length);
							if (!int.TryParse(search, NumberStyles.Integer, CultureInfo.InvariantCulture, out fileSize))
								fileSize = 0;
							break;
						}

					if (fileSize == 0)
						SetStatus(string.Format(cultureInfo, "File {0} not found", fileName));
					else
						MessageBox.Show("Not supported", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				}
			}
		}
		#endregion

		#region btnUpload_Click(...) 
		private void btnUpload_Click(object sender, EventArgs e)
		{
			if (filesHost.SelectedIndices.Count == 0)
				SetStatus("Select file(s) to upload.");
			else
			{
				List<string> processed = new List<string>();
				foreach (int idx in filesHost.SelectedIndices)
				{
					string fileName = filesHost.Items[idx].Text;
					if (string.IsNullOrEmpty(fileName) || fileName.Trim().Length == 0)
						continue;
					if (!uploadFile(fileName, processed))
						break;
				}
				refreshDevice();
			}
		}

		private bool uploadFile(string fileOrg, List<string> processed)
		{
			bool result = false;

			if (serialPort == null && !connect(115200, "RTS"))
				return false;
			if (baud != 115200 || protocol != "RTS")
			{
				SetStatus("You need select speed 115200 and Hardware protocol.");
				return false;
			}

			string fileName = fileOrg;
			string filePath = Path.Combine(folderSelected.Text, fileOrg);

			if (Path.GetExtension(fileOrg).ToLower(cultureInfo) == ".py")
			{
				fileName = Path.GetFileNameWithoutExtension(fileOrg) + ".pyo";
				filePath = Path.Combine(folderSelected.Text, fileName);
				if (!File.Exists(filePath))
				{
					fileName = fileOrg;
					filePath = Path.Combine(folderSelected.Text, fileName);
				}
			}

			if (!File.Exists(filePath))
			{
				SetStatus(string.Format(cultureInfo, "File not found: {0}", fileName));
				return false;
			}

			if (processed != null && processed.Contains(fileName))
				return true;

			FileInfo fi = new FileInfo(filePath);
			int hidden = (cbHidden.Checked ? 1 : 0);
			if (sendToDevice(string.Format(cultureInfo, "AT#WSCRIPT=\"{0}\",{1},{2}", fileName, fi.Length, hidden), ">>>", 5000, false))
			{
				byte[] buffer = new byte[256];
				try
				{
					using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
					{
						int readed;
						long loaded = 0;
						while ((readed = fs.Read(buffer, 0, buffer.Length)) > 0)
						{
							serialPort.Write(buffer, 0, readed);
							loaded += (long)readed;
							progress.Value = progress.Minimum + (int)(loaded * (long)progress.Maximum / fi.Length);
							Application.DoEvents();
							if (loaded % 4096 == 0)
								Thread.Sleep(1000);
						}
						fs.Close();

						if (!sendToDeviceOK("", 35000))
							SetStatus("No response from device.");
						else
						{
							SetStatus("Complete.");
							if (processed != null)
								processed.Add(fileName);
							result = true;
						}
						progress.Value = progress.Minimum;
					}
				}
				catch (Exception ex)
				{
					SetStatus(ex.Message);
				}
			}
			return result;
		}

		#endregion

		#region log_KeyPress(...) 
		private void log_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (serialPort != null && serialPort.IsOpen)
			{
				if (e.KeyChar == '\r')
					serialPort.Write("\r\n");
				else
					serialPort.Write(e.KeyChar.ToString());
			}
			if (!cbEcho.Checked)
				e.Handled = true;
		}
		#endregion

		#region btnSelect_Click(...)
		private void btnSelect_Click(object sender, EventArgs e)
		{
			folderDialog.SelectedPath = getFolderName(folderSelected.Text);

			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				folderSelected.Text = folderDialog.SelectedPath.Trim();
				folder = folderSelected.Text;
				loadFolder();
			}
		}
		#endregion

		#region btnSelectCompiler_Click(...) 
		private void btnSelectCompiler_Click(object sender, EventArgs e)
		{
			openFileDialog.Title = "Select compiler";
			openFileDialog.Filter = "Executable|*.exe|All files|*.*";
			setDialogFolder(pythonExe);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				compiler.Text = openFileDialog.FileName;
				pythonPath = Path.GetDirectoryName(openFileDialog.FileName);
				pythonExe = openFileDialog.FileName;
				errorProvider.SetError(btnSelectCompiler, null);
				compiler.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
			}
		}
		#endregion

		#region btnSelectEditor_Click(...) 
		private void btnSelectEditor_Click(object sender, EventArgs e)
		{
			openFileDialog.Title = "Select editor";
			openFileDialog.Filter = "Executable|*.exe|All files|*.*";
			setDialogFolder(editor.Text);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				editor.Text = openFileDialog.FileName;
				editor.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
			}
		}

		private string getFolderName(string filename)
		{
			if (!string.IsNullOrEmpty(filename))
			{
				filename = filename.Trim();
				try
				{
					string path = Path.GetDirectoryName(filename);
					if (!string.IsNullOrEmpty(path))
					{
						string pathx = path;
						foreach (string spc in pathx.Split(new char[] { '\\' }))
						{
							if (spc.StartsWith("%") && spc.EndsWith("%"))
							{
								string sp_path = spc.Trim(new char[] { '%' });
								sp_path = Environment.GetEnvironmentVariable(sp_path);
								path = path.Replace(spc, sp_path);
							}
						}
						if (!string.IsNullOrEmpty(path))
							return path;
					}
				}
				catch { }
			}
			return string.Empty;
		}

		private void setDialogFolder(string filename)
		{
			if (!string.IsNullOrEmpty(filename))
			{
				filename = filename.Trim();
				try
				{
					openFileDialog.InitialDirectory = getFolderName(filename);
					filename = Path.GetFileName(filename);
					if (!string.IsNullOrEmpty(filename))
						openFileDialog.FileName = filename;
				}
				catch { }
			}
		}
		#endregion

		#region btnSetActive_Click(...) 
		private void btnSetActive_Click(object sender, EventArgs e)
		{
			if (connect())
			{
				if (filesDevice.SelectedIndices.Count == 1)
				{
					string fileName = filesDevice.Items[filesDevice.SelectedIndices[0]].Text;
					if (sendToDeviceOK(string.Format(cultureInfo, "AT#ESCRIPT=\"{0}\"", fileName)))
						SetStatus(string.Format(cultureInfo, "Set active script: {0}", fileName));
				}
				else
					SetStatus("Select file to set active.");
			}
		}
		#endregion

		#region btnExecute_Click(...) 
		private void btnExecute_Click(object sender, EventArgs e)
		{
			if (connect())
				sendToDeviceOK("AT#EXECSCR");
		}
		#endregion

		#region files_DoubleClick(object sender, EventArgs e) 
		private void files_DoubleClick(object sender, EventArgs e)
		{
			if (filesHost.SelectedIndices.Count > 0)
			{
				string file = filesHost.Items[filesHost.SelectedIndices[0]].Text;
				if (!String.IsNullOrEmpty(file))
				{
					switch (Path.GetExtension(file).ToLower(cultureInfo))
					{
						case ".py":
							btnEdit_Click(sender, EventArgs.Empty);
							break;
						case ".pyo":
							if (uploadFile(file, null))
								refreshDevice();
							break;
					}
				}
			}
		}

		private void confirmUpload(string skip)
		{
			if (MessageBox.Show("Upload file(s) ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
			{
				btnUpload_Click(btnUpload, EventArgs.Empty);
			}
		}

		#endregion

		#region btnStartMode_Click(object sender, EventArgs e) 
		private void btnStartMode_Click(object sender, EventArgs e)
		{
			if (connect())
			{
				if (sendToDeviceOK("AT#STARTMODESCR=1,10"))
					SetStatus("Set start mode script: 1,10");
			}
		}
		#endregion

		#region btnExit_Click(object sender, EventArgs e) 
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region linkEditor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
		private void linkEditor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.pnotepad.org/");
		}
		#endregion

		#region lblCompiler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
		private void lblCompiler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.roundsolutions.com/techdocs/index.php#docspython");
		}
		#endregion

		#region form_KeyUp(object sender, KeyEventArgs e) 
		private void form_KeyUp(object sender, KeyEventArgs e)
		{
			Keys c = e.KeyCode;
			if (e.Alt && !e.Shift && !e.Control)
			{
				switch (e.KeyCode)
				{
						/*
					case Keys.F:
						e.Handled = true;
						filesHost.Focus();
						if (filesHost.SelectedIndex < 0 && filesHost.Items.Count > 0)
							filesHost.SelectedIndex = 0;
						break;
						 */
					case Keys.D0:
						e.Handled = true;
						btnCmd0.DoClick();
						break;
					case Keys.D1:
						e.Handled = true;
						btnCmd1.DoClick();
						break;
					case Keys.D2:
						e.Handled = true;
						btnCmd2.DoClick();
						break;
					case Keys.D3:
						e.Handled = true;
						btnCmd3.DoClick();
						break;
					case Keys.D4:
						e.Handled = true;
						btnCmd4.DoClick();
						break;
					case Keys.D5:
						e.Handled = true;
						btnCmd5.DoClick();
						break;
					case Keys.D6:
						e.Handled = true;
						btnCmd6.DoClick();
						break;
					case Keys.D7:
						e.Handled = true;
						btnCmd7.DoClick();
						break;
					case Keys.D8:
						e.Handled = true;
						btnCmd8.DoClick();
						break;
					case Keys.D9:
						e.Handled = true;
						btnCmd9.DoClick();
						break;
				}

			}
			else if (!e.Alt && !e.Shift && !e.Control)
			{
				switch(e.KeyCode)
				{
					case Keys.F2:
						e.Handled = true;
						btnOpen.DoClick();
						break;
					case Keys.F3:
						e.Handled = true;
						filesHost.Focus();
						break;
					case Keys.F4:
						e.Handled = true;
						btnEdit.DoClick();
						break;
					case Keys.F5:
						e.Handled = true;
						btnCompile.DoClick();
						break;
					case Keys.F6:
						e.Handled = true;
						btnUpload.DoClick();
						break;
					case Keys.F7:
						e.Handled = true;
						btnSetActive.DoClick();
						break;
					case Keys.F8:
						e.Handled = true;
						btnExecute.DoClick();
						break;
				}
			}
		}
		#endregion

		#region listBox_MouseUp(object sender, MouseEventArgs e) 
		private void listBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ListView list = sender as ListView;
				if (list != null && list.Items.Count > 0)
				{
					Control control = list.GetChildAtPoint(new Point(e.X, e.Y));
					if (control != null)
					{
					}
				}

				ContextMenuStrip menu = list.ContextMenuStrip;
				if (menu != null && menu.Items.Count > 0)
					foreach (ToolStripItem item in menu.Items)
					{
						if (item is ToolStripSeparator)
							continue;
						//! item.Enabled = (list.SelectedIndex >= 0);
					}
			}
		}
		#endregion

		#region cbWordWrap_CheckedChanged(object sender, EventArgs e) 
		private void cbWordWrap_CheckedChanged(object sender, EventArgs e)
		{
			log.WordWrap = cbWordWrap.Checked;
		}
		#endregion

		#region defineCmd(object sender, MouseEventArgs e) 
		private void defineCmd(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				prepareCmdEdit(sender as CmdButton);
			}
		}
		private void defineCmd_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Insert)
			{
				e.Handled = true;
				prepareCmdEdit(sender as CmdButton);
			}
		}

		private void prepareCmdEdit(CmdButton cmd)
		{
			if (cmd != null)
			{
				cancelCmdEdit();
				button_def.Xbutton = cmd;
				button_def.CmdText = cmd.Command;
				cmd.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);

				if (button_def.ShowDialog() == DialogResult.OK)
				{
					cmd.BackColor = Color.FromKnownColor(KnownColor.Control);
					cmd.UseVisualStyleBackColor = true;
					cmd.Focus();

					setCmdUser(cmd, button_def.CmdText.Trim());
				}
				else
				{
					cancelCmdEdit();
				}

			}
		}
		#endregion

		#region cancelCmdEdit() 
		private void cancelCmdEdit()
		{
			if (button_def.Xbutton != null)
			{
				XButton cmd = button_def.Xbutton;
				cmd.BackColor = Color.FromKnownColor(KnownColor.Control);
				cmd.UseVisualStyleBackColor = true;
				cmd.Focus();
			}
			else
				this.Focus();
			button_def.Xbutton = null;
		}
		#endregion

		#region listBox_KeyUp(object sender, KeyEventArgs e)
		private void listBox_KeyUp(object sender, KeyEventArgs e)
		{
			ListBox list = sender as ListBox;
			if (list == null)
				return;
			if (!e.Alt && !e.Shift && e.Control)
			{
				// Ctrl+...
				if (e.KeyCode == Keys.A)
				{
					e.Handled = true;
					for (int i = 0; i < list.Items.Count; i++)
						list.SetSelected(i, true);
				}
			}
			else if (!e.Alt && !e.Shift && !e.Control)
			{
				// Ctrl+...
				if (e.KeyCode == Keys.Delete)
				{
					e.Handled = true;
					this.BeginInvoke(new Action<string>(deleteDevice), string.Empty);
				}
			}
		}
		#endregion

		#region folderSelected_Leave(object sender, EventArgs e) 
		private void folderSelected_Leave(object sender, EventArgs e)
		{
			if (folder != folderSelected.Text.Trim())
			{
				folder = folderSelected.Text.Trim();
				loadFolder();
			}
		}
		#endregion

		private void GPSD_SelectedIndexChanged(object sender, EventArgs e)
		{
			setCmdUser(btnCmd20, "AT$GPSD=" + GPSD.Text);
		}

		private void GPSPS_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (GPSPS.Text == "2")
				setCmdUser(btnCmd24, "AT$GPSPS=" + GPSPS.Text + "," + GPSPS_PTF.Value.ToString("#", CultureInfo.InstalledUICulture));
			else
				setCmdUser(btnCmd24, "AT$GPSPS=" + GPSPS.Text);
		}

		private void GPSPS_PTF_ValueChanged(object sender, EventArgs e)
		{
			GPSPS_SelectedIndexChanged(sender, e);
		}

		private void GPSCMODE_SelectedIndexChanged(object sender, EventArgs e)
		{
			setCmdUser(btnCmd37, "AT$GPSCMODE=" + GPSCMODE.Text);
		}

		private void FTPGETIFIX_NAME_TextChanged(object sender, EventArgs e)
		{
			string cmd = "AT$FTPGETIFIX=";
			if (!string.IsNullOrEmpty(FTPGETIFIX_NAME.Text))
				cmd += FTPGETIFIX_NAME.Text;
			if (FTPGETIFIX_SIZE.Value > 0)
				cmd += "," + FTPGETIFIX_SIZE.Value.ToString("#", CultureInfo.InstalledUICulture);
			setCmdUser(btnCmd28, cmd);
		}

		private void GPSIFIX_EN_SelectedIndexChanged(object sender, EventArgs e)
		{
			string cmd = "AT$GPSIFIX=" + GPSIFIX_EN.Text;
			if (GPSIFIX_EN.Text == "1")
			{
				cmd += "," + GPSIFIX_CGEE.Text;
				cmd += "," + GPSIFIX_SGEE.Text;
				cmd += "," + GPSIFIX_UPDATE.Value.ToString("#", CultureInfo.InstalledUICulture);
			}
			setCmdUser(btnCmd30, cmd);
		}
	}
}

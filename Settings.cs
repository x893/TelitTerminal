using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;

namespace TelitTerminal
{
	[XmlRoot("Settings")]
	public class Settings
	{
		private int baud = 115200;
		private string portName = string.Empty;
		private string protocol = "none";

		private string folder = string.Empty;
		private string editor = "%ProgramFiles%\\Programmer's Notepad\\pn.exe";
		private string compiler = "%ProgramFiles%\\Python\\python.exe";
		private string python_options = "-S -OO \"{0}\\Lib\\Dircompile.py\" \"{1}\"";
		private string editor_options = "\"{0}\"";

		private List<CommandEx> commandsEx;

		public Settings()
		{
			DTR = true;
			CRorCRLF = true;
			RTS = true;
			AutoLSCRIPT = false;
			Echo = false;
			WordWrap = true;
		}

		private static string ConvertToEmpty(string value)
		{
			return (value ?? string.Empty).Trim();
		}

		public string PortName
		{
			get { return portName; }
			set { portName = ConvertToEmpty(value); }
		}
		public int Baud
		{
			get { return baud; }
			set { baud = value; }
		}
		public string Protocol
		{
			get { return protocol; }
			set { protocol = ConvertToEmpty(value); }
		}
		[DefaultValue(true)]
		public bool DTR { get; set; }
		[DefaultValue(true)]
		public bool CRorCRLF { get; set; }
		[DefaultValue(true)]
		public bool RTS { get; set; }
		[DefaultValue(false)]
		public bool AutoLSCRIPT { get; set; }
		[DefaultValue(false)]
		public bool Echo { get; set; }
		[DefaultValue(false)]
		public bool WordWrap { get; set; }

		public string Folder
		{
			get { return folder; }
			set { folder = ConvertToEmpty(value); }
		}

		public string Editor
		{
			get { return editor; }
			set { editor = ConvertToEmpty(value); }
		}
		public string EditorOptions
		{
			get { return editor_options; }
			set { editor_options = value; }
		}

		public string Compiler
		{
			get { return compiler; }
			set { compiler = ConvertToEmpty(value); }
		}
		public string CompilerOptions
		{
			get { return python_options; }
			set { python_options = value; }
		}

		public int Width { get; set; }
		public int Height { get; set; }

		public string[] Commands { get; set; }

		public List<CommandEx> CommandsEx
		{
			get
			{
				if (commandsEx == null)
					commandsEx = new List<CommandEx>();
				return commandsEx;
			}
			set
			{
				commandsEx = value;
			}
		}

		public string GetCommand(int index)
		{
			if (index >= 0 && Commands != null && Commands.Length > index)
				return Commands[index];
			return "";
		}

		public void SetCommand(int index, string text)
		{
			if (index >= 0)
			{
				if (Commands == null)
					Commands = new string[index + 1];
				if (Commands.Length <= index)
				{
					string[] cmds = new string[index + 1];
					Commands.CopyTo(cmds, 0);
					Commands = cmds;
				}
				Commands[index] = text;
			}
		}

		public static string Save(string filename, Settings settings)
		{
			string msg = string.Empty;

			try
			{
				using (MemoryStream ms = new MemoryStream())
				{
					XmlSerializer xs = new XmlSerializer(typeof(Settings));
					xs.Serialize(ms, settings);

					using (FileStream fs = new FileStream(filename, File.Exists(filename) ? FileMode.Truncate : FileMode.Create))
					{
						ms.WriteTo(fs);
						fs.Close();
					}
					ms.Close();
				}
			}
			catch(Exception ex)
			{
				msg = ex.Message;
			}
			return msg;
		}

		public static Settings Load(string filename)
		{
			Settings settings = null;
			if (File.Exists(filename))
			{
				using (FileStream fs = new FileStream(filename, FileMode.Open))
				{
					try
					{
						XmlSerializer xs = new XmlSerializer(typeof(Settings));
						settings = xs.Deserialize(fs) as Settings;
					}
					catch (Exception ex)
					{
						throw ex;
					}
					fs.Close();
				}
			}

			if (settings == null)
				settings = new Settings();

			return settings;
		}

		internal CommandEx FindCommandEx(CmdButton cmd)
		{
			foreach (CommandEx cx in CommandsEx)
				if (cx.Name == cmd.Name)
					return cx;
			return null;
		}
	}
	public class CommandEx
	{
		public CommandEx()
		{
		}

		public CommandEx(CmdButton cmd, string toolTip)
		{
			Name = cmd.Name;
			Command = cmd.Command;
			Text = cmd.Text;
			ToolTip = toolTip;
			Template = cmd.Template;
		}
		public string Name { get; set; }
		public string Command { get; set; }
		public string Text { get; set; }
		public string ToolTip { get; set; }
		public string Template { get; set; }

		public bool Changed(CmdButton cmd)
		{
			return (
				(Command ?? string.Empty) != (cmd.Command ?? string.Empty) ||
				(Text ?? string.Empty) != (cmd.Text ?? string.Empty) ||
				(Template ?? string.Empty) != (cmd.Template ?? string.Empty)
				);
		}

		public override string ToString()
		{
			return string.Concat("[", Text, " (", Command, ")]");
		}
	}
}

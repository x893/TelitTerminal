using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace TelitTerminal
{
	public class Settings
	{
		private int baud = 115200;
		private string portName = string.Empty;
		private string protocol = "RTS";
		private bool dtr = true;
		private bool echo = false;
		private bool wordWrap = true;

		private string folder = string.Empty;
		private string editor = "%ProgramFiles%\\Programmer's Notepad\\pn.exe";
		private string compiler = "%ProgramFiles%\\Python\\python.exe";
		private string python_options = "-S -OO \"{0}\\Lib\\Dircompile.py\" \"{1}\"";
		private string editor_options = "\"{0}\"";

		private int windowX = 0;
		private int windowY = 0;
		private int windowW = 0;
		private int windowH = 0;

		private bool autoLSCRIPT = true;
		private const string DEF_COMMANDS = "AT;AT+CPIN?;AT#MONI;AT+CMEE=2;AT+CREG?;;;;;AT#SHDN;;AT#MONI=0;AT#MONI=7;;;;;;;;AT$GPSD=0;AT$GPSGPIO=4,5,6,7;AT$GPSP=1;AT$GPSP=0;AT$GPSPS=0;;AT$GPSACP?;AT$GPSCON;AT$FTPGETIFIX=;AT$GPSSAV;AT$GPSIFIX=0;AT#GPIO?;AT$GPSGPIO?;AT$GPSP?;AT$GPSPRG;AT$GPSWK;AT$GPSRST;AT$GPSCMODE=0;AT$GPSCMODE?;AT#REBOOT;AT#SHDN;AT$GPSIFIX?";
		private string[] commands;

		private static string prepare_string(string value)
		{
			if (string.IsNullOrEmpty(value))
				return string.Empty;
			return value.Trim();
		}

		public string PortName
		{
			get { return portName; }
			set { portName = prepare_string(value); }
		}
		public int Baud
		{
			get { return baud; }
			set { baud = value; }
		}
		public string Protocol
		{
			get { return protocol; }
			set { protocol = prepare_string(value); }
		}
		public bool DTR
		{
			get { return dtr; }
			set { dtr = value; }
		}
		public bool AutoLSCRIPT
		{
			get { return autoLSCRIPT; }
			set { autoLSCRIPT = value; }
		}
		public bool Echo
		{
			get { return echo; }
			set { echo = value; }
		}
		public bool WordWrap
		{
			get { return wordWrap; }
			set { wordWrap = value; }
		}

		public string Folder
		{
			get { return folder; }
			set { folder = prepare_string(value); }
		}

		public string Editor
		{
			get { return editor; }
			set { editor = prepare_string(value); }
		}
		public string EditorOptions
		{
			get { return editor_options; }
			set { editor_options = value; }
		}

		public string Compiler
		{
			get { return compiler; }
			set { compiler = prepare_string(value); }
		}
		public string CompilerOptions
		{
			get { return python_options; }
			set { python_options = value; }
		}

		public int WindowX
		{
			get { return windowX; }
			set { windowX = value; }
		}
		public int WindowY
		{
			get { return windowY; }
			set { windowY = value; }
		}
		public int WindowW
		{
			get { return windowW; }
			set { windowW = value; }
		}
		public int WindowH
		{
			get { return windowH; }
			set { windowH = value; }
		}

		public string[] Commands
		{
			get
			{
				if (commands == null)
					commands = DEF_COMMANDS.Split(new char[] { ';' });
				return commands;
			}
			set
			{
				commands = value;
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
	}
}
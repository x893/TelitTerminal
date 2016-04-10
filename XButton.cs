using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace TelitTerminal
{
	public class XButton: Button
	{
		static private bool onClick = false;
		protected override void  OnClick(EventArgs e)
		{
			if (!onClick)
			{
				onClick = true;
				this.Enabled = false;
				base.OnClick(e);
				this.Enabled = true;
				this.Focus();
				onClick = false;
			}
		}
		public void DoClick()
		{
			this.OnClick(EventArgs.Empty);
		}
	}

	public class CmdButton : XButton
	{
		[Category("Misc")]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
			}
		}

		[Category("Misc")]
		public string Command { get; set; }
		[Category("Misc")]
		public string Template { get; set; }

		[Category("Misc")]
		public int Index
		{
			get
			{
				string name = Name;
				if (name.Length > 6 && name.StartsWith("btnCmd", StringComparison.InvariantCulture | StringComparison.Ordinal))
				{
					name = name.Substring(6);
					int idx;
					if (int.TryParse(name, NumberStyles.Integer, CultureInfo.InvariantCulture, out idx))
						return idx;
				}
				return -1;
			}
		}
	}
}

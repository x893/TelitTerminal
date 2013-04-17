using System;
using System.Collections.Generic;
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
		public string Command
		{
			get;
			set;
		}

		public int Index
		{
			get
			{
				string name = this.Name;
				if (name.Length > 6)
				{
					name = name.Substring(6);
					int idx;
					if (int.TryParse(name, out idx))
						return idx;
				}
				return -1;
			}
		}
	}
}

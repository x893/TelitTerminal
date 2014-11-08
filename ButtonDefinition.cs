using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TelitTerminal
{
	public partial class ButtonDefinition : Form
	{
		private XButton m_xbutton = null;

		public ButtonDefinition()
		{
			InitializeComponent();
		}

		public XButton Xbutton
		{
			get { return m_xbutton; }
			set { m_xbutton = value; }
		}
		public string CmdCommand
		{
			get { return CmdUserCommand.Text; }
			set { CmdUserCommand.Text = value; }
		}
		public string CmdText
		{
			get { return CmdUserText.Text; }
			set { CmdUserText.Text = value; }
		}
		public string CmdTemplate
		{
			get { return CmdUserTemplate.Text; }
			set { CmdUserTemplate.Text = value; }
		}
		public string CmdToolTip
		{
			get { return CmdUserToolTip.Text; }
			set { CmdUserToolTip.Text = value; }
		}

		private void ButtonDefinition_Shown(object sender, EventArgs e)
		{
			CmdUserText.Focus();
		}
	}
}

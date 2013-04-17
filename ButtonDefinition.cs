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
			set
			{
				m_xbutton = value;
			}
		}
		public string CmdText
		{
			get { return CmdUserText.Text; }
			set { CmdUserText.Text = value; }
		}

		private void ButtonDefinition_Shown(object sender, EventArgs e)
		{
			CmdUserText.Focus();
		}


		/*
		private void CmdUserText_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				cancelCmdEdit();
			}
			else if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				btnCmdUserText_Click(sender, EventArgs.Empty);
			}
		}
		 */

	}
}

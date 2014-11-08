using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TelitTerminal
{
	class TextBoxEx : TextBox
	{
		public TextBoxEx()
		{
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
		}
	}
}

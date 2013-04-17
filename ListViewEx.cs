using System;
using System.Windows.Forms;

namespace TelitTerminal
{
	public class ListViewEx : ListView
	{
		public ListViewEx()
		{
			SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
		}
	}
}

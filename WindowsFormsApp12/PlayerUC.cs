using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
	public partial class PlayerUC : UserControl
	{
		public PlayerUC()
		{
			InitializeComponent();
		}

		private void txtPlayerName_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
				e.Handled = true;
		}

		private void txtPlayerNumber_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrWhiteSpace(txtPlayerNumber.Text))
				{
					var temp = Convert.ToInt32(txtPlayerNumber.Text);
				}
			}
			catch
			{
				txtPlayerNumber.Text = txtPlayerNumber.Text.Substring(0, txtPlayerNumber.Text.Length - 1);
				txtPlayerNumber.SelectionStart = txtPlayerNumber.Text.Length;
			}

		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsAnalize
{
	public partial class FutureIPC : Form
	{
		public FutureIPC()
		{
			InitializeComponent();
			dataGridView1.RowHeadersVisible = false;
			Fill();
		}
		private void Fill()
		{
			double AForLin = 109.26;
			double BForLin = -0.38;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				dataGridView1.Rows.Add(Forms1.numbers[i], Forms1.years[i], Forms1.IPCs[i]);
			}
			int yearlastonpresent = 2020;
			for (int i = Forms1.years.Length+1; i < Forms1.years.Length + 7; i++)
			{
				dataGridView1.Rows.Add(i, yearlastonpresent += 1, Math.Round(AForLin + BForLin * i, 2));
			}
		}
	}
}

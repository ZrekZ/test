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
	public partial class DW_IPC : Form
	{
		private double[] Array_step = new double[Forms1.years.Length];
		public DW_IPC()
		{
			InitializeComponent();
		}
		public DW_IPC(double[] Array)
		{
			InitializeComponent();
			Array_step = Array;
			FillForm();
		}
		private double SumVrpCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				sum += DWIPCData.Rows[i].Cells[numbercell].Value == null ? 0 : Convert.ToDouble(DWIPCData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private void FillForm()
		{
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				DWIPCData.Rows.Add(Forms1.numbers[i], Array_step[i], Math.Round(Forms1.IPCs[i] - Array_step[i], 2), i == 0 ? null : (Math.Round(Math.Pow(((Forms1.VRPs[i] - Array_step[i]) - Convert.ToDouble(DWIPCData.Rows[i - 1].Cells[2].Value.ToString())), 2), 2)), Math.Round(Math.Pow(Forms1.VRPs[i] - Array_step[i], 2), 2));
			}
			DWIPCData.Rows.Add(SumVrpCells(0), SumVrpCells(1), SumVrpCells(2), SumVrpCells(3), SumVrpCells(4));
			DWIPCData.Rows[12].DefaultCellStyle.ForeColor = Color.Red;
			Ldw.Text = "DW = " + Math.Round(Convert.ToDouble(DWIPCData.Rows[12].Cells[3].Value.ToString()) / Convert.ToDouble(DWIPCData.Rows[12].Cells[4].Value.ToString()), 2);
			Ln.Text = "n = " + Forms1.numbers.Length;
			Lk.Text = "k = " + 1;
		}
	}
}

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
	public partial class DW_VRP : Form
	{
		double[] Array_step = new double[Forms1.years.Length];
		public DW_VRP()
		{
			InitializeComponent();
		}
		public DW_VRP(double[] Array)
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
				sum += DWVRPData.Rows[i].Cells[numbercell].Value == null? 0 : Convert.ToDouble(DWVRPData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private void FillForm()
		{
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				DWVRPData.Rows.Add(Forms1.numbers[i],Array_step[i], Math.Round(Forms1.VRPs[i]-Array_step[i],2),i==0?null: (Math.Round(Math.Pow(((Forms1.VRPs[i] - Array_step[i]) - Convert.ToDouble(DWVRPData.Rows[i-1].Cells[2].Value.ToString())),2),2)), Math.Round(Math.Pow(Forms1.VRPs[i] - Array_step[i],2),2));
			}
			DWVRPData.Rows.Add(SumVrpCells(0), SumVrpCells(1), SumVrpCells(2), SumVrpCells(3), SumVrpCells(4));
			DWVRPData.Rows[12].DefaultCellStyle.ForeColor = Color.Red;
			LDW.Text = "DW = " + Math.Round(Convert.ToDouble(DWVRPData.Rows[12].Cells[3].Value.ToString())/ Convert.ToDouble(DWVRPData.Rows[12].Cells[4].Value.ToString()),2);
			Ln.Text = "n = " + Forms1.numbers.Length;
			Lk.Text = "k = " + 1;
		}
	}
}

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
	public partial class IPCtoVRP : Form
	{
		//нулевой столбец - 4 
		public IPCtoVRP()
		{
			InitializeComponent();
			FillForm();
		}
		private void FillForm()
		{
			double a = 5799726.9362;
			A.Text = "A = " + a;
			double b = -44685.791;
			B.Text = "B = " + b;
			for (int i = 1; i < Forms1.years.Length-1; i++)
			{
				IPCtoVRPData.Rows.Add(Forms1.IPCs[i],Forms1.VRPs[i], Math.Round(Math.Pow(Forms1.IPCs[i],2),2),Math.Round(Forms1.IPCs[i]*Forms1.VRPs[i],2),null,Forms1.IPCs[i], Math.Round((b * Forms1.IPCs[i] + a), 2));
			}
			IPCtoVRPData.Rows.Add(SumCells(0), SumCells(1),SumCells(2),SumCells(3),null,SumCells(5), SumCells(6));
			IPCtoVRPData.Rows[10].DefaultCellStyle.ForeColor = Color.Red;
		}
		private double SumCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length - 2; i++)
			{
				sum += IPCtoVRPData.Rows[i].Cells[numbercell].Value == null ? 0 : Convert.ToDouble(IPCtoVRPData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
	}
}

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
	public partial class AutoRegress : Form
	{
		public AutoRegress()
		{
			InitializeComponent();
			AutoData.RowHeadersVisible = false;
			DWAutoData.RowHeadersVisible = false;
			Fill();
			FillDW();
		}
		double[] YtArr = new double[Forms1.years.Length];
		private void Fill()
		{
			double a = -169.669;
			double b = 1.762;
			double s1 = 0.447;
			double ut = -500.67;
			double Ysr = Math.Round(Forms1.VRPs.Sum() / Forms1.VRPs.Length,3);
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				YtArr[i] = Math.Round(a + b * Forms1.IPCs[i] + s1 * (i == 0 ? 0 : Forms1.VRPs[i - 1]) + ut, 2);
			}
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				AutoData.Rows.Add(Forms1.numbers[i], Forms1.years[i], Forms1.IPCs[i], Forms1.VRPs[i], i == 0 ? 0 : Convert.ToDouble(AutoData.Rows[i - 1].Cells[3].Value.ToString()),Math.Round(Math.Pow(Forms1.IPCs[i],2),2), YtArr[i], Math.Round(Math.Pow(Forms1.VRPs[i] - YtArr[i],2),2),Math.Round(Math.Pow(YtArr[i]-Ysr,2),2), Math.Round(Math.Pow(Forms1.VRPs[i]-Ysr,2),2));
			}
			Perem.Text = $"yt = a+bxt + s1yt-1 +ut\n\na = {a}\nb = {b}\ns1 = {s1}\nut = {ut}\nn= {12}\nYсреднее = {Ysr}\nR^2 = {0.24}\nFp = {3.14} \tFt = {7.71}\n\nc.o.  {3.195}\t   \t{0.00029}\ntp   {35.113}\t   \t{-1.772}";
		}
		private double SumDWCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				sum += DWAutoData.Rows[i].Cells[numbercell].Value == null ? 0 : Convert.ToDouble(DWAutoData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private void FillDW()
		{
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				DWAutoData.Rows.Add(Forms1.numbers[i], Math.Round(Forms1.VRPs[i] - YtArr[i], 2), i == 0 ? null : (Math.Round(Math.Pow(((Forms1.VRPs[i] - YtArr[i]) - Convert.ToDouble(DWAutoData.Rows[i - 1].Cells[1].Value.ToString())), 2), 2)), Math.Round(Math.Pow(Forms1.VRPs[i] - YtArr[i], 2), 2));
			}

			DWtxt.Text = $"\nRSS1= {SumDWCells(2)}\nRSS3= {SumDWCells(3)/10}\nDW = {Math.Round((SumDWCells(3)/10)/ SumDWCells(2),2)}";
		}
	}
}

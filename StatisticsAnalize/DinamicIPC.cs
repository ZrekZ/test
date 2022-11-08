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
	public partial class DinamicIPC : Form
	{
		public DinamicIPC()
		{
			InitializeComponent();
			DinamicIPCData.RowHeadersVisible = false;
			DWIPCDinamicData.RowHeadersVisible = false;
			Fill();
			FillDW();
		}
		private double SumIPCCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				sum += Convert.ToDouble(DinamicIPCData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private double SumIPCDWCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				sum += Convert.ToDouble(DWIPCDinamicData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private void Fill()
		{
			double Rsqw = 0.18;
			double a = 62.3;
			double b = 0.414;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				DinamicIPCData.Rows.Add(Forms1.numbers[i], Forms1.years[i], Forms1.IPCs[i], i == 0 ? 0 : Forms1.IPCs[i - 1], i == 0 ? 0 : Math.Round(a + b * Forms1.IPCs[i - 1], 2), i == 0 ? 0 : Math.Round(Math.Round(a + b * Forms1.IPCs[i - 1], 2) - Forms1.IPCs[i], 2));
			}
			DinamicIPCData.Rows.Add(SumIPCCells(0), "-", SumIPCCells(2), SumIPCCells(3), SumIPCCells(4), "-"/*, SumVrpCells(5)*/);
			DinamicIPCData.Rows[12].DefaultCellStyle.ForeColor = Color.Red;

			rsqw.Text = "R^2 = " + Rsqw;
			y.Text = $"Y = {a} + {b} * x";
			y1.Text = $"Y = {a} + {b} * Yi-1";
			sume.Text = $"Сумма отклонений = {SumIPCCells(5)}";
			sre.Text = $"Среднее значание \nотклонений = {Math.Round(SumIPCCells(5) / (Forms1.numbers.Length - 1), 5)}";
		}
		public double[] arrayCellsDinamicIPCData(int numbercell)
		{
			double[] Arr = new double[Forms1.years.Length];
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				Arr[i] = Convert.ToDouble(DinamicIPCData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Arr;
		}
		private void FillDW()
		{
			double[] array_y = arrayCellsDinamicIPCData(4);
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				DWIPCDinamicData.Rows.Add(i == 0 ? 0 :Forms1.IPCs[i], array_y[i],i == 0 ? 0 : Math.Round(Forms1.IPCs[i] - array_y[i], 2), i == 0 ? 0 : (Math.Round(Math.Pow(((Forms1.IPCs[i] - array_y[i]) - Convert.ToDouble(DWIPCDinamicData.Rows[i - 1].Cells[2].Value.ToString())), 2), 2)), i == 0 ? 0 :Math.Round(Math.Pow(Forms1.IPCs[i] - array_y[i], 2), 2));
			}
			DWIPCDinamicData.Rows.Add(SumIPCDWCells(0), SumIPCDWCells(1), SumIPCDWCells(2), SumIPCDWCells(3), SumIPCDWCells(4));
			DWIPCDinamicData.Rows[12].DefaultCellStyle.ForeColor = Color.Red;
			LDW.Text = "DW = 2.29\n" + "k = " + 1 + "\t\tAlfa = 0.05" + $"\n d1 = {1.08} \t d2 = {1.36} \td3 = {Math.Round(4 - 1.36, 2)}"/*+ Math.Round(Convert.ToDouble(DWVRPData.Rows[12].Cells[3].Value.ToString())/ Convert.ToDouble(DWVRPData.Rows[12].Cells[4].Value.ToString()),2)*/;
			Ln.Text = "n = " + Forms1.numbers.Length;
			ab.Text = "a = -0.005 \t b = 4.69\ny ^ = a+b^x\t\nСтепеней свободы = 3.5\nRSS = Σ(y^ - y)^2\t\nFp=RSS3^2/RSS1^2\n 1.36 < DW < 2.64\n => автокорреляция отсутствует";
			RSS.Text = "RSS3^2 = " + 14.24/*rezRSS1()*/ + " \t\nRSS1^2 = " + 7.47/*rezRSS3()*/ + "\t\nFp = " + 1.91 /*Math.Round(rezRSS1()/rezRSS3(),2)*/ + "\t\nFt = " + 7.71 + "\nТак как Fp<Ft, то гетероскедантичность отсутсвует ";
		}

	}
}

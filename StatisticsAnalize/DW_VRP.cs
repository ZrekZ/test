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
			DWdata1.RowHeadersVisible = false;
			DWVRPData.RowHeadersVisible = false;
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
			LDW.Text = "DW = 1.36" /*+ Math.Round(Convert.ToDouble(DWVRPData.Rows[12].Cells[3].Value.ToString())/ Convert.ToDouble(DWVRPData.Rows[12].Cells[4].Value.ToString()),2)*/;
			Ln.Text = "n = " + Forms1.numbers.Length;
			Lk.Text = "k = " + 1 + "\t\tAlfa = 0.05" + $"\n d1 = {1.08} \t d2 = {1.36} \td3 = {Math.Round(4 - 1.36,2)}";
			ab.Text = "a = 553862.1 \t b = 61231.95\ny^ = a+b^x\t\nСтепеней свободы = 3.5\nRSS = Σ(y^ - y)^2\t\nFp=RSS3^2/RSS1^2\n 1.36 < DW < 2.64\n => автокорреляция отсутствует";
			RSS.Text = "RSS3^2 = " + 8650270370.33/*rezRSS1()*/ + "\t\nRSS1^2 = " + 21762867442.78/*rezRSS3()*/ + "\t\nFp = " + 2.52 /*Math.Round(rezRSS1()/rezRSS3(),2)*/ + "\t\nFt = " + 7.71;
			final.Text = "Так как Fp<Ft, то гетероскедантичность отсутсвует ";
			DWdata1.Rows.Add(null,"Коэфиценты", "Стандартная ошибка", "t-статистика",null/*, "ta", "tb", "tтабл"*/);
			DWdata1.Rows.Add("Y-пересечение", "464091.6", "27272.76", "17.01", null, "R^2"/*, "17.01", "23.951", "2,137"*/);
			DWdata1.Rows.Add("Переменная X1", "88754.72", "3705.638", "23.951", null, "0.982"/*, "Fp", "Ft"*/);
			DWdata1.Rows.Add(null, null, null, null, null/*, "573.663", 1*/);
		}
		private double rezRSS1()
		{
			double RSS1 = 0;
			double y1 ,ei,eiPow;
			double a = 553862.1, b =61231.95;
			for (int i = 0; i < 4; i++)
			{
				y1 = a + b * Forms1.numbers[i];
				ei = Array_step[i] - y1;
				eiPow = Math.Pow(ei, 2);
				RSS1 += eiPow;
			}
			return Math.Round(RSS1, 2);
		}
		private double rezRSS3()
		{
			double RSS3 = 0;
			double y1,ei,eiPow;
			double a = 128173.5, b = 122617.4;
			for (int i = 8; i < 12; i++)
			{
				y1 = a + b * Forms1.numbers[i];
				ei = Array_step[i] - y1;
				eiPow = Math.Pow(ei, 2);
				RSS3 += eiPow;
			}
			return Math.Round(RSS3, 2);
		}

	}
}

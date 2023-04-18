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
	public partial class DinamicVRP : Form
	{
		public DinamicVRP()
		{
			InitializeComponent();
			DinamicVRPData.RowHeadersVisible = false;
			DWVRPDinamicData.RowHeadersVisible = false;
			Fill();
			FillDW();
		}
		private double SumVrpCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				sum += Convert.ToDouble(DinamicVRPData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private double SumVrpDWCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				sum += Convert.ToDouble(DWVRPDinamicData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private void Fill()
		{
			double Rsqw = 0.93;
			double a = 186344.3725;
			double b = 0.893059332;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				DinamicVRPData.Rows.Add(i == 0 ? 0 : Forms1.numbers[i], i == 0 ? 0 : Forms1.years[i], i == 0 ? 0 : Forms1.VRPs[i], i==0? 0 : Forms1.VRPs[i-1], i==0? 0 : Math.Round(a+b*Forms1.VRPs[i-1],2),i==0? 0 :  Math.Round(Math.Round(a + b * Forms1.VRPs[i - 1], 2) - Forms1.VRPs[i],2));
			}
			DinamicVRPData.Rows.Add(SumVrpCells(0), "-", SumVrpCells(2), SumVrpCells(3), SumVrpCells(4),"-"/*, SumVrpCells(5)*/);
			DinamicVRPData.Rows[12].DefaultCellStyle.ForeColor = Color.Red;

			rsqw.Text = "R^2 = " + Rsqw;
			y.Text = $"Y = {a} + {b} * x\nY = {a} + {b} * Yi-1\nYt-1 - ВРП за предыдущий момент времени";
			//y1.Text = $"Y = {a} + {b} * Yi-1\nYt-1 - ВРП за предыдущий момент времени";
			sume.Text = $"Сумма отклонений = {SumVrpCells(5)}";
			sre.Text = $"Среднее значание \nотклонений = {Math.Round(SumVrpCells(5) / (Forms1.numbers.Length - 1),5)}\nТ-статистика (|{-9.829}|)  (|{10.943}|)\nT-табличн.    ({2.179})   ({2.179})\nСледовательно:\nкоэф.А - значим.\n-> ВРП за предыдущий\nот начального момента времени (const)\nкоэф. В - значим.\n-> в среднем увеличение ВРП на единицу\nв предыдущий период влияет\nна ВРП в текущем моменте врмени\nв среднем увеличивая его на {Math.Round(b,3)} ед.\nR^2 -> 1 => Изменение времени \nобъясняет изменение ВРП на 93%.";
		}
		public double[] arrayCellsDinamicVRPData(int numbercell)
		{
			double[] Arr = new double[Forms1.years.Length];
			for (int i = 0; i <Forms1.years.Length; i++)
			{
				Arr[i] = Convert.ToDouble(DinamicVRPData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Arr;
		}
		private void FillDW()
		{
			double[] array_y = arrayCellsDinamicVRPData(4);
			for (int i = 0; i < Forms1.years.Length; i++)
			{
					DWVRPDinamicData.Rows.Add(i == 0 ? 0 :Forms1.VRPs[i], i == 0 ? 0 :array_y[i], i == 0 ? 0 :Math.Round(Forms1.VRPs[i] - array_y[i], 2), i == 0 ? 0 : (Math.Round(Math.Pow(((Forms1.VRPs[i] - array_y[i]) - Convert.ToDouble(DWVRPDinamicData.Rows[i - 1].Cells[2].Value.ToString())), 2), 2)), i == 0 ? 0 :Math.Round(Math.Pow(Forms1.VRPs[i] - array_y[i], 2), 2));
			}
			DWVRPDinamicData.Rows.Add(SumVrpDWCells(0), SumVrpDWCells(1), SumVrpDWCells(2), SumVrpDWCells(3), SumVrpDWCells(4));
			DWVRPDinamicData.Rows[12].DefaultCellStyle.ForeColor = Color.Red;
			LDW.Text = "DW = 2.1\n" + "k = " + 1 + "\t\tAlfa = 0.05" + $"\n d1 = {1.08} \t d2 = {1.36} \td3 = {Math.Round(4 - 1.36, 2)}"/*+ Math.Round(Convert.ToDouble(DWVRPData.Rows[12].Cells[3].Value.ToString())/ Convert.ToDouble(DWVRPData.Rows[12].Cells[4].Value.ToString()),2)*/;
			Ln.Text = "n = " + Forms1.numbers.Length;
			ab.Text = "a = 186344.3725 \t b = 0.893059332\ny ^ = a+b^x\t\nСтепеней свободы = 3.5\nRSS = Σ(y^ - y)^2\t\nFp=RSS3^2/RSS1^2\n 1.36 < DW < 2.64\n => автокорреляция отсутствует";
			RSS.Text = "RSS3^2 = " + 8650270370.33/*rezRSS1()*/ + "\t\nRSS1^2 = " + 3176286744.78/*rezRSS3()*/ + "\t\nFp = " + 2.52 /*Math.Round(rezRSS1()/rezRSS3(),2)*/ + "\t\nFt = " + 7.71 + "\nТак как Fp<Ft, то гетероскедантичность отсутсвует ";
		}

		private void DinamicVRP_Load(object sender, EventArgs e)
		{

		}
	}
}

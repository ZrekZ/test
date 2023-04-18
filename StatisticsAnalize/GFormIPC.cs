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
	public partial class GFormIPC : Form
	{
		static double[] Arr_y = new double[Forms1.years.Length];
		static double[] Arr_ylin = new double[Forms1.years.Length];
		static double[] Arr_ypokaz = new double[Forms1.years.Length];
		static double[] Arr_ystep = new double[Forms1.years.Length];
		static double[] Arr_ystr = new double[Forms1.years.Length];
		static double[] Arr_ypss = new double[Forms1.years.Length];
		static double[] Arr_yess = new double[Forms1.years.Length];
		public GFormIPC()
		{
			InitializeComponent();
		}
		public GFormIPC(double[] Arry, double[] Arrylin, double[] Arrypokaz, double[] Arrystep, double[] Arrystr, double[] Arrypss, double[] Arryess)
		{
			InitializeComponent();
			Arr_y = Arry;
			Arr_ylin = Arrylin;
			Arr_ypokaz = Arrypokaz;
			Arr_ystep = Arrystep;
			Arr_ystr = Arrystr;
			Arr_ypss = Arrypss;
			Arr_yess = Arryess;
		}
		private double ArrayHalf(double[] Ar)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length; i++)
				sum += Ar[i];
			double halfOn = sum / Forms1.years.Length;
			return halfOn;
		}
		private double SumIpcCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				sum += Convert.ToDouble(GIpcData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private void GFormIPC_Load(object sender, EventArgs e)
		{
			int p = 1;
			for (int i = 0; i < Forms1.years.Length; i++)
			{
				GIpcData.Rows.Add(/*1*/Math.Pow(Arr_ylin[i] - Arr_y[i], 2),/*2*/Math.Pow(Arr_y[i] - ArrayHalf(Arr_ylin), 2),/*3*/Math.Pow(Arr_ypokaz[i] - Arr_y[i], 2),/*4*/Math.Pow(Arr_y[i] - ArrayHalf(Arr_ypokaz), 2),/*5*/Math.Pow(Arr_ystep[i] - Arr_y[i], 2), Math.Pow(Arr_y[i] - ArrayHalf(Arr_ystep), 2),/*6*/Math.Pow(Arr_ypss[i] - Arr_y[i], 2),/*7*/i == 0 ? 0 : i == 11 ? 0 : Math.Pow(Arr_y[i] - ArrayHalf(Arr_ypss), 2),/*8*/i == 0 ? 0 : i == 11 ? 0 : Math.Pow(Arr_yess[i] - Arr_y[i], 2),/*9*/Math.Pow(Arr_y[i] - ArrayHalf(Arr_yess), 2));
			}
			GIpcData.Rows.Add(SumIpcCells(0), SumIpcCells(1), SumIpcCells(2), SumIpcCells(3), SumIpcCells(4), SumIpcCells(5), SumIpcCells(6), SumIpcCells(7), SumIpcCells(8), SumIpcCells(9));
			GIpcData.Rows[12].DefaultCellStyle.ForeColor = Color.Red;

			GostlinPow.Text = "Gost^2 лин. = " + SumIpcCells(0) / (Forms1.years.Length - 1 - p);
			GostpokPow.Text = "Gost^2 пок. = " + SumIpcCells(2) / (Forms1.years.Length - 1 - p);
			GoststepPow.Text = "Gost^2 степ. = " + SumIpcCells(4) / (Forms1.years.Length - 1 - p);
			GostpssPow.Text = "Gost^2 п.с.с. = " + SumIpcCells(6) / (Forms1.years.Length - 1 - p);
			GostessPow.Text = "Gost^2 э.с.с. = " + SumIpcCells(8) / (Forms1.years.Length - 1 - p);

			GylinPow.Text = "Gy^2 лин. = " + SumIpcCells(1) / (Forms1.years.Length - 1);
			GypokPow.Text = "Gy^2 пок. = " + SumIpcCells(3) / (Forms1.years.Length - 1);
			GystepPow.Text = "Gy^2 степ. = " + SumIpcCells(5) / (Forms1.years.Length - 1);
			GypssPow.Text = "Gy^2 п.с.с. = " + SumIpcCells(7) / (Forms1.years.Length - 1);
			GyessPow.Text = "Gy^2 э.с.с. = " + SumIpcCells(9) / (Forms1.years.Length - 1);

			Fplin.Text = "Fp лин. = " + (SumIpcCells(1) / (Forms1.years.Length - 1)) / (SumIpcCells(0) / (Forms1.years.Length - 1 - p));
			Fppok.Text = "Fp пок. = " + (SumIpcCells(3) / (Forms1.years.Length - 1)) / (SumIpcCells(2) / (Forms1.years.Length - 1 - p));
			Fpstep.Text = "Fp степ. = " + (SumIpcCells(5) / (Forms1.years.Length - 1)) / (SumIpcCells(4) / (Forms1.years.Length - 1 - p));
			Fppss.Text = "Fp п.с.с. = " + (SumIpcCells(7) / (Forms1.years.Length - 1)) / (SumIpcCells(6) / (Forms1.years.Length - 1 - p));
			Fpess.Text = "Fp э.с.с. = " + (SumIpcCells(9) / (Forms1.years.Length - 1)) / (SumIpcCells(8) / (Forms1.years.Length - 1 - p));
		}
	}
}

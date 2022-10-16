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
	public partial class Forms1 : Form
	{
		static public int[] numbers = { 1,2,3,4,5,6,7,8,9,10,11,12};
		static public int[] years = { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };
		static public double[] VRPs = { 539831.5, 623116.8, 840101.1, 860342.7, 880264.4, 974192.9, 1063780.3, 1147634.0, 1245826.9, 1422704.6, 1496401.4, 1403198.8 };
		static public double[] IPCs = { 110.2, 106.7, 107.3, 106.5, 110.4, 112.6, 105.4, 101.4, 103.8, 103.1, 104.5, 108.9 };
		public Forms1()
		{
			InitializeComponent();
			DefData.RowHeadersVisible = false;
			VRPdata.RowHeadersVisible = false;
			IPCdata.RowHeadersVisible = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			VisibleForm(null);
		}
		private void VisibleLabel(bool flag)
		{
			//pictureBox1.Visible = false;
			ldef.Visible = false;
			Lipc.Visible = false;
			Lvrp.Visible = false;
			if (flag == true)
			{
				lalin.Visible = true;
				lblin.Visible = true;
				lapokaz.Visible = true;
				lbpokaz.Visible = true;
				lastep.Visible = true;
				lbstep.Visible = true;
				lalfa.Visible = true;
				lt.Visible = true;
			}
			else
			{
				lalin.Visible = false;
				lblin.Visible = false;
				lapokaz.Visible = false;
				lbpokaz.Visible = false;
				lastep.Visible = false;
				lbstep.Visible = false;
				lalfa.Visible = false;
				lt.Visible = false;
			}
				
		}
		private void VisibleForm(string form)
		{
				DefData.Visible = false;
				VRPdata.Visible = false;
				IPCdata.Visible = false;
				VisibleLabel(false);
			if (form == "DEF")
			{
				ldef.Visible = false;
				Lipc.Visible = false;
				Lvrp.Visible = false;
				DefData.Visible = true;
				VisibleLabel(false);
				ldef.Visible = true;
			}
			if (form == "VRP")
			{
				ldef.Visible = false;
				Lipc.Visible = false;
				Lvrp.Visible = false;
				VRPdata.Visible = true;
				VisibleLabel(true);
				Lvrp.Visible = true;
			}
			if (form == "IPC")
			{
				ldef.Visible = false;
				Lipc.Visible = false;
				Lvrp.Visible = false;
				IPCdata.Visible = true;
				VisibleLabel(true);
				Lipc.Visible = true;
			}
			if (form == "PIC")
			{
				ldef.Visible = false;
				Lipc.Visible = false;
				Lvrp.Visible = false;
				DefData.Visible = false;
				VisibleLabel(false);
			}

		}
		private void FillTableDefault()
		{
			VisibleForm("DEF");

			for (int i = 0; i < years.Length; i++)
			{
				DefData.Rows.Add(years[i],VRPs[i],IPCs[i]);
			}
			
		}
		public double[] arrayCellsVRP(int numbercell)
		{
			double[] Arr = new double[years.Length];
			for (int i = 0; i < years.Length; i++)
			{
				Arr[i] = Convert.ToDouble(VRPdata.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Arr;
		}
		public double[] arrayCellsIPC(int numbercell)
		{
			double[] Arr = new double[years.Length];
			for (int i = 0; i < years.Length; i++)
			{
				Arr[i] = Convert.ToDouble(IPCdata.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Arr;
		}
		private double SumIpcCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < years.Length; i++)
			{
				sum += Convert.ToDouble(IPCdata.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
		private double SumVrpCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < years.Length; i++)
			{
				sum += Convert.ToDouble(VRPdata.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum,2);
		}
		public void FillTableVRP()
		{
			VisibleForm("VRP");
			double AForLin = 80886899 / 165;   lalin.Text = "A линейное = " + AForLin;
			double BForLin = 121269717 / 1430; lblin.Text = "B линейное = " + BForLin;

			double AForPokaz = 566368.38366; lapokaz.Text = "A показательное = " + AForPokaz;
			double BForPokaz = 1.09068; lbpokaz.Text = "B показательное = " + BForPokaz;

			double AForStep = 13.247; lastep.Text = "A степенное = " + AForStep;
			double BForStep = 0.0868; lbstep.Text = "B степенное = " + BForStep;

			double alfa = 0.5; lalfa.Text = "Альфа = " + alfa;
			double T = Math.Pow(VRPs[11]/VRPs[0],(1/numbers[11]-1)); lt.Text = "T = " + T;

			for (int i = 0; i < years.Length; i++)
			{
				/*	1-номер(х) 2-год 3-ВРП(у) 4-x^2 5-x*y 6-Lnx 7-Lny 8-Lnx*Lny 9-x*Lny 10-Ylin 11-Ypok 12-Ystep 13-Ystr 14-Ypss 15-Yess*/
				VRPdata.Rows.Add(numbers[i]/*1*/, years[i]/*2*/, VRPs[i]/*3*/, Math.Pow(numbers[i], 2)/*4*/, Math.Round(VRPs[i] * numbers[i], 2)/*5*/, Math.Round(Math.Log(numbers[i]), 2)/*6*/, Math.Round(Math.Log(VRPs[i]), 2)/*7*/, Math.Round(Math.Log(numbers[i]) * Math.Log(VRPs[i]), 2)/*8*/, Math.Round((numbers[i]) * Math.Log(VRPs[i]),2)/*9*/, Math.Round((AForLin+BForLin*numbers[i]),2)/*10*/, Math.Round((AForPokaz*(Math.Pow(BForPokaz,numbers[i]))),2)/*11*/, Math.Round((Math.Pow(Math.E,(AForStep+BForStep*numbers[i]))),2)/*12*/, Math.Round((VRPs[i]*Math.Pow(T,numbers[i]-1)),2)/*13*/, Math.Round((numbers[i] == 1 ? 0 : numbers[i] == 12 ? 0 :(VRPs[i-1]+VRPs[i]+VRPs[i+1])/3),2)/*14*/, Math.Round(numbers[i]==1?VRPs[i]:((alfa*VRPs[i])+((1-alfa)* (Convert.ToDouble(VRPdata.Rows[i-1].Cells[14].Value.ToString())))),2)/*15*/);
			}
			
			VRPdata.Rows.Add(SumVrpCells(0), "-", SumVrpCells(2), SumVrpCells(3), SumVrpCells(4), SumVrpCells(5), SumVrpCells(6), SumVrpCells(7),SumVrpCells(8));
			VRPdata.Rows[12].DefaultCellStyle.ForeColor = Color.Red;
			VRPdata.Rows.Add();
			VRPdata.Rows.Add(null, "Коэфиценты", "Стандартная ошибка", "t-статистика", null, "ta", "tb"/*, "tтабл"*/);
			VRPdata.Rows.Add("Y-пересечение", 490223.6,38334.3, 12.788, null, 12.788, 16.281/*, 1*/);
			VRPdata.Rows.Add("Переменная X1", 84804, 5208.6, 16.281, null, "R^2", "Fp"/*, "Ft"*/);
			VRPdata.Rows.Add(null, null, null, null, null, 0.963, 265.08/*, 1*/);
		}
		public void FillTableIPC()
		{
			VisibleForm("IPC");
			double AForLin = 109.26; lalin.Text = "A линейное = " + AForLin;
			double BForLin = -0.38; lblin.Text = "B линейное = " + BForLin;

			double AForPokaz = /*104.489*/109.34412; lapokaz.Text = "A показательное = " + AForPokaz;
			double BForPokaz = /*1.003*/ 0.99623; lbpokaz.Text = "B показательное = " + BForPokaz;

			double AForStep = Math.Log(AForPokaz); lastep.Text = "A степенное = " + AForStep;
			double BForStep = Math.Log(BForPokaz); lbstep.Text = "B степенное = " + BForStep;

			double alfa = 0.8; lalfa.Text = "Альфа = " + alfa;
			double T = Math.Pow(IPCs[11]/ IPCs[0],(1/(numbers[11]-1))); lt.Text = "T = " + T;
			
			for (int i = 0; i < years.Length; i++)
			{
				/*	1-номер(х) 2-год 3-ИПЦ(у) 4-x^2 5-x*y 6-Lnx 7-Lny 8-Lnx*Lny 9-x*Lny 10-Ylin 11-Ypok 12-Ystep 13-Ystr 14-Ypss 15-Yess*/
				IPCdata.Rows.Add(numbers[i]/*1*/, years[i]/*2*/, IPCs[i]/*3*/, Math.Pow(numbers[i], 2)/*4*/, Math.Round(IPCs[i] * numbers[i], 2)/*5*/, Math.Round(Math.Log(numbers[i]), 2)/*6*/, Math.Round(Math.Log(IPCs[i]), 2)/*7*/, Math.Round(Math.Log(numbers[i]) * Math.Log(IPCs[i]), 2)/*8*/, Math.Round((numbers[i]) * Math.Log(IPCs[i]), 2)/*9*/, Math.Round((AForLin + BForLin * numbers[i]), 2)/*10*/, Math.Round((AForPokaz * (Math.Pow(BForPokaz, numbers[i]))), 2)/*11*/, Math.Round((Math.Pow(Math.E, (AForStep + BForStep * numbers[i]))), 2)/*12*/, Math.Round((IPCs[i] * Math.Pow(T, numbers[i] - 1)), 2)/*13*/, Math.Round((numbers[i] == 1 ? 0 : numbers[i] == 12 ? 0 : (IPCs[i - 1] + IPCs[i] + IPCs[i + 1]) / 3), 2)/*14*/, Math.Round(numbers[i] == 1 ? IPCs[i] : ((alfa * IPCs[i]) + ((1 - alfa) * (Convert.ToDouble(IPCdata.Rows[i - 1].Cells[14].Value.ToString())))), 2)/*15*/);
			}

			IPCdata.Rows.Add(SumIpcCells(0), "-", SumIpcCells(2), SumIpcCells(3), SumIpcCells(4), SumIpcCells(5), SumIpcCells(6), SumIpcCells(7), SumIpcCells(8));
			IPCdata.Rows[12].DefaultCellStyle.ForeColor = Color.Red;
			IPCdata.Rows.Add();
			IPCdata.Rows.Add(null, "Коэфиценты", "Стандартная ошибка", "t-статистика", null, "ta", "tb"/*, "tтабл"*/);
			IPCdata.Rows.Add("Y-пересечение","109.249", "1,951", "55,995", null, "55,995", "-1,462"/*, "2,137"*/);
			IPCdata.Rows.Add("Переменная X1","-0.387", "0,265", "-1,462", null, "R^2", "Fp"/*, "Ft"*/);
			IPCdata.Rows.Add(null,null,null,null,null, "0,176", "2,137"/*, 1*/);
		}

		private void табличныйToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DefData.Rows.Clear();
			FillTableDefault();
		}
		private void табличныйToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			VRPdata.Rows.Clear();
			FillTableVRP();
		}
		private void табличныйToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			IPCdata.Rows.Clear();
			FillTableIPC();
		}

		private void графическийToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Откройте файл excel");
		}

		private void графическийToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Откройте файл excel");
		}

		private void графическийToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Откройте файл excel");
		}

		private void gToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try 
			{ 
				GFormVRP form = new GFormVRP(arrayCellsVRP(2), arrayCellsVRP(9), arrayCellsVRP(10), arrayCellsVRP(11), arrayCellsVRP(12), arrayCellsVRP(13), arrayCellsVRP(14));
				form.ShowDialog();
			}
			catch
			{
				MessageBox.Show("Откройте таблицу значений");
			};
			
		}

		private void gToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				GFormIPC form = new GFormIPC(arrayCellsVRP(2), arrayCellsVRP(9), arrayCellsVRP(10), arrayCellsVRP(11), arrayCellsVRP(12), arrayCellsVRP(13), arrayCellsVRP(14));
				form.ShowDialog();
			}
			catch
			{
				MessageBox.Show("Откройте таблицу значений");
			}
		}

		private void рассчетDWToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DW_VRP form = new DW_VRP(arrayCellsVRP(11));
				form.ShowDialog();
			}
			catch
			{
				MessageBox.Show("Откройте таблицу значений");
			}
		}

		private void рассчетDWToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				DW_IPC form = new DW_IPC(arrayCellsIPC(11));
				form.ShowDialog();
			}
			catch
			{
				MessageBox.Show("Откройте таблицу значений");
			}
		}

		private void рассчетToolStripMenuItem_Click(object sender, EventArgs e)
		{
			VRPtoIPC form = new VRPtoIPC();
			form.ShowDialog();
		}

		private void рассчетToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			IPCtoVRP form = new IPCtoVRP();
			form.ShowDialog();
		}

		private void графикToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Откройте файл excel");
		}

		private void графикToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Откройте файл excel");
		}
	}
}

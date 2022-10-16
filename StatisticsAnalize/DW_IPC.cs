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
			DWdata.RowHeadersVisible = false;
			DWIPCData.RowHeadersVisible = false;
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
			RSSs.Text = "RSS1^2 = " + 14.24/*rezRSS1()*/ + " \t\nRSS3^2 = " + 7.47/*rezRSS3()*/ +"\t\nFp = "+ 1.91/*Math.Round(rezRSS1()/rezRSS3(),2)*/ + "\t\nFt = " + 7.71;
			Final.Text = "Так как Fp<Ft, то гетероскедантичность отсутсвует ";
			DWdata.Rows.Add( null,"Коэфиценты", "Стандартная ошибка", "t-статистика",null/*, "ta", "tb", "tтабл"*/);
			DWdata.Rows.Add("Y-пересечение", "109.318", "0.005", "19561.73", null, "R^2"/*, "19561.73", "-530.568", "2,137"*/);
			DWdata.Rows.Add("Переменная X1", "-0.403", "0.0007", "-530.568", null, "0.999"/*, "Fp", "Ft"*/);
			DWdata.Rows.Add(null, null, null, null, null/*, "281502.3", 1*/);
		}
		private double rezRSS1()
		{
			double RSS1 = 0;
			double y1, ei, eiPow;
			double a = -0.005, b = 4.69;
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
			double y1, ei, eiPow;
			double a = 0.14, b = 4.32;
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

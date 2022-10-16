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
	public partial class VRPtoIPC : Form
	{
		//нулевой столбец - 4 
		public VRPtoIPC()
		{
			InitializeComponent();
			FillForm();
		}
		private void FillForm()
		{
			for (int i = 1; i < Forms1.years.Length - 1; i++)
			{
				VRPtoIPCData.Rows.Add(Forms1.VRPs[i], Forms1.IPCs[i], Math.Round(Math.Pow(Forms1.VRPs[i], 2), 2), Math.Round(Forms1.IPCs[i] * Forms1.VRPs[i], 2), null, Forms1.VRPs[i]);

			}
			VRPtoIPCData.Rows.Add(SumCells(0), SumCells(1), SumCells(2), SumCells(3), null, SumCells(5));
			VRPtoIPCData.Rows[10].DefaultCellStyle.ForeColor = Color.Red;
		}

		private double SumCells(int numbercell)
		{
			double sum = 0;
			for (int i = 0; i < Forms1.years.Length - 2; i++)
			{
				sum += VRPtoIPCData.Rows[i].Cells[numbercell].Value == null ? 0 : Convert.ToDouble(VRPtoIPCData.Rows[i].Cells[numbercell].Value.ToString());
			}
			return Math.Round(sum, 2);
		}
	}
}

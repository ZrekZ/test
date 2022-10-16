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
				VRPtoIPCData.Rows.Add(Forms1.VRPs[i], Forms1.IPCs[i], Math.Round(Math.Pow(Forms1.VRPs[i], 2),2), Math.Round(Forms1.IPCs[i] * Forms1.VRPs[i],2), null, Forms1.VRPs[i]);
			}
		}
	}
}

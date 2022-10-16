
namespace StatisticsAnalize
{
	partial class DW_IPC
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DWIPCData = new System.Windows.Forms.DataGridView();
			this.DW_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DW_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DwEi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deltaEiPow = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EiPow = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ldw = new System.Windows.Forms.Label();
			this.Ln = new System.Windows.Forms.Label();
			this.Lk = new System.Windows.Forms.Label();
			this.DWdata = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RSSs = new System.Windows.Forms.Label();
			this.Final = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DWIPCData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DWdata)).BeginInit();
			this.SuspendLayout();
			// 
			// DWIPCData
			// 
			this.DWIPCData.AllowUserToAddRows = false;
			this.DWIPCData.AllowUserToDeleteRows = false;
			this.DWIPCData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.DWIPCData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DWIPCData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DWIPCData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DW_x,
            this.DW_y,
            this.DwEi,
            this.deltaEiPow,
            this.EiPow});
			this.DWIPCData.Location = new System.Drawing.Point(0, 0);
			this.DWIPCData.Name = "DWIPCData";
			this.DWIPCData.ReadOnly = true;
			this.DWIPCData.RowHeadersWidth = 51;
			this.DWIPCData.RowTemplate.Height = 29;
			this.DWIPCData.Size = new System.Drawing.Size(582, 418);
			this.DWIPCData.TabIndex = 0;
			// 
			// DW_x
			// 
			this.DW_x.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DW_x.HeaderText = "X";
			this.DW_x.MinimumWidth = 6;
			this.DW_x.Name = "DW_x";
			this.DW_x.ReadOnly = true;
			// 
			// DW_y
			// 
			this.DW_y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DW_y.HeaderText = "Y_step";
			this.DW_y.MinimumWidth = 6;
			this.DW_y.Name = "DW_y";
			this.DW_y.ReadOnly = true;
			// 
			// DwEi
			// 
			this.DwEi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DwEi.HeaderText = "Ei";
			this.DwEi.MinimumWidth = 6;
			this.DwEi.Name = "DwEi";
			this.DwEi.ReadOnly = true;
			// 
			// deltaEiPow
			// 
			this.deltaEiPow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.deltaEiPow.HeaderText = "(Ei-Ei-1)^2";
			this.deltaEiPow.MinimumWidth = 6;
			this.deltaEiPow.Name = "deltaEiPow";
			this.deltaEiPow.ReadOnly = true;
			// 
			// EiPow
			// 
			this.EiPow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EiPow.HeaderText = "Ei^2";
			this.EiPow.MinimumWidth = 6;
			this.EiPow.Name = "EiPow";
			this.EiPow.ReadOnly = true;
			// 
			// Ldw
			// 
			this.Ldw.AutoSize = true;
			this.Ldw.Location = new System.Drawing.Point(28, 431);
			this.Ldw.Name = "Ldw";
			this.Ldw.Size = new System.Drawing.Size(12, 20);
			this.Ldw.TabIndex = 1;
			this.Ldw.Text = ".";
			// 
			// Ln
			// 
			this.Ln.AutoSize = true;
			this.Ln.Location = new System.Drawing.Point(28, 451);
			this.Ln.Name = "Ln";
			this.Ln.Size = new System.Drawing.Size(12, 20);
			this.Ln.TabIndex = 1;
			this.Ln.Text = ".";
			// 
			// Lk
			// 
			this.Lk.AutoSize = true;
			this.Lk.Location = new System.Drawing.Point(28, 471);
			this.Lk.Name = "Lk";
			this.Lk.Size = new System.Drawing.Size(12, 20);
			this.Lk.TabIndex = 1;
			this.Lk.Text = ".";
			// 
			// DWdata
			// 
			this.DWdata.AllowUserToAddRows = false;
			this.DWdata.AllowUserToDeleteRows = false;
			this.DWdata.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.DWdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DWdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DWdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.DWdata.Location = new System.Drawing.Point(28, 538);
			this.DWdata.Name = "DWdata";
			this.DWdata.ReadOnly = true;
			this.DWdata.RowHeadersWidth = 51;
			this.DWdata.RowTemplate.Height = 29;
			this.DWdata.Size = new System.Drawing.Size(554, 160);
			this.DWdata.TabIndex = 2;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = " ";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = " ";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText = " ";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// RSSs
			// 
			this.RSSs.AutoSize = true;
			this.RSSs.Location = new System.Drawing.Point(279, 431);
			this.RSSs.Name = "RSSs";
			this.RSSs.Size = new System.Drawing.Size(12, 20);
			this.RSSs.TabIndex = 5;
			this.RSSs.Text = ".";
			// 
			// Final
			// 
			this.Final.AutoSize = true;
			this.Final.Location = new System.Drawing.Point(28, 515);
			this.Final.Name = "Final";
			this.Final.Size = new System.Drawing.Size(12, 20);
			this.Final.TabIndex = 6;
			this.Final.Text = ".";
			// 
			// DW_IPC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(602, 716);
			this.Controls.Add(this.Final);
			this.Controls.Add(this.RSSs);
			this.Controls.Add(this.DWdata);
			this.Controls.Add(this.Lk);
			this.Controls.Add(this.Ln);
			this.Controls.Add(this.Ldw);
			this.Controls.Add(this.DWIPCData);
			this.Name = "DW_IPC";
			this.Text = "DW_IPC";
			((System.ComponentModel.ISupportInitialize)(this.DWIPCData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DWdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DWIPCData;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_x;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_y;
		private System.Windows.Forms.DataGridViewTextBoxColumn DwEi;
		private System.Windows.Forms.DataGridViewTextBoxColumn deltaEiPow;
		private System.Windows.Forms.DataGridViewTextBoxColumn EiPow;
		private System.Windows.Forms.Label Ldw;
		private System.Windows.Forms.Label Ln;
		private System.Windows.Forms.Label Lk;
		private System.Windows.Forms.DataGridView DWdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.Label RSSs;
		private System.Windows.Forms.Label Final;
	}
}
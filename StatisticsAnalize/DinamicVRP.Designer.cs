
namespace StatisticsAnalize
{
	partial class DinamicVRP
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
			this.DinamicVRPData = new System.Windows.Forms.DataGridView();
			this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rsqw = new System.Windows.Forms.Label();
			this.y = new System.Windows.Forms.Label();
			this.y1 = new System.Windows.Forms.Label();
			this.sume = new System.Windows.Forms.Label();
			this.sre = new System.Windows.Forms.Label();
			this.DWVRPDinamicData = new System.Windows.Forms.DataGridView();
			this.DW_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DW_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DW_ei = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deltaEPow = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EPow = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RSS = new System.Windows.Forms.Label();
			this.Ln = new System.Windows.Forms.Label();
			this.LDW = new System.Windows.Forms.Label();
			this.ab = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DinamicVRPData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DWVRPDinamicData)).BeginInit();
			this.SuspendLayout();
			// 
			// DinamicVRPData
			// 
			this.DinamicVRPData.AllowUserToAddRows = false;
			this.DinamicVRPData.AllowUserToDeleteRows = false;
			this.DinamicVRPData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.DinamicVRPData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DinamicVRPData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DinamicVRPData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.year,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
			this.DinamicVRPData.Location = new System.Drawing.Point(0, 0);
			this.DinamicVRPData.Name = "DinamicVRPData";
			this.DinamicVRPData.ReadOnly = true;
			this.DinamicVRPData.RowHeadersWidth = 51;
			this.DinamicVRPData.RowTemplate.Height = 29;
			this.DinamicVRPData.Size = new System.Drawing.Size(582, 411);
			this.DinamicVRPData.TabIndex = 0;
			// 
			// num
			// 
			this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.num.HeaderText = "№";
			this.num.MinimumWidth = 6;
			this.num.Name = "num";
			this.num.ReadOnly = true;
			this.num.Width = 55;
			// 
			// year
			// 
			this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.year.HeaderText = "Год";
			this.year.MinimumWidth = 6;
			this.year.Name = "year";
			this.year.ReadOnly = true;
			this.year.Width = 62;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column1.HeaderText = "ВРП";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 66;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column2.HeaderText = "x(Yt-1)";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 82;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column4.HeaderText = "Y";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 46;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column3.HeaderText = "Отклонение (Е)";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 144;
			// 
			// rsqw
			// 
			this.rsqw.AutoSize = true;
			this.rsqw.Location = new System.Drawing.Point(588, 9);
			this.rsqw.Name = "rsqw";
			this.rsqw.Size = new System.Drawing.Size(50, 20);
			this.rsqw.TabIndex = 1;
			this.rsqw.Text = "label1";
			// 
			// y
			// 
			this.y.AutoSize = true;
			this.y.Location = new System.Drawing.Point(587, 55);
			this.y.Name = "y";
			this.y.Size = new System.Drawing.Size(50, 20);
			this.y.TabIndex = 1;
			this.y.Text = "label1";
			// 
			// y1
			// 
			this.y1.AutoSize = true;
			this.y1.Location = new System.Drawing.Point(588, 105);
			this.y1.Name = "y1";
			this.y1.Size = new System.Drawing.Size(50, 20);
			this.y1.TabIndex = 1;
			this.y1.Text = "label1";
			// 
			// sume
			// 
			this.sume.AutoSize = true;
			this.sume.Location = new System.Drawing.Point(587, 151);
			this.sume.Name = "sume";
			this.sume.Size = new System.Drawing.Size(50, 20);
			this.sume.TabIndex = 2;
			this.sume.Text = "label1";
			// 
			// sre
			// 
			this.sre.AutoSize = true;
			this.sre.Location = new System.Drawing.Point(587, 193);
			this.sre.Name = "sre";
			this.sre.Size = new System.Drawing.Size(50, 20);
			this.sre.TabIndex = 2;
			this.sre.Text = "label1";
			// 
			// DWVRPDinamicData
			// 
			this.DWVRPDinamicData.AllowUserToAddRows = false;
			this.DWVRPDinamicData.AllowUserToDeleteRows = false;
			this.DWVRPDinamicData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.DWVRPDinamicData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DWVRPDinamicData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DWVRPDinamicData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DW_X,
            this.DW_Y,
            this.DW_ei,
            this.deltaEPow,
            this.EPow});
			this.DWVRPDinamicData.Location = new System.Drawing.Point(0, 417);
			this.DWVRPDinamicData.Name = "DWVRPDinamicData";
			this.DWVRPDinamicData.ReadOnly = true;
			this.DWVRPDinamicData.RowHeadersWidth = 51;
			this.DWVRPDinamicData.RowTemplate.Height = 29;
			this.DWVRPDinamicData.Size = new System.Drawing.Size(582, 418);
			this.DWVRPDinamicData.TabIndex = 4;
			// 
			// DW_X
			// 
			this.DW_X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DW_X.HeaderText = "Y";
			this.DW_X.MinimumWidth = 6;
			this.DW_X.Name = "DW_X";
			this.DW_X.ReadOnly = true;
			// 
			// DW_Y
			// 
			this.DW_Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DW_Y.HeaderText = "Y(x)";
			this.DW_Y.MinimumWidth = 6;
			this.DW_Y.Name = "DW_Y";
			this.DW_Y.ReadOnly = true;
			// 
			// DW_ei
			// 
			this.DW_ei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DW_ei.HeaderText = "Ei";
			this.DW_ei.MinimumWidth = 6;
			this.DW_ei.Name = "DW_ei";
			this.DW_ei.ReadOnly = true;
			// 
			// deltaEPow
			// 
			this.deltaEPow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.deltaEPow.HeaderText = "(Ei-Ei-1)^2";
			this.deltaEPow.MinimumWidth = 6;
			this.deltaEPow.Name = "deltaEPow";
			this.deltaEPow.ReadOnly = true;
			// 
			// EPow
			// 
			this.EPow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EPow.HeaderText = "Ei^2";
			this.EPow.MinimumWidth = 6;
			this.EPow.Name = "EPow";
			this.EPow.ReadOnly = true;
			// 
			// RSS
			// 
			this.RSS.AutoSize = true;
			this.RSS.Location = new System.Drawing.Point(588, 417);
			this.RSS.Name = "RSS";
			this.RSS.Size = new System.Drawing.Size(50, 20);
			this.RSS.TabIndex = 5;
			this.RSS.Text = "label1";
			// 
			// Ln
			// 
			this.Ln.AutoSize = true;
			this.Ln.Location = new System.Drawing.Point(587, 534);
			this.Ln.Name = "Ln";
			this.Ln.Size = new System.Drawing.Size(50, 20);
			this.Ln.TabIndex = 5;
			this.Ln.Text = "label1";
			// 
			// LDW
			// 
			this.LDW.AutoSize = true;
			this.LDW.Location = new System.Drawing.Point(587, 594);
			this.LDW.Name = "LDW";
			this.LDW.Size = new System.Drawing.Size(50, 20);
			this.LDW.TabIndex = 5;
			this.LDW.Text = "label1";
			// 
			// ab
			// 
			this.ab.AutoSize = true;
			this.ab.Location = new System.Drawing.Point(587, 658);
			this.ab.Name = "ab";
			this.ab.Size = new System.Drawing.Size(50, 20);
			this.ab.TabIndex = 5;
			this.ab.Text = "label1";
			// 
			// DinamicVRP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 868);
			this.Controls.Add(this.ab);
			this.Controls.Add(this.LDW);
			this.Controls.Add(this.Ln);
			this.Controls.Add(this.RSS);
			this.Controls.Add(this.DWVRPDinamicData);
			this.Controls.Add(this.sre);
			this.Controls.Add(this.sume);
			this.Controls.Add(this.y1);
			this.Controls.Add(this.y);
			this.Controls.Add(this.rsqw);
			this.Controls.Add(this.DinamicVRPData);
			this.Name = "DinamicVRP";
			this.Text = "DinamicVRP";
			((System.ComponentModel.ISupportInitialize)(this.DinamicVRPData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DWVRPDinamicData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DinamicVRPData;
		private System.Windows.Forms.Label rsqw;
		private System.Windows.Forms.Label y;
		private System.Windows.Forms.Label y1;
		private System.Windows.Forms.DataGridViewTextBoxColumn num;
		private System.Windows.Forms.DataGridViewTextBoxColumn year;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Label sume;
		private System.Windows.Forms.Label sre;
		private System.Windows.Forms.DataGridView DWVRPDinamicData;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_X;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_Y;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_ei;
		private System.Windows.Forms.DataGridViewTextBoxColumn deltaEPow;
		private System.Windows.Forms.DataGridViewTextBoxColumn EPow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ab;
		private System.Windows.Forms.Label RSS;
		private System.Windows.Forms.Label Ln;
		private System.Windows.Forms.Label LDW;
	}
}

namespace StatisticsAnalize
{
	partial class AutoRegress
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
			this.AutoData = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DWAutoData = new System.Windows.Forms.DataGridView();
			this.DW_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DW_ei = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deltaEPow = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EPow = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Perem = new System.Windows.Forms.Label();
			this.DWtxt = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.AutoData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DWAutoData)).BeginInit();
			this.SuspendLayout();
			// 
			// AutoData
			// 
			this.AutoData.AllowUserToAddRows = false;
			this.AutoData.AllowUserToDeleteRows = false;
			this.AutoData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.AutoData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AutoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AutoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.AutoData.Location = new System.Drawing.Point(12, 12);
			this.AutoData.Name = "AutoData";
			this.AutoData.ReadOnly = true;
			this.AutoData.RowHeadersWidth = 51;
			this.AutoData.RowTemplate.Height = 29;
			this.AutoData.Size = new System.Drawing.Size(908, 418);
			this.AutoData.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column1.HeaderText = "№";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 55;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column2.HeaderText = "Год";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 62;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column3.HeaderText = "ИПЦ(Xt)";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 95;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column4.HeaderText = "ВРП(Yt)";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 89;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column5.HeaderText = "Yt-1";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 65;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column6.HeaderText = "x^2";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 63;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column7.HeaderText = "Yt^";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 61;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column8.HeaderText = "E";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 46;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column9.HeaderText = "(Y^-Ycp)^2";
			this.Column9.MinimumWidth = 6;
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 113;
			// 
			// Column10
			// 
			this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column10.HeaderText = "(Y-Ycp)^2";
			this.Column10.MinimumWidth = 6;
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 103;
			// 
			// DWAutoData
			// 
			this.DWAutoData.AllowUserToAddRows = false;
			this.DWAutoData.AllowUserToDeleteRows = false;
			this.DWAutoData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.DWAutoData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DWAutoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DWAutoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DW_Y,
            this.DW_ei,
            this.deltaEPow,
            this.EPow});
			this.DWAutoData.Location = new System.Drawing.Point(12, 473);
			this.DWAutoData.Name = "DWAutoData";
			this.DWAutoData.ReadOnly = true;
			this.DWAutoData.RowHeadersWidth = 51;
			this.DWAutoData.RowTemplate.Height = 29;
			this.DWAutoData.Size = new System.Drawing.Size(582, 418);
			this.DWAutoData.TabIndex = 5;
			// 
			// DW_Y
			// 
			this.DW_Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DW_Y.HeaderText = "X";
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
			// Perem
			// 
			this.Perem.AutoSize = true;
			this.Perem.Location = new System.Drawing.Point(601, 473);
			this.Perem.Name = "Perem";
			this.Perem.Size = new System.Drawing.Size(50, 20);
			this.Perem.TabIndex = 6;
			this.Perem.Text = "label1";
			// 
			// DWtxt
			// 
			this.DWtxt.AutoSize = true;
			this.DWtxt.Location = new System.Drawing.Point(601, 778);
			this.DWtxt.Name = "DWtxt";
			this.DWtxt.Size = new System.Drawing.Size(50, 20);
			this.DWtxt.TabIndex = 7;
			this.DWtxt.Text = "label1";
			// 
			// AutoRegress
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 903);
			this.Controls.Add(this.DWtxt);
			this.Controls.Add(this.Perem);
			this.Controls.Add(this.DWAutoData);
			this.Controls.Add(this.AutoData);
			this.Name = "AutoRegress";
			this.Text = "AutoRegress";
			((System.ComponentModel.ISupportInitialize)(this.AutoData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DWAutoData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView AutoData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridView DWAutoData;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_Y;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_ei;
		private System.Windows.Forms.DataGridViewTextBoxColumn deltaEPow;
		private System.Windows.Forms.DataGridViewTextBoxColumn EPow;
		private System.Windows.Forms.Label Perem;
		private System.Windows.Forms.Label DWtxt;
	}
}
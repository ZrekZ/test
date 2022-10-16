
namespace StatisticsAnalize
{
	partial class DW_VRP
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
			this.DWVRPData = new System.Windows.Forms.DataGridView();
			this.DW_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DW_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DW_ei = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deltaEPow = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EPow = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LDW = new System.Windows.Forms.Label();
			this.Ln = new System.Windows.Forms.Label();
			this.Lk = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DWVRPData)).BeginInit();
			this.SuspendLayout();
			// 
			// DWVRPData
			// 
			this.DWVRPData.AllowUserToAddRows = false;
			this.DWVRPData.AllowUserToDeleteRows = false;
			this.DWVRPData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.DWVRPData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DWVRPData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DWVRPData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DW_X,
            this.DW_Y,
            this.DW_ei,
            this.deltaEPow,
            this.EPow});
			this.DWVRPData.Location = new System.Drawing.Point(0, 0);
			this.DWVRPData.Name = "DWVRPData";
			this.DWVRPData.ReadOnly = true;
			this.DWVRPData.RowHeadersWidth = 51;
			this.DWVRPData.RowTemplate.Height = 29;
			this.DWVRPData.Size = new System.Drawing.Size(582, 451);
			this.DWVRPData.TabIndex = 0;
			// 
			// DW_X
			// 
			this.DW_X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DW_X.HeaderText = "X";
			this.DW_X.MinimumWidth = 6;
			this.DW_X.Name = "DW_X";
			this.DW_X.ReadOnly = true;
			// 
			// DW_Y
			// 
			this.DW_Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DW_Y.HeaderText = "Y_step";
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
			// LDW
			// 
			this.LDW.AutoSize = true;
			this.LDW.Location = new System.Drawing.Point(21, 463);
			this.LDW.Name = "LDW";
			this.LDW.Size = new System.Drawing.Size(12, 20);
			this.LDW.TabIndex = 1;
			this.LDW.Text = ".";
			// 
			// Ln
			// 
			this.Ln.AutoSize = true;
			this.Ln.Location = new System.Drawing.Point(21, 493);
			this.Ln.Name = "Ln";
			this.Ln.Size = new System.Drawing.Size(12, 20);
			this.Ln.TabIndex = 2;
			this.Ln.Text = ".";
			// 
			// Lk
			// 
			this.Lk.AutoSize = true;
			this.Lk.Location = new System.Drawing.Point(21, 524);
			this.Lk.Name = "Lk";
			this.Lk.Size = new System.Drawing.Size(12, 20);
			this.Lk.TabIndex = 2;
			this.Lk.Text = ".";
			// 
			// DW_VRP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(582, 558);
			this.Controls.Add(this.Lk);
			this.Controls.Add(this.Ln);
			this.Controls.Add(this.LDW);
			this.Controls.Add(this.DWVRPData);
			this.Name = "DW_VRP";
			this.Text = "DW_VRP";
			((System.ComponentModel.ISupportInitialize)(this.DWVRPData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DWVRPData;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_X;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_Y;
		private System.Windows.Forms.DataGridViewTextBoxColumn DW_ei;
		private System.Windows.Forms.DataGridViewTextBoxColumn deltaEPow;
		private System.Windows.Forms.DataGridViewTextBoxColumn EPow;
		private System.Windows.Forms.Label LDW;
		private System.Windows.Forms.Label Ln;
		private System.Windows.Forms.Label Lk;
	}
}
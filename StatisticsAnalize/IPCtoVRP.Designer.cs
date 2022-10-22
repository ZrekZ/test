
namespace StatisticsAnalize
{
	partial class IPCtoVRP
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
			this.VRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IPCtoVRPData = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A = new System.Windows.Forms.Label();
			this.B = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.IPCtoVRPData)).BeginInit();
			this.SuspendLayout();
			// 
			// VRP
			// 
			this.VRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.VRP.HeaderText = "VRP(x)";
			this.VRP.MinimumWidth = 6;
			this.VRP.Name = "VRP";
			// 
			// IPC
			// 
			this.IPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IPC.HeaderText = "IPC(y)";
			this.IPC.MinimumWidth = 6;
			this.IPC.Name = "IPC";
			// 
			// IPCtoVRPData
			// 
			this.IPCtoVRPData.AllowUserToAddRows = false;
			this.IPCtoVRPData.AllowUserToDeleteRows = false;
			this.IPCtoVRPData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.IPCtoVRPData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.IPCtoVRPData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.IPCtoVRPData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
			this.IPCtoVRPData.Location = new System.Drawing.Point(0, 0);
			this.IPCtoVRPData.Name = "IPCtoVRPData";
			this.IPCtoVRPData.ReadOnly = true;
			this.IPCtoVRPData.RowHeadersWidth = 51;
			this.IPCtoVRPData.RowTemplate.Height = 29;
			this.IPCtoVRPData.Size = new System.Drawing.Size(1082, 421);
			this.IPCtoVRPData.TabIndex = 1;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "ИПЦ(х)";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = "ВРП(у)";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText = "x^2";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column8.HeaderText = "xy";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "";
			this.Column9.MinimumWidth = 6;
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 125;
			// 
			// Column10
			// 
			this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column10.HeaderText = "X";
			this.Column10.MinimumWidth = 6;
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			// 
			// Column11
			// 
			this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column11.HeaderText = "Значение";
			this.Column11.MinimumWidth = 6;
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			// 
			// A
			// 
			this.A.AutoSize = true;
			this.A.Location = new System.Drawing.Point(12, 424);
			this.A.Name = "A";
			this.A.Size = new System.Drawing.Size(12, 20);
			this.A.TabIndex = 2;
			this.A.Text = ".";
			// 
			// B
			// 
			this.B.AutoSize = true;
			this.B.Location = new System.Drawing.Point(12, 457);
			this.B.Name = "B";
			this.B.Size = new System.Drawing.Size(12, 20);
			this.B.TabIndex = 2;
			this.B.Text = ".";
			// 
			// IPCtoVRP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1082, 503);
			this.Controls.Add(this.B);
			this.Controls.Add(this.A);
			this.Controls.Add(this.IPCtoVRPData);
			this.Name = "IPCtoVRP";
			this.Text = "IPCtoVRP";
			((System.ComponentModel.ISupportInitialize)(this.IPCtoVRPData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridViewTextBoxColumn VRP;
		private System.Windows.Forms.DataGridViewTextBoxColumn IPC;
		private System.Windows.Forms.DataGridView IPCtoVRPData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.Label A;
		private System.Windows.Forms.Label B;
	}
}

namespace StatisticsAnalize
{
	partial class VRPtoIPC
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
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VRPtoIPCData = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.VRPtoIPCData)).BeginInit();
			this.SuspendLayout();
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "ВРП(х)";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "ИПЦ(у)";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "х^2";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "ху";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			// 
			// VRPtoIPCData
			// 
			this.VRPtoIPCData.AllowUserToAddRows = false;
			this.VRPtoIPCData.AllowUserToDeleteRows = false;
			this.VRPtoIPCData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.VRPtoIPCData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.VRPtoIPCData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.VRPtoIPCData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
			this.VRPtoIPCData.Location = new System.Drawing.Point(0, 0);
			this.VRPtoIPCData.Name = "VRPtoIPCData";
			this.VRPtoIPCData.ReadOnly = true;
			this.VRPtoIPCData.RowHeadersWidth = 51;
			this.VRPtoIPCData.RowTemplate.Height = 29;
			this.VRPtoIPCData.Size = new System.Drawing.Size(1090, 397);
			this.VRPtoIPCData.TabIndex = 0;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "ВРП(х)";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = "ИПЦ(у)";
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
			// VRPtoIPC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1082, 503);
			this.Controls.Add(this.VRPtoIPCData);
			this.Name = "VRPtoIPC";
			this.Text = "VRPtoIPC";
			((System.ComponentModel.ISupportInitialize)(this.VRPtoIPCData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridView VRPtoIPCData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
	}
}
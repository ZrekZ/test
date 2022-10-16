
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
			((System.ComponentModel.ISupportInitialize)(this.DWIPCData)).BeginInit();
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
			this.Ldw.Location = new System.Drawing.Point(28, 435);
			this.Ldw.Name = "Ldw";
			this.Ldw.Size = new System.Drawing.Size(12, 20);
			this.Ldw.TabIndex = 1;
			this.Ldw.Text = ".";
			// 
			// Ln
			// 
			this.Ln.AutoSize = true;
			this.Ln.Location = new System.Drawing.Point(28, 471);
			this.Ln.Name = "Ln";
			this.Ln.Size = new System.Drawing.Size(12, 20);
			this.Ln.TabIndex = 1;
			this.Ln.Text = ".";
			// 
			// Lk
			// 
			this.Lk.AutoSize = true;
			this.Lk.Location = new System.Drawing.Point(28, 507);
			this.Lk.Name = "Lk";
			this.Lk.Size = new System.Drawing.Size(12, 20);
			this.Lk.TabIndex = 1;
			this.Lk.Text = ".";
			// 
			// DW_IPC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 558);
			this.Controls.Add(this.Lk);
			this.Controls.Add(this.Ln);
			this.Controls.Add(this.Ldw);
			this.Controls.Add(this.DWIPCData);
			this.Name = "DW_IPC";
			this.Text = "DW_IPC";
			((System.ComponentModel.ISupportInitialize)(this.DWIPCData)).EndInit();
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
	}
}
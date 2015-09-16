namespace Extactco
{
	partial class ErrorForm
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
			this.Btn_OK = new System.Windows.Forms.Button();
			this.TxtBox_ErrorMsg = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Btn_OK
			// 
			this.Btn_OK.Location = new System.Drawing.Point(318, 135);
			this.Btn_OK.Name = "Btn_OK";
			this.Btn_OK.Size = new System.Drawing.Size(75, 23);
			this.Btn_OK.TabIndex = 0;
			this.Btn_OK.Text = "OK";
			this.Btn_OK.UseVisualStyleBackColor = true;
			this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
			// 
			// TxtBox_ErrorMsg
			// 
			this.TxtBox_ErrorMsg.Dock = System.Windows.Forms.DockStyle.Top;
			this.TxtBox_ErrorMsg.Location = new System.Drawing.Point(0, 0);
			this.TxtBox_ErrorMsg.Multiline = true;
			this.TxtBox_ErrorMsg.Name = "TxtBox_ErrorMsg";
			this.TxtBox_ErrorMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxtBox_ErrorMsg.Size = new System.Drawing.Size(400, 130);
			this.TxtBox_ErrorMsg.TabIndex = 1;
			// 
			// ErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 163);
			this.Controls.Add(this.TxtBox_ErrorMsg);
			this.Controls.Add(this.Btn_OK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(416, 197);
			this.Name = "ErrorForm";
			this.ShowIcon = false;
			this.Text = "Wystąpił błąd!";
			this.Load += new System.EventHandler(this.ErrorForm_Load);
			this.SizeChanged += new System.EventHandler(this.ErrorForm_SizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_OK;
		private System.Windows.Forms.TextBox TxtBox_ErrorMsg;
	}
}
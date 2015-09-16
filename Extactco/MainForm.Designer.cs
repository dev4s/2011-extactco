namespace Extactco
{
    partial class MainForm
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
			this.Btn_Export = new System.Windows.Forms.Button();
			this.Btn_Settings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Btn_Export
			// 
			this.Btn_Export.Location = new System.Drawing.Point(12, 12);
			this.Btn_Export.Name = "Btn_Export";
			this.Btn_Export.Size = new System.Drawing.Size(75, 23);
			this.Btn_Export.TabIndex = 1;
			this.Btn_Export.Text = "Export...";
			this.Btn_Export.UseVisualStyleBackColor = true;
			this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
			// 
			// Btn_Settings
			// 
			this.Btn_Settings.Location = new System.Drawing.Point(93, 12);
			this.Btn_Settings.Name = "Btn_Settings";
			this.Btn_Settings.Size = new System.Drawing.Size(75, 23);
			this.Btn_Settings.TabIndex = 2;
			this.Btn_Settings.Text = "Ustawienia";
			this.Btn_Settings.UseVisualStyleBackColor = true;
			this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(182, 45);
			this.Controls.Add(this.Btn_Settings);
			this.Controls.Add(this.Btn_Export);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Extactco";
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button Btn_Export;
		private System.Windows.Forms.Button Btn_Settings;

    }
}


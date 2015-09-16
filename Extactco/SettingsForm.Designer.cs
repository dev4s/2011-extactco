namespace Extactco
{
	partial class SettingsForm
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
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtBox_Server = new System.Windows.Forms.TextBox();
			this.TxtBox_Port = new System.Windows.Forms.TextBox();
			this.TxtBox_Login = new System.Windows.Forms.TextBox();
			this.TxtBox_Password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtBox_FilePath = new System.Windows.Forms.TextBox();
			this.Btn_Choose = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtBox_DatabaseName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Btn_TestConnection = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.TxtBox_Select1 = new System.Windows.Forms.TextBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.TxtBox_Select2 = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Save
			// 
			this.Btn_Save.Location = new System.Drawing.Point(426, 258);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(75, 23);
			this.Btn_Save.TabIndex = 1;
			this.Btn_Save.Text = "Zapisz";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Location = new System.Drawing.Point(507, 258);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.Btn_Cancel.TabIndex = 2;
			this.Btn_Cancel.Text = "Anuluj";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Controls.Add(this.tabPage5);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(584, 254);
			this.tabControl2.TabIndex = 3;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tableLayoutPanel1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(576, 228);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Ogólne";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.36025F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.63975F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.TxtBox_Server, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.TxtBox_Port, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.TxtBox_Login, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.TxtBox_Password, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.TxtBox_FilePath, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.Btn_Choose, 2, 8);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.TxtBox_DatabaseName, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Btn_TestConnection, 1, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 223);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(3, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Baza danych:";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Hasło";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Login";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Port";
			// 
			// TxtBox_Server
			// 
			this.TxtBox_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBox_Server.Location = new System.Drawing.Point(106, 27);
			this.TxtBox_Server.Name = "TxtBox_Server";
			this.TxtBox_Server.Size = new System.Drawing.Size(351, 20);
			this.TxtBox_Server.TabIndex = 1;
			// 
			// TxtBox_Port
			// 
			this.TxtBox_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBox_Port.Location = new System.Drawing.Point(106, 51);
			this.TxtBox_Port.Name = "TxtBox_Port";
			this.TxtBox_Port.Size = new System.Drawing.Size(351, 20);
			this.TxtBox_Port.TabIndex = 2;
			// 
			// TxtBox_Login
			// 
			this.TxtBox_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBox_Login.Location = new System.Drawing.Point(106, 75);
			this.TxtBox_Login.Name = "TxtBox_Login";
			this.TxtBox_Login.Size = new System.Drawing.Size(351, 20);
			this.TxtBox_Login.TabIndex = 3;
			// 
			// TxtBox_Password
			// 
			this.TxtBox_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBox_Password.Location = new System.Drawing.Point(106, 99);
			this.TxtBox_Password.Name = "TxtBox_Password";
			this.TxtBox_Password.Size = new System.Drawing.Size(351, 20);
			this.TxtBox_Password.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Ścieżka wynikowa";
			// 
			// TxtBox_FilePath
			// 
			this.TxtBox_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBox_FilePath.Location = new System.Drawing.Point(106, 194);
			this.TxtBox_FilePath.Name = "TxtBox_FilePath";
			this.TxtBox_FilePath.Size = new System.Drawing.Size(351, 20);
			this.TxtBox_FilePath.TabIndex = 10;
			// 
			// Btn_Choose
			// 
			this.Btn_Choose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Choose.Location = new System.Drawing.Point(463, 193);
			this.Btn_Choose.Name = "Btn_Choose";
			this.Btn_Choose.Size = new System.Drawing.Size(104, 23);
			this.Btn_Choose.TabIndex = 11;
			this.Btn_Choose.Text = "Wybierz...";
			this.Btn_Choose.UseVisualStyleBackColor = true;
			this.Btn_Choose.Click += new System.EventHandler(this.Btn_Choose_Click);
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Baza danych";
			// 
			// TxtBox_DatabaseName
			// 
			this.TxtBox_DatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBox_DatabaseName.Location = new System.Drawing.Point(106, 123);
			this.TxtBox_DatabaseName.Name = "TxtBox_DatabaseName";
			this.TxtBox_DatabaseName.Size = new System.Drawing.Size(351, 20);
			this.TxtBox_DatabaseName.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Serwer";
			// 
			// Btn_TestConnection
			// 
			this.Btn_TestConnection.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Btn_TestConnection.Location = new System.Drawing.Point(242, 147);
			this.Btn_TestConnection.Name = "Btn_TestConnection";
			this.Btn_TestConnection.Size = new System.Drawing.Size(215, 23);
			this.Btn_TestConnection.TabIndex = 14;
			this.Btn_TestConnection.Text = "Testuj podłączenie do bazy danych";
			this.Btn_TestConnection.UseVisualStyleBackColor = true;
			this.Btn_TestConnection.Click += new System.EventHandler(this.Btn_TestConnection_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.TxtBox_Select1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(576, 228);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Select 1";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// TxtBox_Select1
			// 
			this.TxtBox_Select1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBox_Select1.Location = new System.Drawing.Point(3, 3);
			this.TxtBox_Select1.Multiline = true;
			this.TxtBox_Select1.Name = "TxtBox_Select1";
			this.TxtBox_Select1.Size = new System.Drawing.Size(570, 222);
			this.TxtBox_Select1.TabIndex = 0;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.TxtBox_Select2);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(576, 228);
			this.tabPage5.TabIndex = 2;
			this.tabPage5.Text = "Select 2";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// TxtBox_Select2
			// 
			this.TxtBox_Select2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBox_Select2.Location = new System.Drawing.Point(3, 3);
			this.TxtBox_Select2.Multiline = true;
			this.TxtBox_Select2.Name = "TxtBox_Select2";
			this.TxtBox_Select2.Size = new System.Drawing.Size(570, 222);
			this.TxtBox_Select2.TabIndex = 0;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 286);
			this.Controls.Add(this.tabControl2);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_Save);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "Ustawienia";
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtBox_Server;
		private System.Windows.Forms.TextBox TxtBox_Port;
		private System.Windows.Forms.TextBox TxtBox_Login;
		private System.Windows.Forms.TextBox TxtBox_Password;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtBox_FilePath;
		private System.Windows.Forms.Button Btn_Choose;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtBox_DatabaseName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Btn_TestConnection;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox TxtBox_Select1;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TextBox TxtBox_Select2;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}
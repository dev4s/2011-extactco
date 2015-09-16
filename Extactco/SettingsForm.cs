using System;
using System.Windows.Forms;
using Extactco.Properties;

namespace Extactco
{
	public partial class SettingsForm : Form
	{
		private readonly Settings _setDef = Settings.Default;

		private void SaveSettings()
		{
			var tmpPort = _setDef.Port;

			try
			{
				_setDef.Port = Convert.ToInt32(TxtBox_Port.Text);
			}
			catch (Exception exception)
			{
				_setDef.Port = tmpPort;
				ErrorMsgBox.Show(exception);
				return;
			}

			if (String.IsNullOrEmpty(TxtBox_Select1.Text))
			{
				ErrorMsgBox.Show("Puste zapytanie Select1.\r\n\r\nPrzerwano zapisywanie ustawień. Popraw ustawienia!");
				return;
			}

			_setDef.DatabaseName = TxtBox_DatabaseName.Text;
			_setDef.FilePath = TxtBox_FilePath.Text;
			_setDef.Login = TxtBox_Login.Text;
			_setDef.Password = EncryptorDecryptor.EncryptDecrypt(TxtBox_Password.Text);
			_setDef.Select1 = TxtBox_Select1.Text;
			_setDef.Select2 = TxtBox_Select2.Text;
			_setDef.ServerAddress = TxtBox_Server.Text;

			_setDef.ConnectionString = EncryptorDecryptor.EncryptDecrypt(String.Format("Data Source={0},{1};Network Library=DBMSSOCN;Initial Catalog={2};User ID={3};Password={4};", _setDef.ServerAddress, _setDef.Port, _setDef.DatabaseName, _setDef.Login, EncryptorDecryptor.EncryptDecrypt(_setDef.Password)));

			_setDef.Save();
		}

		public SettingsForm()
		{
			InitializeComponent();

			TxtBox_DatabaseName.Text = _setDef.DatabaseName;
			TxtBox_FilePath.Text = _setDef.FilePath;
			TxtBox_Login.Text = _setDef.Login;
			TxtBox_Password.Text = EncryptorDecryptor.EncryptDecrypt(_setDef.Password);
			TxtBox_Port.Text = _setDef.Port.ToString();
			TxtBox_Select1.Text = _setDef.Select1;
			TxtBox_Select2.Text = _setDef.Select2;
			TxtBox_Server.Text = _setDef.ServerAddress;
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			SaveSettings();
			Close();
		}

		private void Btn_TestConnection_Click(object sender, EventArgs e)
		{
			var databaseName = _setDef.DatabaseName == TxtBox_DatabaseName.Text ? _setDef.DatabaseName : TxtBox_DatabaseName.Text;
			var serverName = _setDef.ServerAddress == TxtBox_Server.Text ? _setDef.ServerAddress : TxtBox_Server.Text;
			var login = _setDef.Login == TxtBox_Login.Text ? _setDef.Login : TxtBox_Login.Text;
			var password = _setDef.Password == TxtBox_Password.Text ? EncryptorDecryptor.EncryptDecrypt(_setDef.Password) : TxtBox_Password.Text;
			var port = _setDef.Port == Convert.ToInt32(TxtBox_Port.Text) ? _setDef.Port : Convert.ToInt32(TxtBox_Port.Text);

			var connectionString = String.Format("Data Source={0},{1};Network Library=DBMSSOCN;Initial Catalog={2};User ID={3};Password={4};", serverName, port, databaseName, login, password);
			var db = new Database();

			if (!db.TestConnection(connectionString)) return;

			MessageBox.Show("Połączenie z bazą danych zostało ustanowione!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

			SaveSettings();
		}

		private void Btn_Choose_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

			if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
			if (folderBrowserDialog.SelectedPath[folderBrowserDialog.SelectedPath.Length - 1] != '\\')
				TxtBox_FilePath.Text = _setDef.FilePath = folderBrowserDialog.SelectedPath + "\\";
			else
				TxtBox_FilePath.Text = _setDef.FilePath = folderBrowserDialog.SelectedPath;
			_setDef.Save();
		}
	}
}

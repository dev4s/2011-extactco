using System;
using System.Windows.Forms;
using Extactco.Properties;

namespace Extactco
{
	public partial class DateSelect : Form
	{
		private readonly Settings _setDef = Settings.Default;

		public DateSelect()
		{
			InitializeComponent();
		}

		private void Btn_Start_Click(object sender, EventArgs e)
		{
			var dateFrom = CalendarFrom.SelectionEnd;
			var dateTo = CalendarTo.SelectionEnd;
			var connectionString = EncryptorDecryptor.EncryptDecrypt(_setDef.ConnectionString);
			var db = new Database();

			if (String.IsNullOrEmpty(_setDef.Select1))
			{
				ErrorMsgBox.Show("Puste zapytanie Select1.\r\n\r\nPrzerwano działanie programu.");
				return;
			}
			if (dateFrom > dateTo)
			{
				ErrorMsgBox.Show("\"Data Do\" nie może być większa od \"Daty Od\".\r\n\r\nPrzerwano działanie programu.");
				return;
			}
			if (String.IsNullOrEmpty(connectionString))
			{
				ErrorMsgBox.Show("Złe ustawienia programu. Najprawdopodobniej nie wprowadzono ustawień.\r\n\r\nPrzerwano działanie programu.");
				return;
			}
			if (!db.TestConnection(connectionString))
			{
				ErrorMsgBox.Show("Nie można podłączyć się do bazy danych. Najprawdopodobniej zostały wprowadzone złe ustawienia.\r\n\r\nPrzerwano działanie programu.");
				return;
			}

			var progressBarForm = new ProgressBarForm(dateFrom, dateTo, db);
			progressBarForm.ShowDialog();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}

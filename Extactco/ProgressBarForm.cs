using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Extactco.Properties;

namespace Extactco
{
	public partial class ProgressBarForm : Form
	{
		private readonly Settings _setDef = Settings.Default;
		private readonly DateTime _dateFrom;
		private readonly DateTime _dateTo;
		private readonly Database _db;

		public ProgressBarForm(DateTime dateFrom, DateTime dateTo, Database db)
		{
			InitializeComponent();
			_dateFrom = dateFrom;
			_dateTo = dateTo;
			_db = db;
		}

		private void ProgressBarForm_Shown(object sender, EventArgs e)
		{
			var newThread = new Thread(Export);
			newThread.Start();
		}

		private void Export()
		{
			Thread.Sleep(100);

			var fileTimestamp = TimeStamp.Get();
			var temporaryString = new StringBuilder();
			var select2IsNotEmpty = true;

			if (String.IsNullOrEmpty(_setDef.Select2)) select2IsNotEmpty = false;

			_db.Connection.Open();
			_db.Connection2.Open();

			var selectOneCommand = new SqlCommand(_setDef.Select1) { Connection = _db.Connection };
			var dateFromParam = new SqlParameter("@DATEFROM", _dateFrom);
			var dateToParam = new SqlParameter("@DATETO", _dateTo);
			selectOneCommand.Parameters.Add(dateFromParam);
			selectOneCommand.Parameters.Add(dateToParam);

			var da = new SqlDataAdapter(selectOneCommand);
			var tempData = new DataTable();
			da.Fill(tempData);
			UpdateProgressBarMaximum(tempData.Rows.Count);

			var resultOfSelectOneCommand = selectOneCommand.ExecuteReader();

			while (resultOfSelectOneCommand.Read())
			{
				var parentId = Convert.ToInt32(resultOfSelectOneCommand["ID"]);

				var konKod = resultOfSelectOneCommand["KON.KOD"].ToString();
				string konNip;
				try
				{
					konNip = resultOfSelectOneCommand["KON.NIP"].ToString();
				}
				catch (Exception)
				{
					konNip = "";
				}
				var konNazwa = resultOfSelectOneCommand["KON.NAZWA"].ToString().Replace("\r\n", " ");
				var konRodzaj = resultOfSelectOneCommand["KON.RODZAJ"].ToString();
				var konStatus = resultOfSelectOneCommand["KON.STATUS"].ToString();
				var konUlica = resultOfSelectOneCommand["KON.ULICA"].ToString();
				var konKodpocztowy = resultOfSelectOneCommand["KON.KODPOCZTOWY"].ToString();
				var konMiejscowosc = resultOfSelectOneCommand["KON.MIEJSCOWOSC"].ToString();
				var konKraj = resultOfSelectOneCommand["KON.KRAJ"].ToString();

				temporaryString.AppendLine(String.Format("\"KON\";\"{0}\";\"{1}\";\"{2}\";{3};{4};\"{5}\";\"{6}\";\"{7}\";\"{8}\"", konKod, konNip, konNazwa, konRodzaj, konStatus, konUlica, konKodpocztowy, konMiejscowosc, konKraj));

				var fsDefinicja = resultOfSelectOneCommand["FS.DEFINICJA"].ToString();
				var fsDataTemp = Convert.ToDateTime(resultOfSelectOneCommand["FS.DATA"]);
				var fsData = String.Format("{0:yyyy-MM-dd}", fsDataTemp);
				var fsNumer = resultOfSelectOneCommand["FS.NUMER"].ToString();
				var fsKonKod = resultOfSelectOneCommand["FS.KON.KOD"].ToString();
				var fsNrkorygowanego = resultOfSelectOneCommand["FS.NRKORYGOWANEGO"].ToString();
				var fsBrutto = Convert.ToDouble(resultOfSelectOneCommand["FS.BRUTTO"]);
				var fsDatawplywuTemp = Convert.ToDateTime(resultOfSelectOneCommand["FS.DATAWPLYWU"]);
				var fsDatawplywu = String.Format("{0:yyyy-MM-dd}", fsDatawplywuTemp); ;

				temporaryString.AppendLine(String.Format("\"FS\";\"{0}\";{1};\"{2}\";\"{3}\";\"{4}\";{5};{6}", fsDefinicja, fsData, fsNumer, fsKonKod, fsNrkorygowanego, fsBrutto, fsDatawplywu));

				if (select2IsNotEmpty)
				{
					var selectTwoCommand = new SqlCommand(_setDef.Select2) {Connection = _db.Connection2};
					var parentIdParam = new SqlParameter("@PARENTID", parentId);
					selectTwoCommand.Parameters.Add(parentIdParam);
					var resultOfSelectTwoCommand = selectTwoCommand.ExecuteReader();

					if (resultOfSelectTwoCommand.HasRows)
					{
						while (resultOfSelectTwoCommand.Read())
						{
							var vatStawka = Convert.ToInt32(resultOfSelectTwoCommand["VAT.STAWKA"]);
							var vatStatus = Convert.ToInt32(resultOfSelectTwoCommand["VAT.STATUS"]);
							var vatNetto = Convert.ToDouble(resultOfSelectTwoCommand["VAT.NETTO"]);
							var vatVat = Convert.ToDouble(resultOfSelectTwoCommand["VAT.VAT"]);
							var vatBrutto = Convert.ToDouble(resultOfSelectTwoCommand["VAT.BRUTTO"]);
							temporaryString.AppendLine(String.Format("\"VAT\";{0};{1};{2};{3};{4}", vatStawka, vatStatus, vatNetto, vatVat, vatBrutto));
						}
					}

					resultOfSelectTwoCommand.Close();
				}

				var plaKonKod = resultOfSelectOneCommand["PLA.KON.KOD"].ToString();
				var plaSposobplatnosci = resultOfSelectOneCommand["PLA.SPOSOBPLATNOSCI"].ToString();
				var plaTerminTemp = Convert.ToDateTime(resultOfSelectOneCommand["PLA.TERMIN"]);
				var plaTermin = String.Format("{0:yyyy-MM-dd}", plaTerminTemp); ;
				var plaKwota = Convert.ToDouble(resultOfSelectOneCommand["PLA.KWOTA"]);
				var plaKwotawaluta = resultOfSelectOneCommand["PLA.KWOTAWALUTA"].ToString();
				var plaSymbolwaluta = resultOfSelectOneCommand["PLA.SYMBOLWALUTA"].ToString();

				temporaryString.AppendLine(String.Format("\"PLA\";\"{0}\";\"{1}\";{2};{3};{4};\"{5}\"", plaKonKod, plaSposobplatnosci, plaTermin, plaKwota, plaKwotawaluta, plaSymbolwaluta));

				var cchWartosc1 = resultOfSelectOneCommand["CCH.WARTOSC1"].ToString();
				var cchDefinicja1 = resultOfSelectOneCommand["CCH.DEFINICJA1"].ToString();
				string cchWartosc2, cchDefinicja2, cchWartosc3, cchDefinicja3, cchWartosc4, cchDefinicja4, cchWartosc5, cchDefinicja5, cchWartosc6, cchDefinicja6;
				try
				{
					cchWartosc2 = resultOfSelectOneCommand["CCH.WARTOSC2"].ToString();
					cchDefinicja2 = resultOfSelectOneCommand["CCH.DEFINICJA2"].ToString();
					cchWartosc3 = resultOfSelectOneCommand["CCH.WARTOSC3"].ToString();
					cchDefinicja3 = resultOfSelectOneCommand["CCH.DEFINICJA3"].ToString();
					cchWartosc4 = resultOfSelectOneCommand["CCH.WARTOSC4"].ToString();
					cchDefinicja4 = resultOfSelectOneCommand["CCH.DEFINICJA4"].ToString();
					cchWartosc5 = resultOfSelectOneCommand["CCH.WARTOSC5"].ToString();
					cchDefinicja5 = resultOfSelectOneCommand["CCH.DEFINICJA5"].ToString();
					cchWartosc6 = resultOfSelectOneCommand["CCH.WARTOSC6"].ToString();
					cchDefinicja6 = resultOfSelectOneCommand["CCH.DEFINICJA6"].ToString();
				}
				catch (Exception)
				{
					cchWartosc2 = cchDefinicja2 = cchWartosc3 = cchDefinicja3 = cchWartosc4 = cchDefinicja4 = cchWartosc5 = cchDefinicja5 = cchWartosc6 = cchDefinicja6 = "";
				}

				temporaryString.AppendLine(String.Format("\"CCH\";\"{0}\";\"{1}\"", cchDefinicja1, cchWartosc1));
				temporaryString.AppendLine(String.Format("\"CCH\";\"{0}\";\"{1}\"", cchDefinicja2, cchWartosc2));
				temporaryString.AppendLine(String.Format("\"CCH\";\"{0}\";\"{1}\"", cchDefinicja3, cchWartosc3));
				temporaryString.AppendLine(String.Format("\"CCH\";\"{0}\";\"{1}\"", cchDefinicja4, cchWartosc4));
				temporaryString.AppendLine(String.Format("\"CCH\";\"{0}\";\"{1}\"", cchDefinicja5, cchWartosc5));
				temporaryString.AppendLine(String.Format("\"CCH\";\"{0}\";\"{1}\"", cchDefinicja6, cchWartosc6));

				temporaryString.AppendLine("");

				File.Write(temporaryString.ToString(), String.Format("{0}{1}.txt", _setDef.FilePath, fileTimestamp));

				temporaryString.Clear();
				PerformStepProgressBar();
			}

			_db.Connection.Close();
			EnableOkBtn();
		}

		//delegaty
		private delegate void EnableOkBtnCallback();
		private void EnableOkBtn()
		{
			if (InvokeRequired)
			{
				EnableOkBtnCallback upbc = (EnableOkBtn);
				Invoke(upbc, new object[] { });
			}
			else
			{
				Btn_OK.Enabled = true;
			}
		}

		private delegate void PerformStepProgressBarCallback();
		private void PerformStepProgressBar()
		{
			if (InvokeRequired)
			{
				PerformStepProgressBarCallback upbc = (PerformStepProgressBar);
				Invoke(upbc, new object[] {});
			}
			else
			{
				progressBar.PerformStep();
			}
		}

		private delegate void UpdateProgressBarMaximumCallback(int value);
		private void UpdateProgressBarMaximum(int value)
		{
			if (InvokeRequired)
			{
				UpdateProgressBarMaximumCallback upbc = (UpdateProgressBarMaximum);
				Invoke(upbc, new object[] { value });
			}
			else
			{
				progressBar.Maximum = value;
			}
		}

		private void Btn_OK_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}

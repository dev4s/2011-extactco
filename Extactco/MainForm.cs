using System.Windows.Forms;

namespace Extactco
{
	public partial class MainForm :	Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Btn_Settings_Click(object sender, System.EventArgs e)
		{
			var settingsForm = new SettingsForm();
			settingsForm.ShowDialog();
		}

		private void Btn_Export_Click(object sender, System.EventArgs e)
		{
			var dateSelectForm = new DateSelect();
			dateSelectForm.ShowDialog();
		}
	}
}

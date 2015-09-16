using System.Drawing;
using System.Windows.Forms;

namespace Extactco
{
	public partial class ErrorForm : Form
	{
		public string Message {set; private get;}

		public ErrorForm()
		{
			InitializeComponent();
		}

		private void Btn_OK_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void ErrorForm_Load(object sender, System.EventArgs e)
		{
			TxtBox_ErrorMsg.Text = Message;
		}

		private void ErrorForm_SizeChanged(object sender, System.EventArgs e)
		{
			var errorForm = (ErrorForm) sender;
			TxtBox_ErrorMsg.Size = new Size(errorForm.Size.Width - 16, errorForm.Size.Height - 67);
			Btn_OK.Location = new Point(TxtBox_ErrorMsg.Size.Width - 82, TxtBox_ErrorMsg.Size.Height + 5);
		}
	}
}

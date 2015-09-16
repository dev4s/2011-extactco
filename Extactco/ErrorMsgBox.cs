using System;

namespace Extactco
{
	public static class ErrorMsgBox
	{
		public static void Show(string msg)
		{
			var errorForm = new ErrorForm { Message = msg };
			errorForm.ShowDialog();
			errorForm.Update();
		}

		public static void Show(Exception e)
		{
			var errorForm = new ErrorForm { Message = String.Format("Message:\r\n{0}\r\n\r\nStack Trace:\r\n{1}", e.Message, e.StackTrace) };
			errorForm.ShowDialog();
			errorForm.Update();
		}
	}
}
using System.IO;

namespace Extactco
{
	public static class File
	{
		public static void Write(string text, string fileName)
		{
			var file = new FileInfo(fileName);
			if (!file.Exists)
			{
				using(var newFile = file.CreateText())
				{
					newFile.Write(text);
				}
			}
			else
			{
				using(var existingFile = file.AppendText())
				{
					existingFile.Write(text);
				}
			}
		}
	}
}

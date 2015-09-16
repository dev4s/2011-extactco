using System.Text;

namespace Extactco
{
	public static class EncryptorDecryptor
	{
		private const int Key = 129;

		public static string EncryptDecrypt(string textToEncrypt)
		{
			var inSb = new StringBuilder(textToEncrypt);
			var outSb = new StringBuilder(textToEncrypt.Length);
			for (var i = 0; i < textToEncrypt.Length; i++)
			{
				var c = inSb[i];
				c = (char)(c ^ Key);
				outSb.Append(c);
			}
			return outSb.ToString();
		}
	}
}

using System;

namespace Extactco
{
	public static class TimeStamp
	{
		public static string Get()
		{
			//201103210452 - np.
			return String.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
		}
	}
}

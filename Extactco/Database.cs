using System;
using System.Data.SqlClient;

namespace Extactco
{
	public class Database
	{
		public SqlConnection Connection;
		public SqlConnection Connection2;

		public bool TestConnection(string connectionString)
		{
			var dbConnection = new SqlConnection(connectionString);

			try
			{
				dbConnection.Open();
				Connection = dbConnection;
				dbConnection.Close();

				Connection2 = new SqlConnection(connectionString);
			}
			catch (Exception exception)
			{
				ErrorMsgBox.Show(exception);
				return false;
			}
			return true;
		}
	}
}

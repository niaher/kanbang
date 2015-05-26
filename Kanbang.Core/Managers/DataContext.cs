namespace Kanbang.Core.Managers
{
	using System.Configuration;
	using System.Data;
	using System.Data.SqlClient;

	public class DataContext
	{
		internal readonly IDbConnection DbConnection;

		public DataContext()
		{
			this.DbConnection = new SqlConnection(ConfigurationManager.AppSettings["Kanbang"]);
		}

		internal DataContext(IDbConnection dbConnection)
		{
			this.DbConnection = dbConnection;
		}
	}
}
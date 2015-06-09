namespace Kanbang.Core.Managers
{
	using System.Configuration;
	using System.Data;
	using System.Data.SqlClient;

	public class DataContext
	{
		public readonly IDbConnection DbConnection;

		public DataContext()
		{
            this.DbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Kanbang"].ConnectionString);
		}

		internal DataContext(IDbConnection dbConnection)
		{
			this.DbConnection = dbConnection;
		}
	}
}
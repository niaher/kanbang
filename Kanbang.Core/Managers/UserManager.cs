namespace Kanbang.Core.Managers
{
	using System.Data;
	using Kanbang.Core.DataAccess.Repositories;

	public class UserManager
	{
		private readonly IDbConnection connection;

		public UserManager(DataContext dataContext)
		{
			this.connection = dataContext.DbConnection;
		}

		public void ChangeNamesOfAllUsers(string name)
		{
			var users = this.connection.GetUsers();

			foreach (var user in users)
			{
				this.connection.ChangeUserName(user.Id, name);
			}
		}
	}
}
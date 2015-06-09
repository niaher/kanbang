namespace Kanbang.Core.Managers
{
    using System.Collections.Generic;
    using System.Data;
	using Kanbang.Core.DataAccess.Repositories;
    using Kanbang.Core.Domain;

    public class UserManager
	{
        private readonly DataContext kanbanContext;
		private readonly IDbConnection connection;
        
		public UserManager()
		{
            this.kanbanContext = new DataContext();
            this.connection = this.kanbanContext.DbConnection;
		}

		public void ChangeNamesOfAllUsers(string name)
		{
			var users = this.connection.GetUsers();

			foreach (var user in users)
			{
				this.connection.ChangeUserName(user.Id, name);
			}
		}

        public IEnumerable<User> GetAll()
        {
            return this.connection.GetUsers();
        }
	}
}
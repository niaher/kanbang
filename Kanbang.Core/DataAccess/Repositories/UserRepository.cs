namespace Kanbang.Core.DataAccess.Repositories
{
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Dapper;
	using Kanbang.Core.Domain;

	internal static class UserRepository
	{
		public static void ChangeUserName(this IDbConnection connection, int userId, string name)
		{
			connection.Execute("update [User] set Name = @Name where Id = @Id", new { Name = name, Id = userId });
		}

		public static User Get(this IDbConnection connection, int userId)
		{
			return connection.Query<User>("select * from [User] where Id = @Id", userId).SingleOrDefault();
		}

		public static IEnumerable<User> GetUsers(this IDbConnection connection)
		{
			return connection.Query<User>("select * from [User]");
		}
	}
}
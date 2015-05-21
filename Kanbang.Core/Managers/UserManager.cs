namespace Kanbang.Core.Managers
{
	using System.Linq;
	using Kanbang.Core.DataAccess;
	using Kanbang.Core.DataAccess.Queries;
	using Kanbang.Core.Domain;
	using Kanbang.Core.Events;
	using Kanbang.Core.Security;

	public class UserManager
	{
		private readonly KanbangDbContext dbContext;
		private readonly IExecutionContext executionContext;

		public UserManager(DataContext context, IExecutionContext executionContext)
		{
			this.dbContext = context.DbContext;
			this.executionContext = executionContext;
		}

		public IQueryable<User> Users
		{
			get
			{
				return this.dbContext.Users;
			}
		}

		public User EnsureUser(string name)
		{
			var user = this.dbContext.Users.GetByName(name).SingleOrDefault();

			if (user == null)
			{
				user = this.dbContext.Users.Create();
				user.Name = name;

				this.dbContext.Users.Add(user);
				this.dbContext.SaveChanges();

				EventManager.Streams.Publish(EventTypes.UserCreated.CreateEvent(user, this.executionContext.User));
			}

			return user;
		}

		public void DeleteUserData(int userId)
		{
			new UserPermissionManager().EnforceCanDo(UserActions.DeleteUserData, this.executionContext.User);

			var user = this.dbContext.Users.Find(userId);
			this.dbContext.Users.Remove(user);

			this.dbContext.SaveChanges();

			EventManager.Streams.Publish(EventTypes.UserDataDeleted.CreateEvent(user, this.executionContext.User));
		}
	}
}
namespace Kanbang.Web.Controllers.Api
{
	using System.Collections.Generic;
	using System.Web.Http;
	using Kanbang.Core.DataAccess.Repositories;
	using Kanbang.Core.Domain;
	using Kanbang.Core.Managers;

	public class UsersController : ApiController
	{
		private readonly DataContext dataContext;

		public UsersController(DataContext dataContext)
		{
			this.dataContext = dataContext;
		}

		[HttpGet]
		public User Get(int id)
		{
			return this.dataContext.DbConnection.Get(id);
		}

		[HttpGet]
		public IEnumerable<User> Get()
		{
			return this.dataContext.DbConnection.GetUsers();
		}
	}
}
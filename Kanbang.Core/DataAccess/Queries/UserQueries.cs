namespace Kanbang.Core.DataAccess.Queries
{
	using System.Linq;
	using Kanbang.Core.Domain;

	public static class UserQueries
	{
		public static IQueryable<User> GetByName(this IQueryable<User> queryable, string name)
		{
			return queryable.Where(e => e.Name.Contains(name));
		}
	}
}
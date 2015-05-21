namespace Kanbang.Core.Domain
{
	using System.Collections.Generic;
	using Kanbang.Core.Security;

	public static class UserExtensions
	{
		public static IList<UserRole> GetRoles(this User user)
		{
			if (user == null)
			{
				return new List<UserRole>();
			}

			var list = new List<UserRole> { UserRole.User };

			if (user.IsAdmin)
			{
				list.Add(UserRole.Admin);
			}

			return list;
		}
	}
}
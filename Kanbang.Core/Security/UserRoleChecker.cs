namespace Kanbang.Core.Security
{
	using System.Collections.Generic;
	using Coderful.Permissions;
	using Kanbang.Core.Domain;

	public class UserRoleChecker : IRoleChecker<User, UserRole>
	{
		public IEnumerable<UserRole> GetRoles(User user)
		{
			return user.GetRoles();
		}
	}
}
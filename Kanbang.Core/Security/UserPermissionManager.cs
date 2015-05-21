namespace Kanbang.Core.Security
{
	using System;
	using System.Collections.Generic;
	using Coderful.Permissions;
	using Kanbang.Core.Domain;

	public class UserPermissionManager : PermissionManager<User, UserRole>
	{
		public UserPermissionManager()
			: base(new UserRoleChecker())
		{
		}

		public override IEnumerable<UserAction> GetAllowedUserActions(UserRole role)
		{
			switch (role)
			{
				case UserRole.User:
					return new UserAction[] { };
				case UserRole.Admin:
					return new[] { UserActions.Impersonate, UserActions.DeleteUserData };
				default:
					throw new ArgumentOutOfRangeException("role");
			}
		}
	}
}

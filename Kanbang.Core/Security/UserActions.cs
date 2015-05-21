namespace Kanbang.Core.Security
{
	using System.Collections.Generic;
	using Coderful.Permissions;

	public sealed class UserActions
	{
		public static class ContextlessActionNames
		{
			// ReSharper disable MemberHidesStaticFromOuterClass
			public const string Impersonate = "Impersonate";
			public const string DeleteUserData = "Delete user data";
			// ReSharper restore MemberHidesStaticFromOuterClass
		}

		private static readonly Dictionary<string, UserAction> ContextlessActions = new Dictionary<string, UserAction>();

		public static readonly UserAction Impersonate;
		public static readonly UserAction DeleteUserData;

		static UserActions()
		{
			Impersonate = ContextlessActions.AddUserAction(ContextlessActionNames.Impersonate);
			DeleteUserData = ContextlessActions.AddUserAction(ContextlessActionNames.DeleteUserData);
		}

		public static IReadOnlyDictionary<string, UserAction> List
		{
			get
			{
				return ContextlessActions;
			}
		}
	}
}
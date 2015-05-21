namespace Kanbang.Core.Security
{
	using System.Collections.Generic;
	using Coderful.Permissions;

	public static class UserActionCollectionExtensions
	{
		public static UserAction AddUserAction(this IDictionary<string, UserAction> list, string name)
		{
			var userAction = new UserAction(name);
			list.Add(name, userAction);

			return userAction;
		}

		public static UserAction<T> AddUserAction<T>(this IDictionary<string, UserAction<T>> list, string name)
		{
			var userAction = new UserAction<T>(name);
			list.Add(name, userAction);

			return userAction;
		}
	}
}
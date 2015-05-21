namespace Kanbang.Core.Events
{
	using System;
	using Kanbang.Core.Domain;

	internal static class EventTypes
	{
		public static readonly EventType<User> UserCreated = new EventType<User>(1, "User created");
		public static readonly EventType<User> UserDataDeleted = new EventType<User>(2, "User data deleted");
		public static readonly EventType<Exception> ExceptionOccured = new EventType<Exception>(1000, "Exception occured");
	}
}
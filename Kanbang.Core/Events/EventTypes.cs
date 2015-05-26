namespace Kanbang.Core.Events
{
	using System;

	internal static class EventTypes
	{
		public static readonly EventType<Exception> ExceptionOccured = new EventType<Exception>(1000, "Exception occured");
	}
}
namespace Kanbang.Core.Events
{
	using Kanbang.Core.Domain;

	/// <summary>
	/// Base class for business events.
	/// </summary>
	public class BusinessEvent<T>
	{
		public BusinessEvent(EventType<T> type, User triggeredBy, T context)
			: this(type, triggeredBy, context, type.Name)
		{
		}

		public BusinessEvent(EventType<T> type, User triggeredBy, T context, string message)
		{
			this.Context = context;
			this.Type = type;
			this.Message = message;
			this.TriggeredBy = triggeredBy;
		}

		/// <summary>
		/// Gets or sets event type.
		/// </summary>
		public EventType<T> Type { get; set; }

		public T Context { get; set; }

		/// <summary>
		/// Gets or sets a string describing the event.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the user triggering the event
		/// </summary>
		public User TriggeredBy { get; set; }
	}
}
namespace Kanbang.Core.Events
{

	/// <summary>
	/// Base class for business events.
	/// </summary>
	public class BusinessEvent<T>
	{
		public BusinessEvent(EventType<T> type, T context)
			: this(type, context, type.Name)
		{
		}

		public BusinessEvent(EventType<T> type, T context, string message)
		{
			this.Context = context;
			this.Type = type;
			this.Message = message;
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
	}
}
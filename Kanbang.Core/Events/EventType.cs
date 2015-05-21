namespace Kanbang.Core.Events
{
	using Kanbang.Core.Domain;

	public class EventType<TEntity>
	{
		internal EventType(int code, string name)
		{
			this.Code = code;
			this.Name = name;
		}

		public int Code { get; private set; }
		public string Name { get; private set; }

		public BusinessEvent<TEntity> CreateEvent(TEntity entity, User triggeredByUser)
		{
			return new BusinessEvent<TEntity>(this, triggeredByUser, entity);
		}

		public BusinessEvent<TEntity> CreateEvent(TEntity entity, User triggeredByUser, string message)
		{
			return new BusinessEvent<TEntity>(this, triggeredByUser, entity, message);
		}
	}
}
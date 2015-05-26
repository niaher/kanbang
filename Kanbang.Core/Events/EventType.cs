namespace Kanbang.Core.Events
{

	public class EventType<TEntity>
	{
		internal EventType(int code, string name)
		{
			this.Code = code;
			this.Name = name;
		}

		public int Code { get; private set; }
		public string Name { get; private set; }

		public BusinessEvent<TEntity> CreateEvent(TEntity entity)
		{
			return new BusinessEvent<TEntity>(this, entity);
		}

		public BusinessEvent<TEntity> CreateEvent(TEntity entity, string message)
		{
			return new BusinessEvent<TEntity>(this, entity, message);
		}
	}
}
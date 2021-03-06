﻿namespace Kanbang.Core.Events
{
	using System;
	using Coderful.Events;

	public class EventManager
	{
		public static readonly EventManager Instance = new EventManager();

		internal static EventStreamManager Streams
		{
			get
			{
				return Instance.eventStreamManager;
			}
		}

		private readonly EventStreamManager eventStreamManager = new EventStreamManager();

		public EventManager()
		{
			this.eventStreamManager.AddEventStream(new EventStream<BusinessEvent<Exception>>());
		}

		public IDisposable RegisterHandler<T>(IEventHandler<T> handler)
		{
			return this.eventStreamManager.RegisterHandler(handler);
		}
	}
}

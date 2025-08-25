using System;

namespace BookBuddy.Domain
{
	public abstract class Entity
	{
		public Guid Id { get; protected set; }
	}
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookBuddy.Domain;
public interface IRepository<T> where T : AggregateRoot
{
}
using System;
using System.Collections.Generic;
using VotingTest.DAL.Entities;

namespace VotingTest.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Create(T item);
        void Delete(Guid id);
        T Get(Guid id);
        IEnumerable<T> GetAll();
        void Update(T item);
    }
}

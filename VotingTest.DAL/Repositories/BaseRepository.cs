using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VotingTest.DAL.Entities;
using VotingTest.DAL.EntityFramework;
using VotingTest.DAL.Interfaces;

namespace VotingTest.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T: BaseEntity, new()
    {
        private readonly EFdbContext _dbContext;

        public BaseRepository(EFdbContext db)
        {
            _dbContext = db;
        }
        public void Create(T item)
        {
            _dbContext.Set<T>().Add(item);
        }

        public void Delete(Guid id)
        {
            //var item = new T() {Id = id};
            //_dbContext.Set<T>().Attach(item);
            //_dbContext.Set<T>().Remove(item);
            T item = Get(id);
            if (item != null)
                _dbContext.Set<T>().Remove(item);
        }

        public T Get(Guid id)
        {
            return _dbContext.Set<T>().FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public void Update(T item)
        {
            try
            {
                _dbContext.Entry(item).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _dbContext.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }
        }
    }
}

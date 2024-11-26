using _01_DataAccessLayer.Abstarct;
using _01_DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		readonly CampContext context = new CampContext();
		private readonly DbSet<T> _dbSet;

        public GenericRepository()
        {
			_dbSet = context.Set<T>();
        }

        public void Delete(T entity)
		{
			var deletedEntitiy = context.Entry(entity);
			deletedEntitiy.State = EntityState.Deleted;
			context.SaveChanges();
		}

		public List<T> GetAll()
		{
			return _dbSet.ToList();
		}

		public T GetById(int id)
		{
			return _dbSet.Find(id);
		}

		public void Insert(T entity)
		{
			var addedEntity = context.Entry(entity);
			addedEntity.State = EntityState.Added;
			context.SaveChanges();
		}

		public void Update(T entity)
		{
			var updatedEntity = context.Entry(entity);
			updatedEntity.State = EntityState.Modified;
			context.SaveChanges();
		}
	}
}

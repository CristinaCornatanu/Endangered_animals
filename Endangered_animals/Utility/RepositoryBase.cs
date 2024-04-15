using Endangered_animals.Data;
using Endangered_animals.Interface;
using Endangered_animals.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    public abstract class RepositoryBase<T>: Subject, IRepository<T> where T : class 
    {
        private readonly endangered_animalsDbContext _context;
        private readonly DbSet<T> _dbSet;

        protected RepositoryBase(endangered_animalsDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
       
        public  T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public  void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            NotifyAll(this,EventArgs.Empty);
        }

        public  void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

            NotifyAll(this,EventArgs.Empty);

        }
        public  void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
                NotifyAll(this, EventArgs.Empty);
            }
        }


    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Contract.Repositories;
using System.Linq.Expressions;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly MovieShopAppDbContext _context;

        public BaseRepository(MovieShopAppDbContext context)
        {
            _context = context;
        }
        public int Delete(int id)
        {
            var record = GetById(id);
            if (record != null) 
            { 
                _context.Set<T>().Remove(record);
                return _context.SaveChanges();
            }

            return 0;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int GetCount(Expression<Func<T, bool>> filter)
        {
            if (filter != null)
            {
                return _context.Set<T>().Where(filter).Count();
            }

            return _context.Set<T>().Count();
        }

        public int Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
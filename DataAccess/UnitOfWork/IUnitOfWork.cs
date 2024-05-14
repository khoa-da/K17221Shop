using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        void Update<T>(T entity) where T : class;
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly K17221shopContext _context;
        public UnitOfWork(K17221shopContext context)
        {
            _context = context;
        }

        public void SaveChanges() => _context.SaveChanges();
        public void Update<T>(T entity) where T : class
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}

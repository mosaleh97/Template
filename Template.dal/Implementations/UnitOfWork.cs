using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Template.dal.Interfaces;

namespace Template.dal.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;
        private Dictionary<Type, object> _repositories;

        public IEmployeeRepository Employee { get; private set; }

        public UnitOfWork(ApplicationDBContext context)
        {
            
            _context = context;
            Employee = new EmployeeRepository(_context);
            _repositories = new Dictionary<Type, object>();
        }
      

      

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

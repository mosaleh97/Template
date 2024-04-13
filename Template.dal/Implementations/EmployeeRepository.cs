using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.dal.Interfaces;
using Template.dal.Models;

namespace Template.dal.Implementations
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}

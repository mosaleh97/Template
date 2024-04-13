using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.bll.Interfaces;
using Template.dal.Interfaces;
using Template.dal.Models;

namespace Template.bll.Implementations
{
    public class EmployeeService : GenericService<Employee>, IEmployeeService
    {
        public EmployeeService(IGenericRepository<Employee> repository) : base(repository)
        {
        }
    }
}

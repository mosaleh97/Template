using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.dal.Models;

namespace Template.dal.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
    }
}

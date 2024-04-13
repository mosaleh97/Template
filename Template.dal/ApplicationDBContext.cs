using Microsoft.EntityFrameworkCore;
using System;
using Template.dal.Models;

namespace Template.dal
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }
}

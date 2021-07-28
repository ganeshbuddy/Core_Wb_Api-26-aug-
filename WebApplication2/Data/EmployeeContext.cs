using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication2.Data
{
    public class EmployeeContext : DbContext
    {
            public EmployeeContext(DbContextOptions<EmployeeContext> options)
                : base(options)
            {
            }
            public DbSet<WebApplication2.Models.Employee> Employee { get; set; }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICRUDNet5.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace APICRUDNet5.DAL
{
    public class ApplicationDBContext : DbContext
    {
        
        public DbSet<Person> persons { get; set; }
        
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }
}

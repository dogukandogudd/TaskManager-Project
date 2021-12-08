using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class TaskManagerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=PitonTMDatabase;Trusted_Connection=true");
        }
        public DbSet<Entities.Concrete.Task> Task { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Location> Location { get; set; }
       
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRWORKFLOW.Entities.Concrete;

namespace TRWORKFLOW.DataAccess.Context
{
    public class TRWORKFLOWContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HLMBLC-NW\\SQLEXPRESS;Database=TRWORKFLOW;Trusted_Connection=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}

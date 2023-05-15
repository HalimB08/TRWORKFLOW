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
            optionsBuilder.UseSqlServer("Server=DESKTOP-NJD6BE3\\SQLEXPRESS;Database=TRWORKFLOW;Trusted_Connection=true;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer(@"Data Source=HLMBLC-NW\SQLEXPRESS;Initial Catalog=TRWORKFLOW;Integrated Security=True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}

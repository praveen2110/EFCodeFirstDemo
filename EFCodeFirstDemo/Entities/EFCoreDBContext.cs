using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo.Entities
{
    public class EFCoreDBContext : DbContext
    {
        public EFCoreDBContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //used this to configure the context

            optionsBuilder.UseSqlServer(@"Server = (LocalDb)\MSSQLLocalDB;Database = EF_coreDB ;Trusted_Connection = True;TrustServerCertificate= True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Use this to confiure the Model
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Mirrra.App_Data.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Mirrra.App_Data
{
    public class DBContent: DbContext
    {
        public DBContent(DbContextOptions<DBContent> options): base(options)
        { 
            
            

        }

        public DbSet<Cases> Cases{ get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}

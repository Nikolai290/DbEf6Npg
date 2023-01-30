using System.Data.Entity;

namespace DbEf6Npg
{
    public class UserContext : DbContext
    {

        public UserContext() : base("DbConnection")
        {
        }
        
        public DbSet<User> Users { get; set; }
    }
}
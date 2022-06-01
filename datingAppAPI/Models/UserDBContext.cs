using Microsoft.EntityFrameworkCore;

namespace datingAppAPI.Models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext()
        {
        }
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }
        public virtual DbSet<ContactInformation> ContactInformation { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Login> Login { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DatingDBAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }    
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace DatLy.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext>opt): base(opt)
        {


        }
        #region DbSet
        public DbSet<User> ? Users { get; set; }
        #endregion
    }
}
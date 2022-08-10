using Microsoft.EntityFrameworkCore;
using WebAppMVCTask.Models;

namespace WebAppMVCTask.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Orders> Orders { get; set; }
    }
}

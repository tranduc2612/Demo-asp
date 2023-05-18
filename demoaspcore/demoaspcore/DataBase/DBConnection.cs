using demoaspcore.Models;
using Microsoft.EntityFrameworkCore;

namespace demoaspcore.DataBase
{
    public class DBConnection : DbContext
    {
        public DBConnection(DbContextOptions options) : base(options)
        {
        }

        public DbSet<tKhachHang> MyProperty { get; set; }
    }
}

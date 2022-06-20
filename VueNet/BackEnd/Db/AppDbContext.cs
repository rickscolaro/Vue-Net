using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Db {
    public class AppDbContext : DbContext {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {


        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
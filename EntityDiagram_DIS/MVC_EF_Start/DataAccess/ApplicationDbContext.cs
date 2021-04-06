using Microsoft.EntityFrameworkCore;
using EntityDiagram_DIS.Models;

namespace EntityDiagram_DIS.DataAccess
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

  
    public DbSet<Store> Store { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<OrderProductMap> OrderProductMaps { get; set; }
  }
}
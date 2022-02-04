using Microsoft.EntityFrameworkCore;
using WebAPICRUD.Data.Entities;

namespace WebAPICRUD.Data;

public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options): base(options)
    {

    }
    public DbSet<Cake> Cakes { get; set; }
    public object Cake { get; set; }
}
 
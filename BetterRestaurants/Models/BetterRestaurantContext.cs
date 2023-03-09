using Microsoft.EntityFrameworkCore;

namespace BetterRestaurants.Models
{
  public class BetterRestaurantContext : DbContext
  {
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public BetterRestaurantContext(DbContextOptions options) : base(options) { }
  }
}

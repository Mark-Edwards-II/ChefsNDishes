using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Context
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }

        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}
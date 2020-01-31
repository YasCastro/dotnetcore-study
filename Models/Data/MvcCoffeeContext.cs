using Microsoft.EntityFrameworkCore;
using MvcCoffee.Models;

namespace MvcCoffee.Data
{
    public class MvcCoffeeContext : DbContext
    {
        public MvcCoffeeContext (DbContextOptions<MvcCoffeeContext> options)
            : base(options)
        {
        }

        public DbSet<Coffee> Coffee { get; set; }
    }
}
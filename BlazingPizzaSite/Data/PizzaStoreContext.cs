using BlazingPizzaSite.Model;
using BlazingPizzaSite.Services;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizzaSite.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(
            DbContextOptions options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Pizza> Pizzas { get; set; }

        public DbSet<PizzaSpecial> Specials { get; set; }

        public DbSet<Topping> Toppings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring a many-to-many special -> topping relationship that is friendly for serialization
            modelBuilder.Entity<PizzaTopping>().HasKey(pst => new { pst.PizzaId, pst.ToppingId });
            modelBuilder.Entity<PizzaTopping>().HasOne<Pizza>().WithMany(ps => ps.Toppings);
            modelBuilder.Entity<PizzaTopping>().HasOne(pst => pst.Topping).WithMany();

            modelBuilder.Entity<PizzaSpecial>().HasData(new PizzaSpecial { Id = 1, Name = "The Baconatorizor", BasePrice = 11.99M, Description = "It has EVERY kind of bacon", ImageUrl = "img/pizzas/bacon.jpg" });
            modelBuilder.Entity<PizzaSpecial>().HasData(new PizzaSpecial { Id = 2, Name = "Buffalo chicken", BasePrice = 12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", ImageUrl = "img/pizzas/meaty.jpg" });
            modelBuilder.Entity<PizzaSpecial>().HasData(new PizzaSpecial { Id = 3, Name = "Veggie Delight", BasePrice = 11.5M, Description = "It's like salad, but on a pizza", ImageUrl = "img/pizzas/salad.jpg" });
            modelBuilder.Entity<PizzaSpecial>().HasData(new PizzaSpecial { Id = 4, Name = "Margherita", BasePrice = 9.99M, Description = "Traditional Italian pizza with tomatoes and basil", ImageUrl = "img/pizzas/margherita.jpg" });
            modelBuilder.Entity<PizzaSpecial>().HasData(new PizzaSpecial { Id = 5, Name = "Basic Cheese Pizza", BasePrice = 11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", ImageUrl = "img/pizzas/cheese.jpg" });
            modelBuilder.Entity<PizzaSpecial>().HasData(new PizzaSpecial { Id = 6, Name = "Classic pepperoni", BasePrice = 10.5M, Description = "It's the pizza you grew up with, but Blazing hot!", ImageUrl = "img/pizzas/pepperoni.jpg" });
            modelBuilder.Entity<PizzaSpecial>().HasData(new PizzaSpecial { Id = 9, Name = "Margherita Family Size", Description = "24\" of pure tomatoes and basil", BasePrice = 14.99m, ImageUrl = "img/pizzas/margherita.jpg", FixedSize = 24});
        }
    }
}

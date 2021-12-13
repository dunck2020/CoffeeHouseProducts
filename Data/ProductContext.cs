using CoffeeHouseProducts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeHouseProducts.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Lg Coffee",
                    Description = "Fresh brew from coffee house",
                    Price = 3.00m,
                    Type = Product.ProductType.Drink
                },
                new Product
                {
                    Id = 2,
                    Name = "Md Coffee",
                    Description = "Fresh brew from BRC",
                    Price = 2.00m,
                    Type = Product.ProductType.Drink
                },
                new Product
                {
                    Id = 3,
                    Name = "Sm Coffee",
                    Description = "Fresh brew from BRC",
                    Price = 1.00m,
                    Type = Product.ProductType.Drink
                },
                new Product
                {
                    Id = 4,
                    Name = "Blueberry Muffin",
                    Description = "Delicious suger glazed treat",
                    Price = 2.00m,
                    Type = Product.ProductType.Food
                },
                new Product
                {
                    Id = 5,
                    Name = "Sm T-Shirt",
                    Description = "Soft Cotton-Blend",
                    Price = 20.00m,
                    Type = Product.ProductType.Swag
                });

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new Comment
                {
                    Id = 2,
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new Comment
                {
                    Id = 3,
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                });
        }
    }
}

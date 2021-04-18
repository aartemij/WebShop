using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Shared;

namespace WebShop.Client.Services.ProductService
{
    internal class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>(); 

        public void LoadProducts()
        {
            Products = new List<Product> {
                new Product {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product {
                    Id = 2,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the2Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 10.99m,
                    OriginalPrice = 19.99m,
                },
                new Product {
                    Id = 3,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the2Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 10.99m,
                    OriginalPrice = 19.99m,
                },
                new Product {
                    Id = 4,
                    CategoryId = 2,
                    Title = "The Hitchhiker's Guide to the2Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 10.99m,
                    OriginalPrice = 19.99m,
                },
                new Product {
                    Id = 5,
                    CategoryId = 2,
                    Title = "The Hitchhiker's Guide to the2Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 10.99m,
                    OriginalPrice = 19.99m,
                },
                new Product {
                    Id = 6,
                    CategoryId = 2,
                    Title = "The Hitchhiker's Guide to the2Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 10.99m,
                    OriginalPrice = 19.99m,
                },
                new Product {
                    Id = 7,
                    CategoryId = 3,
                    Title = "The Hitchhiker's Guide to the2Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 10.99m,
                    OriginalPrice = 19.99m,
                },
                new Product {
                    Id = 8,
                    CategoryId = 3,
                    Title = "The Hitchhiker's Guide to the2Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 10.99m,
                    OriginalPrice = 19.99m,
                },
                new Product {
                    Id = 9,
                    CategoryId = 3,
                    Title = "The Hitchhiker's Guide to the2Galaxy",
                    Description = "oj ebatj dolgo pisatj koroche",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 14.99m,
                },
            };
        }
    }
}
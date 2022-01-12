using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BeckyShopping.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;

namespace BeckyShopping.Data
{
    public class ShoppingSeeder
    {
        private readonly ShoppingContext _ctx;
        private readonly IWebHostEnvironment _hosting;
        private readonly UserManager<StoreUser> _userManager;

        public ShoppingSeeder(ShoppingContext ctx, 
            IWebHostEnvironment hosting, 
            UserManager<StoreUser> userManager)
        {
            _ctx = ctx;
            _hosting = hosting;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            _ctx.Database.EnsureCreated();

            StoreUser user = await _userManager.FindByEmailAsync("beckyonlineshopping@gmail.com");
            if (user == null)
            {
                user = new StoreUser()
                {
                    FirstName = "Rebecca",
                    LastName = "Suppris",
                    Email = "beckyonlineshopping@gmail.com",
                    UserName = "beckyonlineshopping@gmail.com"
                };
                var result = await _userManager.CreateAsync(user, "P@ssw0rd!");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder.");
                }
            }
            if (!_ctx.Products.Any())
            {
                // Need to create the Sample Data
                var file = Path.Combine(_hosting.ContentRootPath, "Data/product.json");
                var json = File.ReadAllText(file);
                var products = JsonSerializer.Deserialize<IEnumerable<Product>>(json);
                
                _ctx.Products.AddRange(products);

                var order = _ctx.Orders.Where(o => o.Id == 1).FirstOrDefault();
                if (order != null)
                {
                    order.User = user;
                    order.Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                          Product = products.First(),
                          Quantity = 5,
                          UnitPrice = products.First().Price
                        }
                    };
                }

                _ctx.SaveChanges();
            }
        }
    }
}

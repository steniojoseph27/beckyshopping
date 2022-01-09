﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeckyShopping.Data.Entities;
using Microsoft.Extensions.Logging;

namespace BeckyShopping.Data
{
    public class ShoppingRepository : IShoppingRepository
    {
        private readonly ShoppingContext _ctx;
        private readonly ILogger<ShoppingRepository> _logger;

        public ShoppingRepository(ShoppingContext ctx, ILogger<ShoppingRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                _logger.LogInformation("GetAllProducts was called...");

                return _ctx.Products
                           .OrderBy(p => p.Name)
                           .ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all products: {ex}");
                return null;
            }
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products
                       .Where(p => p.Category == category)
                       .ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
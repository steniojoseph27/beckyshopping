using BeckyShopping.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckyShopping.Data
{
    public interface IShoppingRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);

        IEnumerable<Order> GetAllOrders();
        Order GetAllOrderById(int id);
        bool SaveAll();
        void AddEntity(object model);
    }
}

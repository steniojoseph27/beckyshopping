using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckyShopping.Data.Entities
{
  public class Product
  {
    public int Id { get; set; }
    public string Category { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
    public string Name { get; set; }
    public string ProductDescription { get; set; }
    public string SupplierId { get; set; }
    public string Supplier { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string ProductOrigin { get; set; }
  }
}

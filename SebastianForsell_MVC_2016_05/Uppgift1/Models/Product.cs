//Sebastian Forsell

using System.ComponentModel.DataAnnotations;

namespace Uppgift1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [MinLength(5), MaxLength(50)]
        public string Name { get; set; }
        public string ProductText { get; set; }
        [Required, CheckProductNumber, MinLength(3), MaxLength(7)]
        public string ProductNumber { get; set; }
        [Required, Range(0.01, 1000.00)]
        public double Price { get; set; }
        public int productsInStock { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyAPIOdata.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stok { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public DateTime? Created { get; set; }
        public virtual Category Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLazy
{
    class Product
    {        
        public int ID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Product() { }
        public Product(int iD, string description, int price)
        {
            ID = iD;
            Description = description;
            Price = price;

            Console.WriteLine("Constructor for Product : " + Description + " invoked");
        }

        public override string ToString()
        {
        
            return $"{ID}, {Description}, {String.Format("{0:F2}",Price)}";
        }

    }
}

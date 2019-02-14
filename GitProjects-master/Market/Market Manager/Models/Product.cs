using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Manager.Models
{
    struct Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string mark { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Product(string id, string name, string mark, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
            this.price = price;
            this.quantity = quantity;
        }
    }
}

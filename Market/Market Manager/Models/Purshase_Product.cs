using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Manager.Models
{
    struct Purshase_Product
    {
        public string id_product { get; set; }
        public string product_name { get; set; }
        public string product_mark { get; set; }
        public double product_price { get; set; }
        public  int quantity_desired { get; set; }
        public double amount { get; set; }
        public double total_amount { get; set; }
        public Purshase_Product(string id, string name, string mark, double price, int quantity, double amount, double total)
        {
            this.id_product = id;
            this.product_name = name;
            this.product_mark = mark;
            this.product_price = price;
            this.quantity_desired = quantity;
            this.amount = amount;
            this.total_amount = total;
        }
    }
}

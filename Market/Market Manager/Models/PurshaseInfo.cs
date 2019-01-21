using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Manager.Models
{
    struct PurshaseInfo
    {
        public string id_purshase { get; set; }
        public string id_customer { get; set; }
        public string customer_name { get; set; }
        public string date { get; set; }
        public List<Purshase_Product> products { get; set; }

        public PurshaseInfo(string id_purshase, string id_customer, string customer_name, string date, List<Purshase_Product> products)
        {
            this.id_purshase = id_purshase;
            this.id_customer = id_customer;
            this.customer_name = customer_name;
            this.date = date;
            this.products = products;
        }
    }
}

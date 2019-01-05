using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Manager.Models
{
    public struct CustomerModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public CustomerModel(string id, string name, string lastname, string phone, string address, string email)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.address = address;
            this.email = email;
        }
    }
}

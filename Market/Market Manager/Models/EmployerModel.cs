using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Manager.Models
{
    public struct EmployerModel
    {
        public string id_employer { get; set; }
        public string employer_name { get; set; }
        public string employer_lastname { get; set; }
        public string employer_address { get; set; }
        public string employer_phone { get; set; }
        public string employer_email { get; set; }
        public string employer_dln { get; set; }
        public string employer_role { get; set; }
        public string id_logged { get; set; }

        public EmployerModel(string id, string name, string lastname, string address, string phone, string email, string dln, string role,string id_logged = "")
        {
            id_employer = id;
            employer_name = name;
            employer_role = role;
            employer_address = address;
            employer_lastname = lastname;
            employer_phone = phone;
            employer_email = email;
            employer_dln = dln;
            this.id_logged = id_logged;

        }
    }
}

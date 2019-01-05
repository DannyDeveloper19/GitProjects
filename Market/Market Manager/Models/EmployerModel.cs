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
        public string employer_role { get; set; }

        public EmployerModel(string id, string name, string role)
        {
            id_employer = id;
            employer_name = name;
            employer_role = role;
        }
    }
}

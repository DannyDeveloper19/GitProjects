using Connection;
using Market_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Manager.DataConnection
{
    class Employer_Data
    {
        public static EmployerModel Login(string id_employer, string password)
        {
            //It's not done
            return new EmployerModel();
        }

        public static EmployerModel Employer_Info(string id_employer)
        {
            //It's not done
            return new EmployerModel();
        }
    }
    class Customer_Data {
        public static void newCustomer(CustomerModel customer)
        {
            string cmd = string.Format("EXEC UpdateCustomer '{0}','{1}','{2}','{3}','{4}','{5}','{6}'"
                , customer.id, customer.name, customer.lastname, customer.phone, customer.address, customer.email, customer.dni);
            Utilities.execute(cmd);
        }

        public static void removeCustomer(string id_customer)
        {
            string cmd = string.Format("EXEC RemoveCustomer '{0}'", id_customer);
            Utilities.execute(cmd);
        }
    }
    class Product_Data
        {
            public static void updateProduct(Product product)
            {
                string cmd = string.Format("EXEC UpdateProduct '{0}','{1}','{2}','{3}'"
                , product.id, product.name, product.mark, product.price, product.quantity);
                Utilities.execute(cmd);
            }
        }
    
}

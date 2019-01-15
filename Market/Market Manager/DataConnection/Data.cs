using Connection;
using Market_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static CustomerModel getCustomer(string id_customer)
        {
            string cmd = string.Format("Select * from Customers where id_customer='{0}'", id_customer.Trim());
            DataSet data = Utilities.execute(cmd);
            var id = data.Tables[0].Rows[0]["id_customer"].ToString().Trim();
            var name = data.Tables[0].Rows[0]["customer_name"].ToString().Trim();
            var lastname = data.Tables[0].Rows[0]["customer_lastname"].ToString().Trim();
            var address = data.Tables[0].Rows[0]["customer_address"].ToString().Trim();
            var phone = data.Tables[0].Rows[0]["customer_phone"].ToString().Trim();
            var email = data.Tables[0].Rows[0]["customer_email"].ToString().Trim();
            var dni = data.Tables[0].Rows[0]["customer_dni"].ToString().Trim();
            return new CustomerModel(id,name,lastname,phone,address,email,dni);
        }

        public static List<CustomerModel> getAllCustomers()
        {
            var listCustomer = new List<CustomerModel>();
            string cmd = string.Format("Select * from Customers");
            DataSet data = Utilities.execute(cmd);
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                var row = data.Tables[0].Rows[i]; 
                var customer = new CustomerModel(
                    row["id_customer"].ToString().Trim(),
                    row["customer_name"].ToString().Trim(),
                    row["customer_lastname"].ToString().Trim(),
                    row["customer_address"].ToString().Trim(),
                    row["customer_phone"].ToString().Trim(),
                    row["customer_email"].ToString().Trim(),
                    row["customer_dni"].ToString().Trim()
                    );
                listCustomer.Add(customer);
            }
            return listCustomer;
        }
    }
    class Product_Data
        {
            public static void updateProduct(Product product)
            {
                string cmd = string.Format("EXEC UpdateProduct '{0}','{1}','{2}','{3}','{4}'"
                , product.id, product.name, product.mark, product.price, product.quantity);
                Utilities.execute(cmd);

            }

        public static Product getProduct(string id_product)
        {
            string cmd = string.Format("Select * from Items where id_item='{0}'", id_product);
            DataSet data = Utilities.execute(cmd);
            var id = data.Tables[0].Rows[0]["id_item"].ToString().Trim();
            var name = data.Tables[0].Rows[0]["item_name"].ToString().Trim();
            var mark = data.Tables[0].Rows[0]["item_mark"].ToString().Trim();
            var price =double.Parse(data.Tables[0].Rows[0]["item_price"].ToString().Trim());
            var quantity = int.Parse(data.Tables[0].Rows[0]["item_quantity"].ToString().Trim());
            return new Product(id, name, mark, price, quantity);
        }

            public static void AddProduct(string id_purshase, string id_customer, string id_item, int quantity)
        {
            string cmd = string.Format("EXEC AddProduct '{0}','{1}','{2}','{3}'", id_purshase, id_customer, id_item, quantity);
            Utilities.execute(cmd);
        }
        
    }

    class Purshase
    {
        public static Purshase_Product GetPurshase(string id_purshase, string id_product, string id_customer)
        {
            string cmd = string.Format("EXEC GetPurshase '{0}','{1}','{2}'", id_purshase,id_product,id_customer);
            DataSet data = Utilities.execute(cmd);

            var id = data.Tables[0].Rows[0]["id_item"].ToString().Trim();
            var name = data.Tables[0].Rows[0]["item_name"].ToString().Trim();
            var mark = data.Tables[0].Rows[0]["item_mark"].ToString().Trim();
            var price = double.Parse(data.Tables[0].Rows[0]["item_price"].ToString().Trim());
            var quantity_prod = int.Parse(data.Tables[0].Rows[0]["item_purshased_quantity"].ToString().Trim());
            var amount = double.Parse(data.Tables[0].Rows[0]["item_purshased_amount"].ToString().Trim());
            var total = double.Parse(data.Tables[0].Rows[0]["purshase_amount"].ToString().Trim());

            return new Purshase_Product(id, name, mark, price, quantity_prod, amount, total);
        }
    }
    
}

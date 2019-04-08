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
        //Employer log in --Done
        public static object Login(string id_employer, string password)
        {
            string sql_query = string.Format("Select * from Employers where id_employer = '{0}'", id_employer);
            DataSet dataSet = Utilities.execute(sql_query);

            //Check password encrypted
            string pass = dataSet.Tables[0].Rows[0]["employer_password"].ToString().Trim();
            //!Security.Security.ComparePassword(password,pass)
            string status = dataSet.Tables[0].Rows[0]["status"].ToString().Trim();
            if (status == "inactive")
            {
                if (!password.Equals(pass))
                {
                    return false;
                }
            }
            else if (!Security.Security.ComparePassword(password, pass))
            {
                return false;
            }

            string id = dataSet.Tables[0].Rows[0]["id_employer"].ToString().Trim();
            string name = dataSet.Tables[0].Rows[0]["employer_name"].ToString().Trim();
            string lastname = dataSet.Tables[0].Rows[0]["employer_lastname"].ToString().Trim();
            string address = dataSet.Tables[0].Rows[0]["employer_address"].ToString().Trim();
            string phone = dataSet.Tables[0].Rows[0]["employer_phone"].ToString().Trim();
            string email = dataSet.Tables[0].Rows[0]["employer_email"].ToString().Trim();
            string dln = dataSet.Tables[0].Rows[0]["employer_dln"].ToString().Trim();
            sql_query = string.Format("Select role_name from Roles inner join Employer_Role on Employer_Role.id_role = Roles.id_role where Employer_Role.id_employer = '{0}'", id);
            dataSet = Utilities.execute(sql_query);
            string role = dataSet.Tables[0].Rows[0]["role_name"].ToString();
            dataSet = Utilities.execute(string.Format("Select Picture from Employer_Picture where id_employer = '{0}'", id));
            byte[] picture = null;
            if (dataSet.Tables[0].Rows.Count != 0)
                picture = (byte[])dataSet.Tables[0].Rows[0]["Picture"];
            DataSet data = Utilities.execute(string.Format("EXEC Log_In_Out '{0}','{1}'", id, 1));
            var id_logged = data.Tables[0].Rows[0]["id_logged"].ToString().Trim();
            var employer =(picture != null)? new EmployerModel(id, name, lastname, address, phone, email, dln, role, id_logged,picture) : new EmployerModel(id, name, lastname, address, phone, email, dln, role,id_logged);
            return employer;
            
        }

        public static void LogOut(string id, string id_logged)
        {
            DataSet data = Utilities.execute(string.Format("EXEC Log_In_Out '{0}','{1}','{2}'", id, 0, id_logged));
        }

        //Employer information
        public static EmployerModel Employer_Info(string id_employer)
        {
            //It's not done
            return new EmployerModel();
        }

        //Add new employer --Done
        public static void Update_NewEmployer(EmployerModel employer)
        {
            if (employer.picture != null)
            {
                Tuple<string, object>[] args =
            {
               Tuple.Create<string, object>(item1:"@id",item2:employer.id_employer),
               Tuple.Create<string, object>(item1:"@name",item2:employer.employer_name),
               Tuple.Create<string, object>(item1:"@lastname",item2:employer.employer_lastname),
               Tuple.Create<string, object>(item1:"@phone",item2:employer.employer_phone),
               Tuple.Create<string, object>(item1:"@email",item2:employer.employer_email),
               Tuple.Create<string, object>(item1:"@role",item2:employer.employer_role),
               Tuple.Create<string, object>(item1:"@address",item2:employer.employer_address),
               Tuple.Create<string, object>(item1:"@dln",item2:employer.employer_dln),
               Tuple.Create<string, object>(item1:"@picture",item2:employer.picture)
            };
                Utilities.execute("EXEC UpdateEmployer @id,@name,@lastname,@phone,@email,@role,@address,@dln,@picture", args);
            }
            else
            {
                Tuple<string, object>[] args =
            {
               Tuple.Create<string, object>(item1:"@id",item2:employer.id_employer),
               Tuple.Create<string, object>(item1:"@name",item2:employer.employer_name),
               Tuple.Create<string, object>(item1:"@lastname",item2:employer.employer_lastname),
               Tuple.Create<string, object>(item1:"@phone",item2:employer.employer_phone),
               Tuple.Create<string, object>(item1:"@email",item2:employer.employer_email),
               Tuple.Create<string, object>(item1:"@role",item2:employer.employer_role),
               Tuple.Create<string, object>(item1:"@address",item2:employer.employer_address),
               Tuple.Create<string, object>(item1:"@dln",item2:employer.employer_dln)
            };
                Utilities.execute("EXEC UpdateEmployer @id,@name,@lastname,@phone,@email,@role,@address,@dln", args);
            }

        }

        //Change password
        public static bool ChangePassword(string id, string oldpassword, string newpassword)
        {
            DataSet data = Utilities.execute(string.Format("Select employer_password,status from Employers where id_employer = '{0}'",id));
            string selected = data.Tables[0].Rows[0]["employer_password"].ToString().Trim();
            string status = data.Tables[0].Rows[0]["status"].ToString().Trim();
            //Security.Security.ComparePassword(oldpassword,selected)
            //Old Password can't be equal new password
            if (status == "inactive")
            {
                if (!oldpassword.Equals(selected))
                {
                    return false;
                }
            }
            else if (!Security.Security.ComparePassword(oldpassword, selected))
            {
                return false;
            }
            string cmd = string.Format("EXEC ChangePassword '{0}','{1}'", id, newpassword);
            Utilities.execute(cmd);
            return true;
        }

        //Update employer infomation

        //Remove employer
    }

    class Customer_Data {
        //add a new customer
        public static void newCustomer(CustomerModel customer)
        {
            string cmd = string.Format("EXEC UpdateCustomer '{0}','{1}','{2}','{3}','{4}','{5}','{6}'"
                , customer.id, customer.name, customer.lastname, customer.phone, customer.address, customer.email, customer.dni);
            Utilities.execute(cmd);
        }

        //Update customer information

        //Remove customer
        public static void removeCustomer(string id_customer)
        {
            string cmd = string.Format("EXEC RemoveCustomer '{0}'", id_customer);
            Utilities.execute(cmd);
        }

        //Customer information
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

        //Get all Customers
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
        //Update product info
        public static void updateProduct(Product product)
            {
                string cmd = string.Format("EXEC UpdateProduct '{0}','{1}','{2}','{3}','{4}'"
                , product.id, product.name, product.mark, product.price, product.quantity);
                Utilities.execute(cmd);

            }

        //Get product
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

        //Get all product in stock
        public static List<Product> getAllProducts()
        {
            var listProducts = new List<Product>();
            string cmd = string.Format("Select * from Items where item_status = 'in stock'");
            DataSet data = Utilities.execute(cmd);
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                var row = data.Tables[0].Rows[i];
                var product = new Product(
                    row["id_item"].ToString().Trim(),
                    row["item_name"].ToString().Trim(),
                    row["item_mark"].ToString().Trim(),
                    double.Parse(row["item_price"].ToString().Trim()),
                    int.Parse(row["item_quantity"].ToString().Trim())
                    );
                listProducts.Add(product);
            }
            return listProducts;
        }
       
        
    }

    class Purshase
    {
        //Add new product to a purshase
        public static void AddProduct(string id_purshase, string id_customer, string id_item, int quantity, string id_employer)
        {
            string cmd = string.Format("EXEC AddProductToPurshase '{0}','{1}','{2}','{3}','{4}'", id_purshase, id_customer, id_item, quantity, id_employer);
            Utilities.execute(cmd);
        }

        public static void RemoveProduct(string id_purshase, string id_item)
        {
            string cmd = string.Format("EXEC RemoveProductFromPurshase '{0}','{1}'",id_purshase,id_item);
            Utilities.execute(cmd);
        }
        //Get product selected info
        public static Purshase_Product GetProductSelected(string id_purshase, string id_product, string id_customer)
        {
            string cmd = string.Format("EXEC GetProductSelected '{0}','{1}','{2}'", id_purshase,id_product,id_customer);
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

        //Get Purshase processed
        public static PurshaseInfo GetPurshase(string id_purshase)
        {
            //fix the proccess
            string cmd = string.Format("EXEC GetPurshaseProcessed '{0}'", id_purshase);
            DataSet data = Utilities.execute(cmd);
            List<Purshase_Product> products = new List<Purshase_Product>();
            if (data.Tables[0].Rows.Count != 0)
            {
                var id_employer = data.Tables[0].Rows[0]["id_employer"].ToString().Trim();
                var id_customer = data.Tables[0].Rows[0]["id_customer"].ToString().Trim();
                var customer_name = data.Tables[0].Rows[0]["customer_name"].ToString().Trim();
                customer_name += " " + data.Tables[0].Rows[0]["customer_lastname"].ToString().Trim();
                var date = data.Tables[0].Rows[0]["purshase_date"].ToString().Trim();

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    var row = data.Tables[0].Rows[i];
                    var product = new Purshase_Product(
                        row["id_item"].ToString().Trim(),
                        row["item_name"].ToString().Trim(),
                        row["item_mark"].ToString().Trim(),
                        double.Parse(row["item_price"].ToString().Trim()),
                        int.Parse(row["item_purshased_quantity"].ToString().Trim()),
                        double.Parse(row["item_purshased_amount"].ToString().Trim()),
                        double.Parse(row["purshase_amount"].ToString().Trim())
                        );
                    products.Add(product);
                }

                return new PurshaseInfo(id_employer,id_purshase, id_customer, customer_name, date, products);
            }
            else
                return new PurshaseInfo();            
        }
       
        // Return product processed
        public static void ReturnProduct(string id_purshase, string id_product, int quantity, string state)
        {
            string cmd = string.Format("EXEC ReturnProduct '{0}','{1}', '{2}', '{3}'", id_purshase, id_product, quantity, state);
            Utilities.execute(cmd);
        }        

        //Process a sale
        public static void ProcessSaleOrder(string id_purshase)
        {
            string cmd = string.Format("EXEC ProcessSaleOrder '{0}'", id_purshase);
            Utilities.execute(cmd);
        }

        //Cancel a sale
        public static void CancelSaleOrder(string id_purshase)
        {
            string cmd = string.Format("EXEC CancelSaleOrder '{0}'",id_purshase);
            Utilities.execute(cmd);
        }
    }

    enum Return_State
    {
        damaged, used, good
    }
    
}

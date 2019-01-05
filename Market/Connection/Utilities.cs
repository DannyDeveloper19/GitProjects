using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    public class Utilities
    {
        private static SqlConnection Connection
        {
            get { return new SqlConnection("Data Source=DANNYLAPTOP\\SQLEXPRESS;Initial Catalog=BD_MarketManager;Integrated Security=True"); }
        }

        public static DataSet execute(string query)
        {
            Connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(query,Connection);
            dp.Fill(ds);
            Connection.Close();
            return ds;
        }
    }
}

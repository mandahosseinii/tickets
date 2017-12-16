using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace layer3_DataClass
{
   public class OrderHistory
    {

        public void OrderHistoryDetails_insert(int Employeeid, int OrderID, int CustomerID, int status)
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlDataReader read;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("OrderHistoryDetails_insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Employeeid", SqlDbType.BigInt).Value = Employeeid;
            cmd.Parameters.Add("@OrderID", SqlDbType.BigInt).Value = OrderID;
            cmd.Parameters.Add("@CustomerID", SqlDbType.BigInt).Value = CustomerID;
            cmd.Parameters.Add("@status", SqlDbType.BigInt).Value = status;
            read = cmd.ExecuteReader();
            read.Close();
            conn.Close();
        }
    }
}

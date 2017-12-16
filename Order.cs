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
    public  class Order
    {
       


        public DataSet Orders_GetList()
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("Orders_GetList", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            return ds;
        }

        public DataSet Orders_GetList_By_Type(int type)
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("Orders_GetList_By_Type", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@type", type);
            //cmd.Parameters.Add("@type", SqlDbType.BigInt).Value = type;
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            return ds;
        }


        public void Orders_update(int id, string title, string desc, int vehicle, int price, int maxnumber, int beginning, int destination, string date, string time, int status)
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlDataReader read;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Orders_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = id;
            cmd.Parameters.Add("@OrderName", SqlDbType.NVarChar).Value = title;
            cmd.Parameters.Add("@OrderDesc", SqlDbType.NVarChar).Value = desc;
            cmd.Parameters.Add("@VehicleID", SqlDbType.BigInt).Value = vehicle;
            cmd.Parameters.Add("@price", SqlDbType.BigInt).Value = price;
            cmd.Parameters.Add("@maxnumber", SqlDbType.BigInt).Value = maxnumber;
            cmd.Parameters.Add("@beginning", SqlDbType.BigInt).Value = beginning;
            cmd.Parameters.Add("@destination", SqlDbType.BigInt).Value = destination;
            cmd.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            cmd.Parameters.Add("@time", SqlDbType.NVarChar).Value = time;
            cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
            read = cmd.ExecuteReader();
            read.Close();
            conn.Close();
        }

        public void Orders_insert(int id, string title, string desc, int vehicle, int price, int maxnumber, int beginning, int destination, string date, string time, int status)
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlDataReader read;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Orders_insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = id;
            cmd.Parameters.Add("@OrderName", SqlDbType.NVarChar).Value = title;
            cmd.Parameters.Add("@OrderDesc", SqlDbType.NVarChar).Value = desc;
            cmd.Parameters.Add("@Vehicle", SqlDbType.BigInt).Value = vehicle;
            cmd.Parameters.Add("@price", SqlDbType.BigInt).Value = price;
            cmd.Parameters.Add("@maxnumber", SqlDbType.BigInt).Value = maxnumber;
            cmd.Parameters.Add("@beginning", SqlDbType.BigInt).Value = beginning;
            cmd.Parameters.Add("@destination", SqlDbType.BigInt).Value = destination;
            cmd.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            cmd.Parameters.Add("@time", SqlDbType.NVarChar).Value = time;
            cmd.Parameters.Add("@time", SqlDbType.NVarChar).Value = status;
            read = cmd.ExecuteReader();
            read.Close();
            conn.Close();
        }

        public void Orders_delete(int id)
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlDataReader read;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Orders_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = id;
            read = cmd.ExecuteReader();
            read.Close();
            conn.Close();
        }
    }
}

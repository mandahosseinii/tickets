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
   public class Customer
    {

        public DataSet Select_Customer(Int64 id)
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("Select_Customer", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            //cmd.Parameters.Add("@type", SqlDbType.BigInt).Value = type;
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");
            return ds;
        }

        public DataSet Customer_GetList()
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("Customer_GetList", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");
            return ds;
        }

        public void Customer_update(Int64 id, string name, string family, string father, string codemelli, string bdate, Int64 bprovince, Int64 bcity, Int64 bpart, Int64 bvillage, string sex, Int64 lprovince, Int64 lcity, Int64 lpart, Int64 lvillage, int madrak, int tell, int status)
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlDataReader read;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Customer_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustomerID", SqlDbType.BigInt).Value = id;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = family;
            cmd.Parameters.Add("@FatherName", SqlDbType.NVarChar).Value = father;
            cmd.Parameters.Add("@NationalCode", SqlDbType.NVarChar).Value = codemelli;
            cmd.Parameters.Add("@BirthDate", SqlDbType.NVarChar).Value = bdate;
            cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = sex;
            cmd.Parameters.Add("@Phone", SqlDbType.Int).Value = tell;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
            cmd.Parameters.Add("@MadrakCode", SqlDbType.Int).Value = madrak;
            cmd.Parameters.Add("@BProvinceCode", SqlDbType.BigInt).Value = bprovince;
            cmd.Parameters.Add("@BCityCode", SqlDbType.BigInt).Value = bcity;
            cmd.Parameters.Add("@BPartCode", SqlDbType.BigInt).Value = bpart;
            cmd.Parameters.Add("@BVillageCode", SqlDbType.BigInt).Value = bvillage;
            cmd.Parameters.Add("@LProvinceCode", SqlDbType.BigInt).Value = lprovince;
            cmd.Parameters.Add("@LCityCode", SqlDbType.BigInt).Value = lcity;
            cmd.Parameters.Add("@LPartCode", SqlDbType.BigInt).Value = lpart;
            cmd.Parameters.Add("@LVillageCode", SqlDbType.BigInt).Value = lvillage;
            read = cmd.ExecuteReader();
            read.Close();
            conn.Close();

        }

        public void Customer_insert(string name, string family, string father, string codemelli, string bdate, Int64 bprovince, Int64 bcity, Int64 bpart, Int64 bvillage, string sex, Int64 lprovince, Int64 lcity, Int64 lpart, Int64 lvillage, int madrak, int tell, int status)
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlDataReader read;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Customer_insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = family;
            cmd.Parameters.Add("@FatherName", SqlDbType.NVarChar).Value = father;
            cmd.Parameters.Add("@NationalCode", SqlDbType.NVarChar).Value = codemelli;
            cmd.Parameters.Add("@BirthDate", SqlDbType.NVarChar).Value = bdate;
            cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = sex;
            cmd.Parameters.Add("@Phone", SqlDbType.Int).Value = tell;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
            cmd.Parameters.Add("@MadrakCode", SqlDbType.Int).Value = madrak;
            cmd.Parameters.Add("@BProvinceCode", SqlDbType.BigInt).Value = bprovince;
            cmd.Parameters.Add("@BCityCode", SqlDbType.BigInt).Value = bcity;
            cmd.Parameters.Add("@BPartCode", SqlDbType.BigInt).Value = bpart;
            cmd.Parameters.Add("@BVillageCode", SqlDbType.BigInt).Value = bvillage;
            cmd.Parameters.Add("@LProvinceCode", SqlDbType.BigInt).Value = lprovince;
            cmd.Parameters.Add("@LCityCode", SqlDbType.BigInt).Value = lcity;
            cmd.Parameters.Add("@LPartCode", SqlDbType.BigInt).Value = lpart;
            cmd.Parameters.Add("@LVillageCode", SqlDbType.BigInt).Value = lvillage;
            read = cmd.ExecuteReader();
            read.Close();
            conn.Close();

        }
    }
}

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
  public  class Vehicle
    {

        public DataSet Vehicle_GetList()
        {
            Connectionclass cs = new Connectionclass();
            string connectionstring = cs.Select_connection();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("Vehicle_GetList", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "Vehicle");
            return ds;
        }
    }
}

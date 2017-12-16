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
   public  class Connectionclass
    {
      public   string Select_connection()
        {
            string connectionstring = @"Data Source=.;Initial Catalog=saledb;Integrated Security=True";

            return connectionstring;
        }

    }
}

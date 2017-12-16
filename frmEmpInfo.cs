using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using layer2_bussiness;


namespace layer1_presentation
{
    public partial class frmEmpInfo : Form
    {
        string connectionstring = @"Data Source=.;Initial Catalog=saledb;Integrated Security=True";

        public frmEmpInfo()
        {
            InitializeComponent();

            txtBDate.Enabled = false;
            txtFamily.Enabled = false;
            txtFather.Enabled = false;
            txtMelli.Enabled = false;
            txtName.Enabled = false;
            txtPass.Enabled = false;
            txtTell.Enabled = false;
            TxtUsername.Enabled = false;
            cmbBCity.Enabled = false;
            cmbbPart.Enabled = false;
            cmbBProvince.Enabled = false;
            cmbbvillage.Enabled = false;
            cmbLcity.Enabled = false;
            cmbLPart.Enabled = false;
            cmbLProvince.Enabled = false;
            cmbLVillage.Enabled = false;
            cmbMadrak.Enabled = false;
            cmbSex.Enabled = false;
            //linqclassempDataContext dc = new linqclassempDataContext();
            //var q = dc.Employee_GetDetail_By_ID2(Convert.ToInt32(1));
            SqlConnection con = new SqlConnection(connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("Employee_GetDetail_By_ID", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id",SqlDbType.Int).Value=Convert.ToInt32("1");
            da.SelectCommand.Parameters.Add("@message", SqlDbType.NVarChar).Value = "";
            DataSet ds = new DataSet();
            da.Fill(ds,"Employee");
            DataTable dt=new DataTable();
            dt = ds.Tables["Employee"];
            //--------------------------------
            txtName.Text = dt.Rows[0][1].ToString();
            txtFamily.Text = dt.Rows[0][2].ToString();
            txtFather.Text = dt.Rows[0][3].ToString();
            TxtUsername.Text = dt.Rows[0][4].ToString();
            txtPass.Text = dt.Rows[0][5].ToString();
            txtMelli.Text = dt.Rows[0][6].ToString();
            txtBDate.Text = dt.Rows[0][7].ToString();
            cmbSex.Text= dt.Rows[0][8].ToString();
            txtTell.Text = dt.Rows[0][9].ToString();
            //-
            //-
            cmbBCity.Text = dt.Rows[0][12].ToString();
            cmbBProvince.Text = dt.Rows[0][13].ToString();
            cmbbPart.Text = dt.Rows[0][14].ToString();
            cmbbvillage.Text = dt.Rows[0][15].ToString();
            cmbLcity.Text = dt.Rows[0][12].ToString();
            cmbLProvince.Text = dt.Rows[0][13].ToString();
            cmbLPart.Text = dt.Rows[0][14].ToString();
            cmbLVillage.Text = dt.Rows[0][15].ToString();
            cmbMadrak.Text = dt.Rows[0][16].ToString(); 


        }



    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtBDate.Enabled = true;
            txtFamily.Enabled = true;
            txtFather.Enabled = true;
            txtMelli.Enabled = true;
            txtName.Enabled = true;
            txtPass.Enabled = true;
            txtTell.Enabled = true;
            TxtUsername.Enabled = false;
            cmbBCity.Enabled = true;
            cmbbPart.Enabled = true;
            cmbBProvince.Enabled = true;
            cmbbvillage.Enabled = true;
            cmbLcity.Enabled = true;
            cmbLPart.Enabled = true;
            cmbLProvince.Enabled = true;
            cmbLVillage.Enabled = true;
            cmbMadrak.Enabled = true;
            cmbSex.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bussinessclass bc = new bussinessclass();
            bc.Emp_update(Convert.ToInt64(1), txtName.Text, txtFamily.Text, txtFather.Text, TxtUsername.Text, txtPass.Text, txtMelli.Text,
                txtBDate.Text,Convert.ToInt64(1), Convert.ToInt64(1) ,Convert.ToInt64(1), Convert.ToInt64(1), cmbSex.Text,
                Convert.ToInt64(1), Convert.ToInt64(1),Convert.ToInt64(1), Convert.ToInt64(1),Convert.ToInt32(1),Convert.ToInt32( txtTell.Text),0);
        
        }
    }
}

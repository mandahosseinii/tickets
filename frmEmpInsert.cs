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
    public partial class frmEmpInsert : Form
    {
       

        public frmEmpInsert()
        {
            InitializeComponent();
            bussinessclass bc = new bussinessclass();
            DataSet ds1 = new DataSet();
            ds1 = bc.Emp_GetList();
            dgview.DataSource = ds1;
            dgview.DataMember = "Employee";
            DataSet dscity = new DataSet();
            dscity = bc.City_GetList();
            cmbBCity.DataSource = dscity.Tables["City"];
            cmbBCity.DisplayMember = "Name";
            cmbBCity.ValueMember = "Code";
            cmbLcity.DataSource = dscity.Tables["City"];
            cmbLcity.DisplayMember = "Name";
            cmbLcity.ValueMember = "Code";
            cmbBProvince.DisplayMember = "فارس";
            cmbBProvince.ValueMember = "1";
            cmbLProvince.DisplayMember = "فارس";
            cmbLProvince.ValueMember = "1";
            cmbLPart.DisplayMember = "مرکزی";
            cmbbPart.ValueMember = "1";
            cmbLPart.DisplayMember = "مرکزی";
            cmbLPart.ValueMember = "1";
            cmbbvillage.DisplayMember = "مرکزی";
            cmbbvillage.ValueMember = "1";
            cmbLVillage.DisplayMember = "مرکزی";
            cmbLVillage.ValueMember = "1";


            //--------------------------------
           


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bussinessclass bc = new bussinessclass();
            bc.Emp_insert(txtName.Text, txtFamily.Text, txtFather.Text,txtusername.Text, txtpassword.Text, txtMelli.Text,
                          txtBDate.Text, Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), cmbSex.Text,
                          Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt32(1), Convert.ToInt32(txtTell.Text), 0);
            var q = bc.Customer_GetList();
            dgview.DataSource = q;

        }
    }
}

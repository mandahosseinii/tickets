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
    public partial class frmCustomerInfo : Form
    {
       

        public frmCustomerInfo()
        {
            InitializeComponent();
            bussinessclass bc = new bussinessclass();
            DataSet ds1 = new DataSet();
            ds1 = bc.Customer_GetList();
            dgview.DataSource = ds1;
            dgview.DataMember = "Customer";
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



    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bussinessclass bc = new bussinessclass();
            bc.Customer_update(Convert.ToInt64(txtid.Text), txtName.Text, txtFamily.Text, txtFather.Text, txtMelli.Text,txtBDate.Text, Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), cmbSex.Text, Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt32(1), Convert.ToInt32(txtTell.Text), 0);
            var q = bc.Customer_GetList();
            dgview.DataSource = q;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            txtid.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
            txtFamily.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
            txtFather.Text = dgview.SelectedRows[0].Cells[3].Value.ToString();
            txtMelli.Text = dgview.SelectedRows[0].Cells[4].Value.ToString();
            txtBDate.Text = dgview.SelectedRows[0].Cells[5].Value.ToString();
            cmbSex.Text = dgview.SelectedRows[0].Cells[10].Value.ToString();
            txtTell.Text = dgview.SelectedRows[0].Cells[16].Value.ToString();
            cmbMadrak.Text = dgview.SelectedRows[0].Cells[15].Value.ToString();
            //-
            //-
            cmbBProvince.DisplayMember = "فارس";
            cmbBProvince.Text = "فارس";
            cmbBProvince.ValueMember = "1";
            cmbLProvince.DisplayMember = "فارس";
            cmbLProvince.Text = "فارس";
            cmbLProvince.ValueMember = "1";
            cmbbPart.DisplayMember = "مرکزی";
            cmbbPart.Text = "مرکزی";
            cmbbPart.ValueMember = "1";
            cmbLPart.DisplayMember = "مرکزی";
            cmbLPart.Text = "مرکزی";
            cmbLPart.ValueMember = "1";
            cmbbvillage.DisplayMember = "مرکزی";
            cmbbvillage.Text = "مرکزی";
            cmbbvillage.ValueMember = "1";
            cmbLVillage.DisplayMember = "مرکزی";
            cmbLVillage.Text = "مرکزی";
            cmbLVillage.ValueMember = "1";

            //cmbBCity.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            //cmbBProvince.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            //cmbbPart.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            //cmbbvillage.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            //cmbLcity.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            //cmbLProvince.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            //cmbLPart.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            //cmbLVillage.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            //cmbMadrak.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bussinessclass bc = new bussinessclass();
            bc.Customer_insert( txtName.Text, txtFamily.Text, txtFather.Text, txtMelli.Text, txtBDate.Text, Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), cmbSex.Text, Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt64(1), Convert.ToInt32(1), Convert.ToInt32(txtTell.Text), 0);
            var q = bc.Customer_GetList();
            dgview.DataSource = q;

        }
    }
}

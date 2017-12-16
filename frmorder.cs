using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using layer2_bussiness;



namespace layer1_presentation
{
    public partial class frmCusOrder : Form
    {

        public frmCusOrder()
        {
            InitializeComponent();
            bussinessclass bc = new bussinessclass();
            DataSet ds = new DataSet();
            ds = bc.Orders_GetList();
            dgview.DataSource = ds;
            dgview.DataMember = "Orders";
            DataSet dscity = new DataSet();
            dscity = bc.City_GetList();
            cmbbeginning.DataSource = dscity.Tables["City"];
            cmbbeginning.DisplayMember = "Name";
            cmbbeginning.ValueMember = "Code";
            cmbdestination.DataSource = dscity.Tables["City"];
            cmbdestination.DisplayMember = "Name";
            cmbdestination.ValueMember = "Code";
            DataSet dsvehicle = new DataSet();
            dsvehicle = bc.Vehicle_GetList();
            cmbvehicle.DataSource = dsvehicle.Tables[0];
            cmbvehicle.DisplayMember = "Title";
            cmbvehicle.ValueMember = "ID";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            bussinessclass bc = new bussinessclass();
            DataSet dscity = new DataSet();
            DataSet dscity1 = new DataSet();
            dscity = bc.City_GetList();
            dscity1 = bc.City_GetList();
            txtid1.Text= dgview.SelectedRows[0].Cells[0].Value.ToString();
            txttitle1.Text= dgview.SelectedRows[0].Cells[1].Value.ToString();
            txtdescription.Text= dgview.SelectedRows[0].Cells[2].Value.ToString(); 
            cmbvehicle.Text= dgview.SelectedRows[0].Cells[4].Value.ToString();
            txtprice.Text= dgview.SelectedRows[0].Cells[5].Value.ToString();
            txtmaxnumber.Text= dgview.SelectedRows[0].Cells[6].Value.ToString();
            string tbeginning="";
            int vbeginning;
           for
                (int i=0;i<Convert.ToInt32(dscity.Tables[0].Rows.Count); i++)
            {
                 vbeginning = Convert.ToInt32(dgview.SelectedRows[0].Cells[7].Value.ToString());
                if (vbeginning== Convert.ToInt32(dscity.Tables[0].Rows[i]["Code"]))
                {
                    tbeginning = dscity.Tables[0].Rows[i]["Name"].ToString();
                }
            }
            cmbbeginning.Text = tbeginning;


            string tdestination = "";
            int vdestination;
            for
                 (int i = 0; i < Convert.ToInt32(dscity1.Tables[0].Rows.Count); i++)
            {
                vdestination = Convert.ToInt32(dgview.SelectedRows[0].Cells[8].Value.ToString());
                if (vdestination == Convert.ToInt32(dscity1.Tables[0].Rows[i]["Code"]))
                {
                    tdestination = dscity1.Tables[0].Rows[i]["Name"].ToString();
                }
            }
            cmbdestination.Text = tdestination;

            txtdate.Text= dgview.SelectedRows[0].Cells[9].Value.ToString();
            txttime.Text= dgview.SelectedRows[0].Cells[10].Value.ToString();
            txtstatus.Text= dgview.SelectedRows[0].Cells[11].Value.ToString();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bussinessclass bc = new bussinessclass();
           // cmbvehicle.SelectedValue = 1;
            bc.Orders_update(Convert.ToInt32(txtid1.Text), txttitle1.Text, txtdescription.Text, Convert.ToInt32(cmbvehicle.SelectedValue), Convert.ToInt32(txtprice.Text), Convert.ToInt32(txtmaxnumber.Text), Convert.ToInt32(cmbbeginning.SelectedValue), Convert.ToInt32(cmbdestination.SelectedValue),txtdate.Text,txttime.Text, Convert.ToInt32(txtstatus.Text));
            var q = bc.Orders_GetList();
            dgview.DataSource = q;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            int indx = dgview.SelectedRows[0].Index;

            bussinessclass bc = new bussinessclass();
            bc.Orders_delete(Convert.ToInt32(dgview.SelectedRows[0].Cells[0].Value));
            var q = bc.Orders_GetList();
            dgview.DataSource = q;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            bussinessclass bc = new bussinessclass();
            bc.Orders_insert(Convert.ToInt32(txtId.Text), txttitle.Text, txtDesc.Text, Convert.ToInt32(cmbvehicle.SelectedValue), Convert.ToInt32(txtprice.Text), Convert.ToInt32(txtmaxnumber.Text), Convert.ToInt32(cmbbeginning.SelectedValue), Convert.ToInt32(cmbdestination.SelectedValue), txtdate.Text, txttime.Text, Convert.ToInt32(txtstatus.Text));
            var q = bc.Orders_GetList();
            dgview.DataSource = q;
          
        }

     
    }
}

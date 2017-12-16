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
    public partial class frmEmpOrder : Form
    {
        int customerid;
        int employeeid;

        public frmEmpOrder( int type)
        {
            InitializeComponent();
            bussinessclass bc = new bussinessclass();
            DataSet ds = new DataSet();
            ds = bc.Orders_GetList_By_Type(type);
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
            employeeid = 1;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            bussinessclass bc = new bussinessclass();
            DataSet dscity = new DataSet();
            DataSet dscity1 = new DataSet();
            dscity = bc.City_GetList();
            dscity1 = bc.City_GetList();
            txtid1.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
            txttitle1.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
            txtdescription.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
            cmbvehicle.Text = dgview.SelectedRows[0].Cells[4].Value.ToString();
            txtprice.Text = dgview.SelectedRows[0].Cells[5].Value.ToString();
            txtmaxnumber.Text = dgview.SelectedRows[0].Cells[6].Value.ToString();
            string tbeginning = "";
            int vbeginning;
            for
                 (int i = 0; i < Convert.ToInt32(dscity.Tables[0].Rows.Count); i++)
            {
                vbeginning = Convert.ToInt32(dgview.SelectedRows[0].Cells[7].Value.ToString());
                if (vbeginning == Convert.ToInt32(dscity.Tables[0].Rows[i]["Code"]))
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

            txtdate.Text = dgview.SelectedRows[0].Cells[9].Value.ToString();
            txttime.Text = dgview.SelectedRows[0].Cells[10].Value.ToString();
            txtstatus1.Text = dgview.SelectedRows[0].Cells[11].Value.ToString();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            customerid = Convert.ToInt32(txtcuscode.Text);
            bussinessclass bc = new bussinessclass();
            DataSet dsCustomer = new DataSet();
            dsCustomer=bc.Select_Customer(Convert.ToInt64(txtcuscode.Text));
            lblname.Text= dsCustomer.Tables[0].Rows[0]["FirstName"].ToString();
            lblfamily.Text = dsCustomer.Tables[0].Rows[0]["LastName"].ToString();
            lblnational.Text = dsCustomer.Tables[0].Rows[0]["NationalCode"].ToString();
            lblsex.Text = dsCustomer.Tables[0].Rows[0]["Gender"].ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bussinessclass bc = new bussinessclass();
            bc.OrderHistoryDetails_insert(employeeid, Convert.ToInt32(txtid1.Text), customerid, Convert.ToInt32(txtstatus1.Text));
            MessageBox.Show("بلیط شما با موفقیت ثبت گردید.");
        }
    }
}

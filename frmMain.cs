using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace layer1_presentation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.ticket_image;
        }

      

        private void MEmpOrder_Click(object sender, EventArgs e)
        {
            frmCusOrder frm = new frmCusOrder();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void MEmpHistA_Click(object sender, EventArgs e)
        {
            frmEmpOrder frm = new frmEmpOrder(1);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void MEmpHistT_Click(object sender, EventArgs e)
        {
            frmEmpOrder frm = new frmEmpOrder(2);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void MEmpHistB_Click(object sender, EventArgs e)
        {
            frmEmpOrder frm = new frmEmpOrder(3);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void MCustomerInfo_Click(object sender, EventArgs e)
        {
            frmCustomerInfo frm = new frmCustomerInfo();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void MEmpInfo_Click(object sender, EventArgs e)
        {
            frmEmpInfo frm = new frmEmpInfo();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void MEmpnew_Click(object sender, EventArgs e)
        {
            frmEmpInsert frm = new frmEmpInsert();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
    }
}

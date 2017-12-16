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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtusername.Text == "1" && txtpass.Text == "1" )
            {
                frmMain frm = new frmMain();
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
               // this.Close();
            }
        }
    }
}

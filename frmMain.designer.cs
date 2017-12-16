namespace layer1_presentation
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MnEmp = new System.Windows.Forms.MenuStrip();
            this.MEmpInfo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MEmpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MEmpnew = new System.Windows.Forms.ToolStripMenuItem();
            this.MCustomerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MEmpOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.MEmpHistA = new System.Windows.Forms.ToolStripMenuItem();
            this.MEmpHistT = new System.Windows.Forms.ToolStripMenuItem();
            this.MEmpHistB = new System.Windows.Forms.ToolStripMenuItem();
            this.MnEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnEmp
            // 
            this.MnEmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MEmpInfo1,
            this.MCustomerInfo,
            this.MEmpOrder,
            this.MEmpHistA,
            this.MEmpHistT,
            this.MEmpHistB});
            this.MnEmp.Location = new System.Drawing.Point(0, 0);
            this.MnEmp.Name = "MnEmp";
            this.MnEmp.Size = new System.Drawing.Size(996, 24);
            this.MnEmp.TabIndex = 1;
            this.MnEmp.Text = "menuStrip1";
            // 
            // MEmpInfo1
            // 
            this.MEmpInfo1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MEmpInfo,
            this.MEmpnew});
            this.MEmpInfo1.Name = "MEmpInfo1";
            this.MEmpInfo1.Size = new System.Drawing.Size(86, 20);
            this.MEmpInfo1.Text = "اطلاعات کاربر";
            // 
            // MEmpInfo
            // 
            this.MEmpInfo.Name = "MEmpInfo";
            this.MEmpInfo.Size = new System.Drawing.Size(154, 22);
            this.MEmpInfo.Text = "ویرایش اطلاعات";
            this.MEmpInfo.Click += new System.EventHandler(this.MEmpInfo_Click);
            // 
            // MEmpnew
            // 
            this.MEmpnew.Name = "MEmpnew";
            this.MEmpnew.Size = new System.Drawing.Size(154, 22);
            this.MEmpnew.Text = "کاربر جدید";
            this.MEmpnew.Click += new System.EventHandler(this.MEmpnew_Click);
            // 
            // MCustomerInfo
            // 
            this.MCustomerInfo.Name = "MCustomerInfo";
            this.MCustomerInfo.Size = new System.Drawing.Size(97, 20);
            this.MCustomerInfo.Text = "اطلاعات مشتری";
            this.MCustomerInfo.Click += new System.EventHandler(this.MCustomerInfo_Click);
            // 
            // MEmpOrder
            // 
            this.MEmpOrder.Name = "MEmpOrder";
            this.MEmpOrder.Size = new System.Drawing.Size(54, 20);
            this.MEmpOrder.Text = "سفر ها";
            this.MEmpOrder.Click += new System.EventHandler(this.MEmpOrder_Click);
            // 
            // MEmpHistA
            // 
            this.MEmpHistA.Name = "MEmpHistA";
            this.MEmpHistA.Size = new System.Drawing.Size(79, 20);
            this.MEmpHistA.Text = "بلیط هواپیما";
            this.MEmpHistA.Click += new System.EventHandler(this.MEmpHistA_Click);
            // 
            // MEmpHistT
            // 
            this.MEmpHistT.Name = "MEmpHistT";
            this.MEmpHistT.Size = new System.Drawing.Size(68, 20);
            this.MEmpHistT.Text = "بلیط قطار";
            this.MEmpHistT.Click += new System.EventHandler(this.MEmpHistT_Click);
            // 
            // MEmpHistB
            // 
            this.MEmpHistB.Name = "MEmpHistB";
            this.MEmpHistB.Size = new System.Drawing.Size(81, 20);
            this.MEmpHistB.Text = "بلیط اتوبوس";
            this.MEmpHistB.Click += new System.EventHandler(this.MEmpHistB_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::layer1_presentation.Properties.Resources.ticket_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 552);
            this.Controls.Add(this.MnEmp);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnEmp;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سیستم کاریابی آنلاین";
            this.MnEmp.ResumeLayout(false);
            this.MnEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnEmp;
        private System.Windows.Forms.ToolStripMenuItem MEmpInfo1;
        private System.Windows.Forms.ToolStripMenuItem MEmpOrder;
        private System.Windows.Forms.ToolStripMenuItem MEmpHistA;
        private System.Windows.Forms.ToolStripMenuItem MEmpHistT;
        private System.Windows.Forms.ToolStripMenuItem MEmpHistB;
        private System.Windows.Forms.ToolStripMenuItem MCustomerInfo;
        private System.Windows.Forms.ToolStripMenuItem MEmpInfo;
        private System.Windows.Forms.ToolStripMenuItem MEmpnew;
    }
}
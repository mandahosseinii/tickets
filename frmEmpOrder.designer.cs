namespace layer1_presentation
{
    partial class frmEmpOrder
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
            this.dgview = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbbeginning = new System.Windows.Forms.ComboBox();
            this.cmbdestination = new System.Windows.Forms.ComboBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.cmbvehicle = new System.Windows.Forms.ComboBox();
            this.txtmaxnumber = new System.Windows.Forms.TextBox();
            this.txtstatus1 = new System.Windows.Forms.TextBox();
            this.txttitle1 = new System.Windows.Forms.TextBox();
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblnational = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtcuscode = new System.Windows.Forms.TextBox();
            this.lblfamily = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgview
            // 
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(12, 271);
            this.dgview.Name = "dgview";
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview.Size = new System.Drawing.Size(913, 193);
            this.dgview.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(365, 470);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "مشاهده";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttime);
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbbeginning);
            this.groupBox2.Controls.Add(this.cmbdestination);
            this.groupBox2.Controls.Add(this.txtdescription);
            this.groupBox2.Controls.Add(this.cmbvehicle);
            this.groupBox2.Controls.Add(this.txtmaxnumber);
            this.groupBox2.Controls.Add(this.txtstatus1);
            this.groupBox2.Controls.Add(this.txttitle1);
            this.groupBox2.Controls.Add(this.txtid1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(913, 171);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات سفر:";
            // 
            // txttime
            // 
            this.txttime.Enabled = false;
            this.txttime.Location = new System.Drawing.Point(309, 50);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(130, 20);
            this.txttime.TabIndex = 32;
            this.txttime.Text = "16;24";
            this.txttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdate
            // 
            this.txtdate.Enabled = false;
            this.txtdate.Location = new System.Drawing.Point(521, 47);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(130, 20);
            this.txtdate.TabIndex = 31;
            this.txtdate.Text = "1396/08/26";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(445, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "زمان:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(658, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "تاریخ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "قیمت:";
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(309, 18);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(131, 20);
            this.txtprice.TabIndex = 27;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(862, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "مبدا:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(660, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "مقصد:";
            // 
            // cmbbeginning
            // 
            this.cmbbeginning.Enabled = false;
            this.cmbbeginning.FormattingEnabled = true;
            this.cmbbeginning.Location = new System.Drawing.Point(726, 75);
            this.cmbbeginning.Name = "cmbbeginning";
            this.cmbbeginning.Size = new System.Drawing.Size(130, 21);
            this.cmbbeginning.TabIndex = 24;
            // 
            // cmbdestination
            // 
            this.cmbdestination.Enabled = false;
            this.cmbdestination.FormattingEnabled = true;
            this.cmbdestination.Location = new System.Drawing.Point(521, 75);
            this.cmbdestination.Name = "cmbdestination";
            this.cmbdestination.Size = new System.Drawing.Size(132, 21);
            this.cmbdestination.TabIndex = 23;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(71, 113);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(786, 39);
            this.txtdescription.TabIndex = 22;
            // 
            // cmbvehicle
            // 
            this.cmbvehicle.Enabled = false;
            this.cmbvehicle.FormattingEnabled = true;
            this.cmbvehicle.Location = new System.Drawing.Point(727, 45);
            this.cmbvehicle.Name = "cmbvehicle";
            this.cmbvehicle.Size = new System.Drawing.Size(130, 21);
            this.cmbvehicle.TabIndex = 21;
            // 
            // txtmaxnumber
            // 
            this.txtmaxnumber.Enabled = false;
            this.txtmaxnumber.Location = new System.Drawing.Point(71, 18);
            this.txtmaxnumber.Name = "txtmaxnumber";
            this.txtmaxnumber.Size = new System.Drawing.Size(131, 20);
            this.txtmaxnumber.TabIndex = 18;
            this.txtmaxnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtstatus1
            // 
            this.txtstatus1.Enabled = false;
            this.txtstatus1.Location = new System.Drawing.Point(70, 50);
            this.txtstatus1.Name = "txtstatus1";
            this.txtstatus1.Size = new System.Drawing.Size(130, 20);
            this.txtstatus1.TabIndex = 17;
            this.txtstatus1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttitle1
            // 
            this.txttitle1.Enabled = false;
            this.txttitle1.Location = new System.Drawing.Point(522, 19);
            this.txttitle1.Name = "txttitle1";
            this.txttitle1.Size = new System.Drawing.Size(131, 20);
            this.txttitle1.TabIndex = 16;
            this.txttitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtid1
            // 
            this.txtid1.Enabled = false;
            this.txtid1.Location = new System.Drawing.Point(727, 19);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(130, 20);
            this.txtid1.TabIndex = 15;
            this.txtid1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(861, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "توضیحات:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(863, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "شرکت:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(207, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "تعداد صندلی:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(205, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "وضعیت:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(658, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "عنوان:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(862, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "کد:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsex);
            this.groupBox1.Controls.Add(this.lblnational);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtcuscode);
            this.groupBox1.Controls.Add(this.lblfamily);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مسافر";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(56, 31);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(28, 13);
            this.lblsex.TabIndex = 10;
            this.lblsex.Text = ".......";
            this.lblsex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnational
            // 
            this.lblnational.AutoSize = true;
            this.lblnational.Location = new System.Drawing.Point(194, 31);
            this.lblnational.Name = "lblnational";
            this.lblnational.Size = new System.Drawing.Size(28, 13);
            this.lblnational.TabIndex = 9;
            this.lblnational.Text = ".......";
            this.lblnational.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(657, 26);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "جستجو";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtcuscode
            // 
            this.txtcuscode.Location = new System.Drawing.Point(738, 28);
            this.txtcuscode.Name = "txtcuscode";
            this.txtcuscode.Size = new System.Drawing.Size(100, 20);
            this.txtcuscode.TabIndex = 7;
            // 
            // lblfamily
            // 
            this.lblfamily.AutoSize = true;
            this.lblfamily.Location = new System.Drawing.Point(386, 31);
            this.lblfamily.Name = "lblfamily";
            this.lblfamily.Size = new System.Drawing.Size(28, 13);
            this.lblfamily.TabIndex = 6;
            this.lblfamily.Text = ".......";
            this.lblfamily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(562, 31);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(28, 13);
            this.lblname.TabIndex = 5;
            this.lblname.Text = ".......";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "کد ملی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "جنسیت:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام خانوادگی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد مشتری:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(452, 470);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "ثبت بلیط";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmEmpOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 505);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgview);
            this.Name = "frmEmpOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmEmpOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbbeginning;
        private System.Windows.Forms.ComboBox cmbdestination;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.ComboBox cmbvehicle;
        private System.Windows.Forms.TextBox txtmaxnumber;
        private System.Windows.Forms.TextBox txtstatus1;
        private System.Windows.Forms.TextBox txttitle1;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblnational;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtcuscode;
        private System.Windows.Forms.Label lblfamily;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
    }
}
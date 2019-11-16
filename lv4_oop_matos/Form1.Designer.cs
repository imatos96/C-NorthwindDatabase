namespace lv4_oop_matos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cBoShipper = new System.Windows.Forms.ComboBox();
            this.cBoCustomer = new System.Windows.Forms.ComboBox();
            this.cBoEmpyee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rBInsert = new System.Windows.Forms.RadioButton();
            this.rBUpdate = new System.Windows.Forms.RadioButton();
            this.rBDelete = new System.Windows.Forms.RadioButton();
            this.brnChooseOption = new System.Windows.Forms.Button();
            this.btnRemoveFilters = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtShipZIP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShipAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShipDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtShipId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtReqDate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtOrdDate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(13, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 606);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders:";
            // 
            // cBoShipper
            // 
            this.cBoShipper.FormattingEnabled = true;
            this.cBoShipper.Location = new System.Drawing.Point(28, 686);
            this.cBoShipper.Margin = new System.Windows.Forms.Padding(4);
            this.cBoShipper.Name = "cBoShipper";
            this.cBoShipper.Size = new System.Drawing.Size(160, 24);
            this.cBoShipper.TabIndex = 2;
            this.cBoShipper.SelectedIndexChanged += new System.EventHandler(this.cBoShipper_SelectedIndexChanged);
            // 
            // cBoCustomer
            // 
            this.cBoCustomer.FormattingEnabled = true;
            this.cBoCustomer.Location = new System.Drawing.Point(224, 686);
            this.cBoCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cBoCustomer.Name = "cBoCustomer";
            this.cBoCustomer.Size = new System.Drawing.Size(160, 24);
            this.cBoCustomer.TabIndex = 3;
            this.cBoCustomer.SelectedIndexChanged += new System.EventHandler(this.cBoCustomer_SelectedIndexChanged);
            // 
            // cBoEmpyee
            // 
            this.cBoEmpyee.FormattingEnabled = true;
            this.cBoEmpyee.Location = new System.Drawing.Point(423, 686);
            this.cBoEmpyee.Margin = new System.Windows.Forms.Padding(4);
            this.cBoEmpyee.Name = "cBoEmpyee";
            this.cBoEmpyee.Size = new System.Drawing.Size(160, 24);
            this.cBoEmpyee.TabIndex = 4;
            this.cBoEmpyee.SelectedIndexChanged += new System.EventHandler(this.cBoEmpyee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 666);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose Shipper";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 665);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 665);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose Employee";
            // 
            // rBInsert
            // 
            this.rBInsert.AutoSize = true;
            this.rBInsert.Location = new System.Drawing.Point(669, 665);
            this.rBInsert.Margin = new System.Windows.Forms.Padding(4);
            this.rBInsert.Name = "rBInsert";
            this.rBInsert.Size = new System.Drawing.Size(64, 21);
            this.rBInsert.TabIndex = 8;
            this.rBInsert.TabStop = true;
            this.rBInsert.Text = "Insert";
            this.rBInsert.UseVisualStyleBackColor = true;
            this.rBInsert.CheckedChanged += new System.EventHandler(this.rBInsert_CheckedChanged);
            // 
            // rBUpdate
            // 
            this.rBUpdate.AutoSize = true;
            this.rBUpdate.Location = new System.Drawing.Point(669, 694);
            this.rBUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.rBUpdate.Name = "rBUpdate";
            this.rBUpdate.Size = new System.Drawing.Size(75, 21);
            this.rBUpdate.TabIndex = 9;
            this.rBUpdate.TabStop = true;
            this.rBUpdate.Text = "Update";
            this.rBUpdate.UseVisualStyleBackColor = true;
            // 
            // rBDelete
            // 
            this.rBDelete.AutoSize = true;
            this.rBDelete.Location = new System.Drawing.Point(669, 722);
            this.rBDelete.Margin = new System.Windows.Forms.Padding(4);
            this.rBDelete.Name = "rBDelete";
            this.rBDelete.Size = new System.Drawing.Size(70, 21);
            this.rBDelete.TabIndex = 10;
            this.rBDelete.TabStop = true;
            this.rBDelete.Text = "Delete";
            this.rBDelete.UseVisualStyleBackColor = true;
            // 
            // brnChooseOption
            // 
            this.brnChooseOption.Location = new System.Drawing.Point(764, 673);
            this.brnChooseOption.Margin = new System.Windows.Forms.Padding(4);
            this.brnChooseOption.Name = "brnChooseOption";
            this.brnChooseOption.Size = new System.Drawing.Size(100, 49);
            this.brnChooseOption.TabIndex = 11;
            this.brnChooseOption.Text = "Choose action";
            this.brnChooseOption.UseVisualStyleBackColor = true;
            this.brnChooseOption.Click += new System.EventHandler(this.brnChooseOption_Click);
            // 
            // btnRemoveFilters
            // 
            this.btnRemoveFilters.Location = new System.Drawing.Point(224, 736);
            this.btnRemoveFilters.Name = "btnRemoveFilters";
            this.btnRemoveFilters.Size = new System.Drawing.Size(140, 31);
            this.btnRemoveFilters.TabIndex = 15;
            this.btnRemoveFilters.Text = "Remove filters";
            this.btnRemoveFilters.UseVisualStyleBackColor = true;
            this.btnRemoveFilters.Click += new System.EventHandler(this.btnRemoveFilters_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(937, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "OrderID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1005, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 17);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "ID number";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(995, 707);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(210, 22);
            this.txtShipCountry.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(901, 707);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 76;
            this.label13.Text = "Ship Country";
            // 
            // txtShipZIP
            // 
            this.txtShipZIP.Location = new System.Drawing.Point(995, 655);
            this.txtShipZIP.Name = "txtShipZIP";
            this.txtShipZIP.Size = new System.Drawing.Size(210, 22);
            this.txtShipZIP.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(895, 658);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 74;
            this.label12.Text = "Ship ZIP Code";
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.Location = new System.Drawing.Point(995, 607);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(210, 22);
            this.txtShipRegion.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(904, 610);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 72;
            this.label11.Text = "Ship Region";
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(995, 559);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(210, 22);
            this.txtShipCity.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(923, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Ship City";
            // 
            // txtShipAdd
            // 
            this.txtShipAdd.Location = new System.Drawing.Point(995, 509);
            this.txtShipAdd.Name = "txtShipAdd";
            this.txtShipAdd.Size = new System.Drawing.Size(210, 22);
            this.txtShipAdd.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(901, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "Ship Address";
            // 
            // txtShipDate
            // 
            this.txtShipDate.Location = new System.Drawing.Point(995, 304);
            this.txtShipDate.Name = "txtShipDate";
            this.txtShipDate.Size = new System.Drawing.Size(210, 22);
            this.txtShipDate.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(899, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 17);
            this.label14.TabIndex = 66;
            this.label14.Text = "Shipped Date";
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(995, 456);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(210, 22);
            this.txtShipName.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(912, 456);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 64;
            this.label15.Text = "Ship Name";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(995, 404);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(210, 22);
            this.txtFreight.TabIndex = 63;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(937, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 62;
            this.label16.Text = "Freight";
            // 
            // txtShipId
            // 
            this.txtShipId.Location = new System.Drawing.Point(995, 355);
            this.txtShipId.Name = "txtShipId";
            this.txtShipId.Size = new System.Drawing.Size(210, 22);
            this.txtShipId.TabIndex = 61;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(919, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 60;
            this.label17.Text = "ShipperID";
            // 
            // txtReqDate
            // 
            this.txtReqDate.Location = new System.Drawing.Point(995, 259);
            this.txtReqDate.Name = "txtReqDate";
            this.txtReqDate.Size = new System.Drawing.Size(210, 22);
            this.txtReqDate.TabIndex = 59;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(893, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 17);
            this.label18.TabIndex = 58;
            this.label18.Text = "Required Date";
            // 
            // txtOrdDate
            // 
            this.txtOrdDate.Location = new System.Drawing.Point(995, 219);
            this.txtOrdDate.Name = "txtOrdDate";
            this.txtOrdDate.Size = new System.Drawing.Size(210, 22);
            this.txtOrdDate.TabIndex = 57;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(914, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 17);
            this.label19.TabIndex = 56;
            this.label19.Text = "Order Date";
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(995, 174);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(210, 22);
            this.txtEmp.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(906, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 17);
            this.label20.TabIndex = 54;
            this.label20.Text = "EmployeeID";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(995, 126);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(210, 22);
            this.txtCustomer.TabIndex = 53;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(908, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 17);
            this.label21.TabIndex = 52;
            this.label21.Text = "CustomerID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 791);
            this.Controls.Add(this.txtShipCountry);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtShipZIP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtShipRegion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtShipAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtShipDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtShipId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtReqDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtOrdDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemoveFilters);
            this.Controls.Add(this.brnChooseOption);
            this.Controls.Add(this.rBDelete);
            this.Controls.Add(this.rBUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rBInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoEmpyee);
            this.Controls.Add(this.cBoCustomer);
            this.Controls.Add(this.cBoShipper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoCustomer;
        private System.Windows.Forms.ComboBox cBoEmpyee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBInsert;
        private System.Windows.Forms.RadioButton rBUpdate;
        private System.Windows.Forms.RadioButton rBDelete;
        private System.Windows.Forms.Button brnChooseOption;
        private System.Windows.Forms.ComboBox cBoShipper;
        private System.Windows.Forms.Button btnRemoveFilters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtShipZIP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtShipRegion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtShipAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShipDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtShipId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtReqDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtOrdDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label21;
    }
}


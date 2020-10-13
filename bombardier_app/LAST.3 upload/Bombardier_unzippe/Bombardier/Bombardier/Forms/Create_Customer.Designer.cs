namespace Bombardier
{
    partial class Create_Customer
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
            this.lblCreateCust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutoCustID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.aircraft_list = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAircraft = new System.Windows.Forms.Label();
            this.btnNxtSub = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtShipZip = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtShipAdd = new System.Windows.Forms.TextBox();
            this.chkboxSameShipAdd = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBillAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillZipCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBillCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpShipAdd = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBillAdd = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.contact_txtbx = new System.Windows.Forms.TextBox();
            this.mail_txtbx = new System.Windows.Forms.TextBox();
            this.phone_txtbx = new System.Windows.Forms.TextBox();
            this.custBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpShipAdd.SuspendLayout();
            this.grpBillAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateCust
            // 
            this.lblCreateCust.BackColor = System.Drawing.Color.Navy;
            this.lblCreateCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateCust.Location = new System.Drawing.Point(52, 60);
            this.lblCreateCust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateCust.Name = "lblCreateCust";
            this.lblCreateCust.Size = new System.Drawing.Size(352, 59);
            this.lblCreateCust.TabIndex = 0;
            this.lblCreateCust.Text = "Create New Customer";
            this.lblCreateCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // txtAutoCustID
            // 
            this.txtAutoCustID.Location = new System.Drawing.Point(622, 72);
            this.txtAutoCustID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutoCustID.Name = "txtAutoCustID";
            this.txtAutoCustID.ReadOnly = true;
            this.txtAutoCustID.Size = new System.Drawing.Size(319, 26);
            this.txtAutoCustID.TabIndex = 2;
            this.txtAutoCustID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(190, 160);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(464, 26);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
            // 
            // lblContactName
            // 
            this.lblContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(51, 160);
            this.lblContactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(159, 34);
            this.lblContactName.TabIndex = 3;
            this.lblContactName.Text = "First Name";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(190, 200);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(464, 26);
            this.txtCompany.TabIndex = 6;
            this.txtCompany.TextChanged += new System.EventHandler(this.txtCompany_TextChanged);
            // 
            // aircraft_list
            // 
            this.aircraft_list.FormattingEnabled = true;
            this.aircraft_list.ItemHeight = 20;
            this.aircraft_list.Location = new System.Drawing.Point(1208, 475);
            this.aircraft_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aircraft_list.Name = "aircraft_list";
            this.aircraft_list.Size = new System.Drawing.Size(469, 344);
            this.aircraft_list.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(707, 827);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 62);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "DISPLAY INFORMATION";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAircraft
            // 
            this.lblAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraft.Location = new System.Drawing.Point(1216, 422);
            this.lblAircraft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(142, 34);
            this.lblAircraft.TabIndex = 24;
            this.lblAircraft.Text = "Aircrafts";
            // 
            // btnNxtSub
            // 
            this.btnNxtSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNxtSub.Location = new System.Drawing.Point(948, 827);
            this.btnNxtSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNxtSub.Name = "btnNxtSub";
            this.btnNxtSub.Size = new System.Drawing.Size(198, 62);
            this.btnNxtSub.TabIndex = 25;
            this.btnNxtSub.Text = "NEXT";
            this.btnNxtSub.UseVisualStyleBackColor = true;
            this.btnNxtSub.Click += new System.EventHandler(this.btnNxtSub_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1022, 160);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(524, 26);
            this.txtLastName.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(784, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 34);
            this.label5.TabIndex = 26;
            this.label5.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(584, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 34);
            this.label10.TabIndex = 34;
            this.label10.Text = "Country";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipCountry.Location = new System.Drawing.Point(704, 115);
            this.txtShipCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(402, 35);
            this.txtShipCountry.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(584, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 34);
            this.label11.TabIndex = 32;
            this.label11.Text = "City";
            // 
            // txtShipCity
            // 
            this.txtShipCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipCity.Location = new System.Drawing.Point(704, 49);
            this.txtShipCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(402, 35);
            this.txtShipCity.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 34);
            this.label12.TabIndex = 30;
            this.label12.Text = "Zip Code";
            // 
            // txtShipZip
            // 
            this.txtShipZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipZip.Location = new System.Drawing.Point(147, 115);
            this.txtShipZip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShipZip.Name = "txtShipZip";
            this.txtShipZip.Size = new System.Drawing.Size(402, 35);
            this.txtShipZip.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 34);
            this.label13.TabIndex = 28;
            this.label13.Text = "Address";
            // 
            // txtShipAdd
            // 
            this.txtShipAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipAdd.Location = new System.Drawing.Point(147, 49);
            this.txtShipAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShipAdd.Name = "txtShipAdd";
            this.txtShipAdd.Size = new System.Drawing.Size(402, 35);
            this.txtShipAdd.TabIndex = 8;
            // 
            // chkboxSameShipAdd
            // 
            this.chkboxSameShipAdd.AutoSize = true;
            this.chkboxSameShipAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxSameShipAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkboxSameShipAdd.Location = new System.Drawing.Point(42, 580);
            this.chkboxSameShipAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkboxSameShipAdd.Name = "chkboxSameShipAdd";
            this.chkboxSameShipAdd.Size = new System.Drawing.Size(257, 29);
            this.chkboxSameShipAdd.TabIndex = 37;
            this.chkboxSameShipAdd.Text = "Same Shipping Details";
            this.chkboxSameShipAdd.UseVisualStyleBackColor = true;
            this.chkboxSameShipAdd.CheckedChanged += new System.EventHandler(this.chkboxSameShipAdd_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 903);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1500, 143);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 34);
            this.label14.TabIndex = 39;
            this.label14.Text = "Company";
            // 
            // txtBillAdd
            // 
            this.txtBillAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAdd.Location = new System.Drawing.Point(147, 55);
            this.txtBillAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillAdd.Name = "txtBillAdd";
            this.txtBillAdd.Size = new System.Drawing.Size(402, 35);
            this.txtBillAdd.TabIndex = 8;
            this.txtBillAdd.TextChanged += new System.EventHandler(this.txtBillAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 34);
            this.label6.TabIndex = 28;
            this.label6.Text = "Address";
            // 
            // txtBillZipCode
            // 
            this.txtBillZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillZipCode.Location = new System.Drawing.Point(147, 122);
            this.txtBillZipCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillZipCode.Name = "txtBillZipCode";
            this.txtBillZipCode.Size = new System.Drawing.Size(402, 35);
            this.txtBillZipCode.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 34);
            this.label7.TabIndex = 30;
            this.label7.Text = "Zip Code";
            // 
            // txtBillCity
            // 
            this.txtBillCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCity.Location = new System.Drawing.Point(704, 55);
            this.txtBillCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillCity.Name = "txtBillCity";
            this.txtBillCity.Size = new System.Drawing.Size(402, 35);
            this.txtBillCity.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 34);
            this.label8.TabIndex = 32;
            this.label8.Text = "City";
            // 
            // txtBillCountry
            // 
            this.txtBillCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCountry.Location = new System.Drawing.Point(704, 122);
            this.txtBillCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillCountry.Name = "txtBillCountry";
            this.txtBillCountry.Size = new System.Drawing.Size(402, 35);
            this.txtBillCountry.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(584, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 34);
            this.label9.TabIndex = 34;
            this.label9.Text = "Country";
            // 
            // grpShipAdd
            // 
            this.grpShipAdd.Controls.Add(this.label10);
            this.grpShipAdd.Controls.Add(this.txtShipCountry);
            this.grpShipAdd.Controls.Add(this.label11);
            this.grpShipAdd.Controls.Add(this.txtShipCity);
            this.grpShipAdd.Controls.Add(this.label12);
            this.grpShipAdd.Controls.Add(this.txtShipZip);
            this.grpShipAdd.Controls.Add(this.label13);
            this.grpShipAdd.Controls.Add(this.txtShipAdd);
            this.grpShipAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShipAdd.Location = new System.Drawing.Point(40, 631);
            this.grpShipAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpShipAdd.Name = "grpShipAdd";
            this.grpShipAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpShipAdd.Size = new System.Drawing.Size(1137, 189);
            this.grpShipAdd.TabIndex = 36;
            this.grpShipAdd.TabStop = false;
            this.grpShipAdd.Text = "Shipping Address";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, -26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company";
            // 
            // grpBillAdd
            // 
            this.grpBillAdd.Controls.Add(this.label9);
            this.grpBillAdd.Controls.Add(this.txtBillCountry);
            this.grpBillAdd.Controls.Add(this.label8);
            this.grpBillAdd.Controls.Add(this.txtBillCity);
            this.grpBillAdd.Controls.Add(this.label7);
            this.grpBillAdd.Controls.Add(this.txtBillZipCode);
            this.grpBillAdd.Controls.Add(this.label6);
            this.grpBillAdd.Controls.Add(this.txtBillAdd);
            this.grpBillAdd.Controls.Add(this.label3);
            this.grpBillAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBillAdd.Location = new System.Drawing.Point(40, 368);
            this.grpBillAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBillAdd.Name = "grpBillAdd";
            this.grpBillAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBillAdd.Size = new System.Drawing.Size(1137, 189);
            this.grpBillAdd.TabIndex = 35;
            this.grpBillAdd.TabStop = false;
            this.grpBillAdd.Text = "Billing Address";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 34);
            this.label2.TabIndex = 40;
            this.label2.Text = "Email";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 71);
            this.label4.TabIndex = 41;
            this.label4.Text = "Contact person";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(784, 249);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 71);
            this.label15.TabIndex = 42;
            this.label15.Text = "Phone number";
            // 
            // contact_txtbx
            // 
            this.contact_txtbx.Location = new System.Drawing.Point(192, 254);
            this.contact_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contact_txtbx.Name = "contact_txtbx";
            this.contact_txtbx.Size = new System.Drawing.Size(464, 26);
            this.contact_txtbx.TabIndex = 43;
            // 
            // mail_txtbx
            // 
            this.mail_txtbx.Location = new System.Drawing.Point(1022, 208);
            this.mail_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mail_txtbx.Name = "mail_txtbx";
            this.mail_txtbx.Size = new System.Drawing.Size(524, 26);
            this.mail_txtbx.TabIndex = 44;
            // 
            // phone_txtbx
            // 
            this.phone_txtbx.Location = new System.Drawing.Point(1022, 269);
            this.phone_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone_txtbx.Name = "phone_txtbx";
            this.phone_txtbx.Size = new System.Drawing.Size(524, 26);
            this.phone_txtbx.TabIndex = 45;
            // 
            // custBackBtn
            // 
            this.custBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custBackBtn.Location = new System.Drawing.Point(42, 829);
            this.custBackBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custBackBtn.Name = "custBackBtn";
            this.custBackBtn.Size = new System.Drawing.Size(168, 60);
            this.custBackBtn.TabIndex = 46;
            this.custBackBtn.Text = "BACK";
            this.custBackBtn.UseVisualStyleBackColor = true;
            this.custBackBtn.Click += new System.EventHandler(this.custBackBtn_Click);
            // 
            // Create_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1726, 1049);
            this.Controls.Add(this.custBackBtn);
            this.Controls.Add(this.phone_txtbx);
            this.Controls.Add(this.mail_txtbx);
            this.Controls.Add(this.contact_txtbx);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkboxSameShipAdd);
            this.Controls.Add(this.grpShipAdd);
            this.Controls.Add(this.grpBillAdd);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNxtSub);
            this.Controls.Add(this.lblAircraft);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.aircraft_list);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.txtAutoCustID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreateCust);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Create_Customer";
            this.Text = "Create_Customer";
            this.Load += new System.EventHandler(this.Create_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpShipAdd.ResumeLayout(false);
            this.grpShipAdd.PerformLayout();
            this.grpBillAdd.ResumeLayout(false);
            this.grpBillAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutoCustID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.ListBox aircraft_list;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.Button btnNxtSub;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtShipZip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtShipAdd;
        private System.Windows.Forms.CheckBox chkboxSameShipAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBillAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBillZipCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBillCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpShipAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBillAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox contact_txtbx;
        private System.Windows.Forms.TextBox mail_txtbx;
        private System.Windows.Forms.TextBox phone_txtbx;
        private System.Windows.Forms.Button custBackBtn;
    }
}
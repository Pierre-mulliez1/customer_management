namespace Bombardier
{
    partial class View_sales_order
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
            this.product_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cust_nme_lbl = new System.Windows.Forms.Label();
            this.nme_lbl = new System.Windows.Forms.Label();
            this.Product_lbl = new System.Windows.Forms.Label();
            this.bck_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.order_nm = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreatePDF = new System.Windows.Forms.Button();
            this.btnSendInvoice = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.order_date_lbl = new System.Windows.Forms.Label();
            this.aircraft_lbl = new System.Windows.Forms.Label();
            this.cost_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.ship_lbl = new System.Windows.Forms.Label();
            this.company_lbl = new System.Windows.Forms.Label();
            this.contact_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tax_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grand_total_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // product_listbox
            // 
            this.product_listbox.FormattingEnabled = true;
            this.product_listbox.ItemHeight = 26;
            this.product_listbox.Location = new System.Drawing.Point(115, 295);
            this.product_listbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.product_listbox.Name = "product_listbox";
            this.product_listbox.Size = new System.Drawing.Size(482, 264);
            this.product_listbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order detail";
            // 
            // Cust_nme_lbl
            // 
            this.Cust_nme_lbl.AutoSize = true;
            this.Cust_nme_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_nme_lbl.Location = new System.Drawing.Point(225, 87);
            this.Cust_nme_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Cust_nme_lbl.Name = "Cust_nme_lbl";
            this.Cust_nme_lbl.Size = new System.Drawing.Size(168, 26);
            this.Cust_nme_lbl.TabIndex = 45;
            this.Cust_nme_lbl.Text = "Customer name";
            // 
            // nme_lbl
            // 
            this.nme_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nme_lbl.Location = new System.Drawing.Point(415, 74);
            this.nme_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nme_lbl.Name = "nme_lbl";
            this.nme_lbl.Size = new System.Drawing.Size(390, 39);
            this.nme_lbl.TabIndex = 46;
            // 
            // Product_lbl
            // 
            this.Product_lbl.AutoSize = true;
            this.Product_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_lbl.Location = new System.Drawing.Point(309, 247);
            this.Product_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Product_lbl.Name = "Product_lbl";
            this.Product_lbl.Size = new System.Drawing.Size(135, 32);
            this.Product_lbl.TabIndex = 52;
            this.Product_lbl.Text = "Products";
            // 
            // bck_btn
            // 
            this.bck_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bck_btn.Location = new System.Drawing.Point(678, 616);
            this.bck_btn.Margin = new System.Windows.Forms.Padding(6);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(149, 80);
            this.bck_btn.TabIndex = 53;
            this.bck_btn.Text = "BACK";
            this.bck_btn.UseVisualStyleBackColor = true;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Aircraft ID";
            // 
            // order_nm
            // 
            this.order_nm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.order_nm.Location = new System.Drawing.Point(415, 20);
            this.order_nm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.order_nm.Name = "order_nm";
            this.order_nm.Size = new System.Drawing.Size(390, 39);
            this.order_nm.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(225, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 26);
            this.label9.TabIndex = 61;
            this.label9.Text = "Order number";
            // 
            // btnCreatePDF
            // 
            this.btnCreatePDF.BackColor = System.Drawing.Color.LightCoral;
            this.btnCreatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePDF.Location = new System.Drawing.Point(837, 616);
            this.btnCreatePDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreatePDF.Name = "btnCreatePDF";
            this.btnCreatePDF.Size = new System.Drawing.Size(164, 80);
            this.btnCreatePDF.TabIndex = 71;
            this.btnCreatePDF.Text = "Create PDF";
            this.btnCreatePDF.UseVisualStyleBackColor = false;
            // 
            // btnSendInvoice
            // 
            this.btnSendInvoice.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSendInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSendInvoice.Location = new System.Drawing.Point(1014, 616);
            this.btnSendInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendInvoice.Name = "btnSendInvoice";
            this.btnSendInvoice.Size = new System.Drawing.Size(162, 80);
            this.btnSendInvoice.TabIndex = 70;
            this.btnSendInvoice.Text = "Send Invoice";
            this.btnSendInvoice.UseVisualStyleBackColor = false;
            this.btnSendInvoice.Click += new System.EventHandler(this.btnSendInvoice_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(658, 466);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(112, 25);
            this.lblTotalCost.TabIndex = 68;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipAddress.Location = new System.Drawing.Point(656, 358);
            this.lblShipAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(171, 25);
            this.lblShipAddress.TabIndex = 66;
            this.lblShipAddress.Text = "Shiping Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Company";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(656, 252);
            this.lblContactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(149, 25);
            this.lblContactName.TabIndex = 62;
            this.lblContactName.Text = "Contact Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "Total (quantity)";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(225, 151);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(64, 26);
            this.date_lbl.TabIndex = 76;
            this.date_lbl.Text = "Date ";
            // 
            // order_date_lbl
            // 
            this.order_date_lbl.BackColor = System.Drawing.Color.White;
            this.order_date_lbl.Location = new System.Drawing.Point(415, 138);
            this.order_date_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.order_date_lbl.Name = "order_date_lbl";
            this.order_date_lbl.Size = new System.Drawing.Size(390, 39);
            this.order_date_lbl.TabIndex = 77;
            // 
            // aircraft_lbl
            // 
            this.aircraft_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aircraft_lbl.Location = new System.Drawing.Point(858, 207);
            this.aircraft_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aircraft_lbl.Name = "aircraft_lbl";
            this.aircraft_lbl.Size = new System.Drawing.Size(317, 29);
            this.aircraft_lbl.TabIndex = 78;
            // 
            // cost_lbl
            // 
            this.cost_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cost_lbl.Location = new System.Drawing.Point(858, 465);
            this.cost_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cost_lbl.Name = "cost_lbl";
            this.cost_lbl.Size = new System.Drawing.Size(317, 29);
            this.cost_lbl.TabIndex = 82;
            // 
            // total_lbl
            // 
            this.total_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.total_lbl.Location = new System.Drawing.Point(859, 411);
            this.total_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(317, 29);
            this.total_lbl.TabIndex = 83;
            // 
            // ship_lbl
            // 
            this.ship_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ship_lbl.Location = new System.Drawing.Point(858, 354);
            this.ship_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ship_lbl.Name = "ship_lbl";
            this.ship_lbl.Size = new System.Drawing.Size(317, 29);
            this.ship_lbl.TabIndex = 84;
            // 
            // company_lbl
            // 
            this.company_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.company_lbl.Location = new System.Drawing.Point(858, 306);
            this.company_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.company_lbl.Name = "company_lbl";
            this.company_lbl.Size = new System.Drawing.Size(317, 29);
            this.company_lbl.TabIndex = 85;
            // 
            // contact_lbl
            // 
            this.contact_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contact_lbl.Location = new System.Drawing.Point(858, 252);
            this.contact_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.contact_lbl.Name = "contact_lbl";
            this.contact_lbl.Size = new System.Drawing.Size(317, 29);
            this.contact_lbl.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 515);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 87;
            this.label3.Text = "Total Taxes (15%)";
            // 
            // tax_lbl
            // 
            this.tax_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tax_lbl.Location = new System.Drawing.Point(858, 515);
            this.tax_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tax_lbl.Name = "tax_lbl";
            this.tax_lbl.Size = new System.Drawing.Size(317, 29);
            this.tax_lbl.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 579);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Grand total";
            // 
            // grand_total_lbl
            // 
            this.grand_total_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grand_total_lbl.Location = new System.Drawing.Point(858, 575);
            this.grand_total_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.grand_total_lbl.Name = "grand_total_lbl";
            this.grand_total_lbl.Size = new System.Drawing.Size(317, 29);
            this.grand_total_lbl.TabIndex = 90;
            // 
            // View_sales_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1189, 711);
            this.Controls.Add(this.grand_total_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tax_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contact_lbl);
            this.Controls.Add(this.company_lbl);
            this.Controls.Add(this.ship_lbl);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.cost_lbl);
            this.Controls.Add(this.aircraft_lbl);
            this.Controls.Add(this.order_date_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreatePDF);
            this.Controls.Add(this.btnSendInvoice);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblShipAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.order_nm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.Product_lbl);
            this.Controls.Add(this.nme_lbl);
            this.Controls.Add(this.Cust_nme_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.product_listbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "View_sales_order";
            this.Text = "View_sales_order";
            this.Load += new System.EventHandler(this.View_sales_order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox product_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cust_nme_lbl;
        private System.Windows.Forms.Label nme_lbl;
        private System.Windows.Forms.Label Product_lbl;
        private System.Windows.Forms.Button bck_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label order_nm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreatePDF;
        private System.Windows.Forms.Button btnSendInvoice;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label order_date_lbl;
        private System.Windows.Forms.Label aircraft_lbl;
        private System.Windows.Forms.Label cost_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label ship_lbl;
        private System.Windows.Forms.Label company_lbl;
        private System.Windows.Forms.Label contact_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tax_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label grand_total_lbl;
    }
}
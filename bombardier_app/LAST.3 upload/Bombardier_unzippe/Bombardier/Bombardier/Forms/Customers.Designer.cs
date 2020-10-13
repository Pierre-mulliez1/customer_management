namespace Bombardier
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.btnCreateCust = new System.Windows.Forms.Button();
            this.btnModifyCust = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custname_chckbx = new System.Windows.Forms.CheckBox();
            this.custid_chckbx = new System.Windows.Forms.CheckBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txtbx = new System.Windows.Forms.TextBox();
            this.bck_btn = new System.Windows.Forms.Button();
            this.customer_lstbx = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCust
            // 
            this.btnCreateCust.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCust.Location = new System.Drawing.Point(958, 163);
            this.btnCreateCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateCust.Name = "btnCreateCust";
            this.btnCreateCust.Size = new System.Drawing.Size(224, 86);
            this.btnCreateCust.TabIndex = 4;
            this.btnCreateCust.Text = "Create New Customer";
            this.btnCreateCust.UseVisualStyleBackColor = false;
            this.btnCreateCust.Click += new System.EventHandler(this.btnCreateSub_Click);
            // 
            // btnModifyCust
            // 
            this.btnModifyCust.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifyCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyCust.Location = new System.Drawing.Point(1216, 163);
            this.btnModifyCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifyCust.Name = "btnModifyCust";
            this.btnModifyCust.Size = new System.Drawing.Size(216, 86);
            this.btnModifyCust.TabIndex = 5;
            this.btnModifyCust.Text = "Modify Customer Info";
            this.btnModifyCust.UseVisualStyleBackColor = false;
            this.btnModifyCust.Click += new System.EventHandler(this.btnModifyCust_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.custname_chckbx);
            this.groupBox1.Controls.Add(this.custid_chckbx);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.search_txtbx);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(352, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 210);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search ";
            // 
            // custname_chckbx
            // 
            this.custname_chckbx.AutoSize = true;
            this.custname_chckbx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custname_chckbx.Location = new System.Drawing.Point(335, 39);
            this.custname_chckbx.Name = "custname_chckbx";
            this.custname_chckbx.Size = new System.Drawing.Size(213, 28);
            this.custname_chckbx.TabIndex = 15;
            this.custname_chckbx.Text = "By customer name";
            this.custname_chckbx.UseVisualStyleBackColor = true;
            // 
            // custid_chckbx
            // 
            this.custid_chckbx.AutoSize = true;
            this.custid_chckbx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custid_chckbx.Location = new System.Drawing.Point(6, 39);
            this.custid_chckbx.Name = "custid_chckbx";
            this.custid_chckbx.Size = new System.Drawing.Size(269, 28);
            this.custid_chckbx.TabIndex = 14;
            this.custid_chckbx.Text = "By Customer ID (default)";
            this.custid_chckbx.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(44, 144);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(463, 58);
            this.search_btn.TabIndex = 13;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txtbx
            // 
            this.search_txtbx.Location = new System.Drawing.Point(44, 75);
            this.search_txtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.Size = new System.Drawing.Size(463, 40);
            this.search_txtbx.TabIndex = 12;
            // 
            // bck_btn
            // 
            this.bck_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bck_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bck_btn.Location = new System.Drawing.Point(1216, 861);
            this.bck_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(224, 86);
            this.bck_btn.TabIndex = 10;
            this.bck_btn.Text = "Back";
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // customer_lstbx
            // 
            this.customer_lstbx.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.customer_lstbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_lstbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customer_lstbx.FormattingEnabled = true;
            this.customer_lstbx.ItemHeight = 27;
            this.customer_lstbx.Location = new System.Drawing.Point(352, 296);
            this.customer_lstbx.Name = "customer_lstbx";
            this.customer_lstbx.Size = new System.Drawing.Size(1088, 517);
            this.customer_lstbx.TabIndex = 11;
            this.customer_lstbx.SelectedIndexChanged += new System.EventHandler(this.customer_lstbx_SelectedIndexChanged);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1826, 985);
            this.Controls.Add(this.customer_lstbx);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModifyCust);
            this.Controls.Add(this.btnCreateCust);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateCust;
        private System.Windows.Forms.Button btnModifyCust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txtbx;
        private System.Windows.Forms.CheckBox custid_chckbx;
        private System.Windows.Forms.CheckBox custname_chckbx;
        private System.Windows.Forms.Button bck_btn;
        private System.Windows.Forms.ListBox customer_lstbx;
    }
}
namespace Bombardier
{
    partial class Modify_Sub
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
            this.btnSaveSub = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.product_List = new System.Windows.Forms.ListBox();
            this.lblAircraftID = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnDeleteSub = new System.Windows.Forms.Button();
            this.lblModifySub = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveSub
            // 
            this.btnSaveSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSub.Location = new System.Drawing.Point(559, 632);
            this.btnSaveSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveSub.Name = "btnSaveSub";
            this.btnSaveSub.Size = new System.Drawing.Size(172, 62);
            this.btnSaveSub.TabIndex = 28;
            this.btnSaveSub.Text = "UPDATE";
            this.btnSaveSub.UseVisualStyleBackColor = true;
            this.btnSaveSub.Click += new System.EventHandler(this.btnSaveSub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Subscription ID";
            // 
            // txtSubID
            // 
            this.txtSubID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSubID.Location = new System.Drawing.Point(310, 102);
            this.txtSubID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubID.Name = "txtSubID";
            this.txtSubID.ReadOnly = true;
            this.txtSubID.Size = new System.Drawing.Size(338, 26);
            this.txtSubID.TabIndex = 26;
            this.txtSubID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Start Date";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(130, 298);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(97, 25);
            this.lblProducts.TabIndex = 21;
            this.lblProducts.Text = "Products";
            // 
            // product_List
            // 
            this.product_List.FormattingEnabled = true;
            this.product_List.ItemHeight = 20;
            this.product_List.Location = new System.Drawing.Point(235, 298);
            this.product_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product_List.Name = "product_List";
            this.product_List.Size = new System.Drawing.Size(672, 304);
            this.product_List.TabIndex = 20;
            // 
            // lblAircraftID
            // 
            this.lblAircraftID.AutoSize = true;
            this.lblAircraftID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftID.Location = new System.Drawing.Point(695, 164);
            this.lblAircraftID.Name = "lblAircraftID";
            this.lblAircraftID.Size = new System.Drawing.Size(108, 25);
            this.lblAircraftID.TabIndex = 18;
            this.lblAircraftID.Text = "Aircraft ID";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(132, 162);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(104, 25);
            this.lblCustName.TabIndex = 17;
            this.lblCustName.Text = "Company";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(310, 162);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(338, 26);
            this.txtCustomerName.TabIndex = 16;
            // 
            // btnDeleteSub
            // 
            this.btnDeleteSub.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSub.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteSub.Location = new System.Drawing.Point(762, 632);
            this.btnDeleteSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteSub.Name = "btnDeleteSub";
            this.btnDeleteSub.Size = new System.Drawing.Size(145, 62);
            this.btnDeleteSub.TabIndex = 31;
            this.btnDeleteSub.Text = "DELETE";
            this.btnDeleteSub.UseVisualStyleBackColor = false;
            this.btnDeleteSub.Click += new System.EventHandler(this.btnDeleteSub_Click);
            // 
            // lblModifySub
            // 
            this.lblModifySub.BackColor = System.Drawing.Color.Navy;
            this.lblModifySub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModifySub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifySub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModifySub.Location = new System.Drawing.Point(18, 11);
            this.lblModifySub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModifySub.Name = "lblModifySub";
            this.lblModifySub.Size = new System.Drawing.Size(352, 60);
            this.lblModifySub.TabIndex = 41;
            this.lblModifySub.Text = "Modify Subscription";
            this.lblModifySub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 649);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 62);
            this.button1.TabIndex = 42;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 206);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(338, 26);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(310, 240);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(338, 26);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(822, 160);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 28);
            this.comboBox1.TabIndex = 46;
            // 
            // Modify_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1185, 728);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblModifySub);
            this.Controls.Add(this.btnDeleteSub);
            this.Controls.Add(this.btnSaveSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.product_List);
            this.Controls.Add(this.lblAircraftID);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.txtCustomerName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Modify_Sub";
            this.Text = "Modify Subscription";
            this.Load += new System.EventHandler(this.Modify_Sub_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox product_List;
        private System.Windows.Forms.Label lblAircraftID;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnDeleteSub;
        private System.Windows.Forms.Label lblModifySub;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
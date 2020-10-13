namespace Bombardier
{
    partial class Subscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subscription));
            this.btnCreateNewSub = new System.Windows.Forms.Button();
            this.btnModifySub = new System.Windows.Forms.Button();
            this.bck_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custIdBtn = new System.Windows.Forms.RadioButton();
            this.subIdBtn = new System.Windows.Forms.RadioButton();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txtbx = new System.Windows.Forms.TextBox();
            this.subLB = new System.Windows.Forms.ListBox();
            this.invoice_lstbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNewSub
            // 
            this.btnCreateNewSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateNewSub.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCreateNewSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewSub.Location = new System.Drawing.Point(1020, 619);
            this.btnCreateNewSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNewSub.Name = "btnCreateNewSub";
            this.btnCreateNewSub.Size = new System.Drawing.Size(302, 71);
            this.btnCreateNewSub.TabIndex = 1;
            this.btnCreateNewSub.Text = "Create New Subscription";
            this.btnCreateNewSub.UseVisualStyleBackColor = false;
            this.btnCreateNewSub.Click += new System.EventHandler(this.btnCreateNewSub_Click);
            // 
            // btnModifySub
            // 
            this.btnModifySub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifySub.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnModifySub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifySub.Location = new System.Drawing.Point(380, 619);
            this.btnModifySub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifySub.Name = "btnModifySub";
            this.btnModifySub.Size = new System.Drawing.Size(578, 71);
            this.btnModifySub.TabIndex = 2;
            this.btnModifySub.Text = "Modify Subscription";
            this.btnModifySub.UseVisualStyleBackColor = false;
            this.btnModifySub.Click += new System.EventHandler(this.btnModifySub_Click);
            // 
            // bck_btn
            // 
            this.bck_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bck_btn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bck_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bck_btn.Location = new System.Drawing.Point(1354, 703);
            this.bck_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(172, 71);
            this.bck_btn.TabIndex = 8;
            this.bck_btn.Text = "Main Menu";
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.custIdBtn);
            this.groupBox1.Controls.Add(this.subIdBtn);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.search_txtbx);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(380, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(578, 210);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search ";
            // 
            // custIdBtn
            // 
            this.custIdBtn.AutoSize = true;
            this.custIdBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIdBtn.Location = new System.Drawing.Point(325, 38);
            this.custIdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custIdBtn.Name = "custIdBtn";
            this.custIdBtn.Size = new System.Drawing.Size(152, 28);
            this.custIdBtn.TabIndex = 15;
            this.custIdBtn.TabStop = true;
            this.custIdBtn.Text = "Customer ID";
            this.custIdBtn.UseVisualStyleBackColor = true;
            // 
            // subIdBtn
            // 
            this.subIdBtn.AutoSize = true;
            this.subIdBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subIdBtn.Location = new System.Drawing.Point(60, 38);
            this.subIdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subIdBtn.Name = "subIdBtn";
            this.subIdBtn.Size = new System.Drawing.Size(180, 28);
            this.subIdBtn.TabIndex = 14;
            this.subIdBtn.TabStop = true;
            this.subIdBtn.Text = "Subscription ID";
            this.subIdBtn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(44, 144);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(464, 58);
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
            // subLB
            // 
            this.subLB.FormattingEnabled = true;
            this.subLB.ItemHeight = 20;
            this.subLB.Location = new System.Drawing.Point(380, 289);
            this.subLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subLB.Name = "subLB";
            this.subLB.Size = new System.Drawing.Size(578, 324);
            this.subLB.TabIndex = 11;
            this.subLB.SelectedIndexChanged += new System.EventHandler(this.subLB_SelectedIndexChanged);
            // 
            // invoice_lstbx
            // 
            this.invoice_lstbx.FormattingEnabled = true;
            this.invoice_lstbx.ItemHeight = 20;
            this.invoice_lstbx.Location = new System.Drawing.Point(1020, 289);
            this.invoice_lstbx.Name = "invoice_lstbx";
            this.invoice_lstbx.Size = new System.Drawing.Size(302, 324);
            this.invoice_lstbx.TabIndex = 12;
            this.invoice_lstbx.SelectedIndexChanged += new System.EventHandler(this.invoice_lstbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1020, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Invoices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 878);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoice_lstbx);
            this.Controls.Add(this.subLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.btnModifySub);
            this.Controls.Add(this.btnCreateNewSub);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Subscription";
            this.Text = "Subscription";
            this.Load += new System.EventHandler(this.Subscription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewSub;
        private System.Windows.Forms.Button btnModifySub;
        private System.Windows.Forms.Button bck_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txtbx;
		private System.Windows.Forms.RadioButton custIdBtn;
		private System.Windows.Forms.RadioButton subIdBtn;
		private System.Windows.Forms.ListBox subLB;
        private System.Windows.Forms.ListBox invoice_lstbx;
        private System.Windows.Forms.Label label1;
    }
}
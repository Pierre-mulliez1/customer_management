namespace Bombardier
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.productLabel = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.ListBox();
            this.prodMainMenuBtn = new System.Windows.Forms.Button();
            this.mdfBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(71, 88);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(242, 35);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Product ID";
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.Location = new System.Drawing.Point(487, 128);
            this.addProductBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(315, 69);
            this.addProductBtn.TabIndex = 2;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.ItemHeight = 20;
            this.productList.Location = new System.Drawing.Point(65, 243);
            this.productList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(307, 164);
            this.productList.TabIndex = 4;
            // 
            // prodMainMenuBtn
            // 
            this.prodMainMenuBtn.Location = new System.Drawing.Point(75, 478);
            this.prodMainMenuBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodMainMenuBtn.Name = "prodMainMenuBtn";
            this.prodMainMenuBtn.Size = new System.Drawing.Size(170, 65);
            this.prodMainMenuBtn.TabIndex = 5;
            this.prodMainMenuBtn.Text = "Main Menu";
            this.prodMainMenuBtn.UseVisualStyleBackColor = true;
            this.prodMainMenuBtn.Click += new System.EventHandler(this.prodMainMenuBtn_Click);
            // 
            // mdfBtn
            // 
            this.mdfBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mdfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdfBtn.Location = new System.Drawing.Point(487, 312);
            this.mdfBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mdfBtn.Name = "mdfBtn";
            this.mdfBtn.Size = new System.Drawing.Size(315, 69);
            this.mdfBtn.TabIndex = 6;
            this.mdfBtn.Text = "Modify Product";
            this.mdfBtn.UseVisualStyleBackColor = false;
            this.mdfBtn.Click += new System.EventHandler(this.mdfBtn_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Information";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 128);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 651);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mdfBtn);
            this.Controls.Add(this.prodMainMenuBtn);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.productLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.Button prodMainMenuBtn;
		private System.Windows.Forms.Button mdfBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
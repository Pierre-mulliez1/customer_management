namespace Bombardier
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnSubscriptions = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btmProducts = new System.Windows.Forms.Button();
            this.btnInvoiceHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubscriptions
            // 
            this.btnSubscriptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscriptions.Location = new System.Drawing.Point(51, 160);
            this.btnSubscriptions.Name = "btnSubscriptions";
            this.btnSubscriptions.Size = new System.Drawing.Size(309, 118);
            this.btnSubscriptions.TabIndex = 0;
            this.btnSubscriptions.Text = " Subcriptions";
            this.btnSubscriptions.UseVisualStyleBackColor = false;
            this.btnSubscriptions.Click += new System.EventHandler(this.btnSubscriptions_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(51, 35);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(309, 118);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btmProducts
            // 
            this.btmProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btmProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmProducts.Location = new System.Drawing.Point(51, 285);
            this.btmProducts.Name = "btmProducts";
            this.btmProducts.Size = new System.Drawing.Size(309, 118);
            this.btmProducts.TabIndex = 2;
            this.btmProducts.Text = "Products";
            this.btmProducts.UseVisualStyleBackColor = false;
            this.btmProducts.Click += new System.EventHandler(this.btmProducts_Click);
            // 
            // btnInvoiceHistory
            // 
            this.btnInvoiceHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInvoiceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceHistory.Location = new System.Drawing.Point(51, 409);
            this.btnInvoiceHistory.Name = "btnInvoiceHistory";
            this.btnInvoiceHistory.Size = new System.Drawing.Size(309, 118);
            this.btnInvoiceHistory.TabIndex = 3;
            this.btnInvoiceHistory.Text = "Invoice History";
            this.btnInvoiceHistory.UseVisualStyleBackColor = false;
            this.btnInvoiceHistory.Click += new System.EventHandler(this.btnInvoicing_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 762);
            this.Controls.Add(this.btnInvoiceHistory);
            this.Controls.Add(this.btmProducts);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnSubscriptions);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubscriptions;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btmProducts;
        private System.Windows.Forms.Button btnInvoiceHistory;
    }
}


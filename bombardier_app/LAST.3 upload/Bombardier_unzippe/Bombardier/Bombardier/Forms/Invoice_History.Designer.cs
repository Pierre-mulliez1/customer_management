namespace Bombardier
{
    partial class Invoice_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice_History));
            this.backToMainMenuBtn = new System.Windows.Forms.Button();
            this.formTitleLbl = new System.Windows.Forms.Label();
            this.inv_listbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backToMainMenuBtn
            // 
            this.backToMainMenuBtn.Location = new System.Drawing.Point(66, 598);
            this.backToMainMenuBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backToMainMenuBtn.Name = "backToMainMenuBtn";
            this.backToMainMenuBtn.Size = new System.Drawing.Size(182, 75);
            this.backToMainMenuBtn.TabIndex = 1;
            this.backToMainMenuBtn.Text = "Main Menu";
            this.backToMainMenuBtn.UseVisualStyleBackColor = true;
            this.backToMainMenuBtn.Click += new System.EventHandler(this.backToMainMenuBtn_Click);
            // 
            // formTitleLbl
            // 
            this.formTitleLbl.AutoSize = true;
            this.formTitleLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLbl.Location = new System.Drawing.Point(453, 52);
            this.formTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitleLbl.Name = "formTitleLbl";
            this.formTitleLbl.Size = new System.Drawing.Size(297, 46);
            this.formTitleLbl.TabIndex = 2;
            this.formTitleLbl.Text = "Invoice History";
            // 
            // inv_listbx
            // 
            this.inv_listbx.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.inv_listbx.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_listbx.FormattingEnabled = true;
            this.inv_listbx.ItemHeight = 21;
            this.inv_listbx.Location = new System.Drawing.Point(156, 138);
            this.inv_listbx.Name = "inv_listbx";
            this.inv_listbx.Size = new System.Drawing.Size(951, 382);
            this.inv_listbx.TabIndex = 3;
            // 
            // Invoice_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.inv_listbx);
            this.Controls.Add(this.formTitleLbl);
            this.Controls.Add(this.backToMainMenuBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Invoice_History";
            this.Text = "Invoice_History";
            this.Load += new System.EventHandler(this.Invoice_History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backToMainMenuBtn;
        private System.Windows.Forms.Label formTitleLbl;
        private System.Windows.Forms.ListBox inv_listbx;
    }
}
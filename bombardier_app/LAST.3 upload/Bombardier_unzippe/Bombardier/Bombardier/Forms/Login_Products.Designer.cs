namespace Bombardier
{
    partial class Login_Products
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
            this.explanationLabel = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.enterPWBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // explanationLabel
            // 
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationLabel.Location = new System.Drawing.Point(250, 142);
            this.explanationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(770, 91);
            this.explanationLabel.TabIndex = 0;
            this.explanationLabel.Text = "To add or modify products, you need to authenticate yourself. Please enter the pa" +
    "ssword.";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(514, 288);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(188, 26);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // enterPWBtn
            // 
            this.enterPWBtn.Location = new System.Drawing.Point(555, 366);
            this.enterPWBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterPWBtn.Name = "enterPWBtn";
            this.enterPWBtn.Size = new System.Drawing.Size(112, 35);
            this.enterPWBtn.TabIndex = 2;
            this.enterPWBtn.Text = "Enter ";
            this.enterPWBtn.UseVisualStyleBackColor = true;
            this.enterPWBtn.Click += new System.EventHandler(this.enterPWBtn_Click);
            // 
            // Login_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.enterPWBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.explanationLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login_Products";
            this.Text = "Login_Products";
            this.Load += new System.EventHandler(this.Login_Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button enterPWBtn;
    }
}
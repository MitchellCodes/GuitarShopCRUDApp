
namespace GuitarShopCRUDApp
{
    partial class frmEditCustomer
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
            this.BtnEditCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEditCustomer
            // 
            this.BtnEditCustomer.Location = new System.Drawing.Point(180, 300);
            this.BtnEditCustomer.Name = "BtnEditCustomer";
            this.BtnEditCustomer.Size = new System.Drawing.Size(124, 24);
            this.BtnEditCustomer.TabIndex = 0;
            this.BtnEditCustomer.Text = "Edit Customer";
            this.BtnEditCustomer.UseVisualStyleBackColor = true;
            this.BtnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEditCustomer);
            this.Name = "frmEditCustomer";
            this.Text = "frmEditCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEditCustomer;
    }
}
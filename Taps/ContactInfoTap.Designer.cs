namespace CvBuilder
{
    partial class ContactInfoTap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxFirstPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSecondPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxCity = new System.Windows.Forms.TextBox();
            this.TextBoxCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone No. 1 :";
            // 
            // TextBoxFirstPhoneNumber
            // 
            this.TextBoxFirstPhoneNumber.BackColor = System.Drawing.Color.White;
            this.TextBoxFirstPhoneNumber.Location = new System.Drawing.Point(74, 112);
            this.TextBoxFirstPhoneNumber.Name = "TextBoxFirstPhoneNumber";
            this.TextBoxFirstPhoneNumber.Size = new System.Drawing.Size(305, 29);
            this.TextBoxFirstPhoneNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone No. 2 ( Optional ) :";
            // 
            // TextBoxSecondPhoneNumber
            // 
            this.TextBoxSecondPhoneNumber.Location = new System.Drawing.Point(74, 235);
            this.TextBoxSecondPhoneNumber.Name = "TextBoxSecondPhoneNumber";
            this.TextBoxSecondPhoneNumber.Size = new System.Drawing.Size(305, 29);
            this.TextBoxSecondPhoneNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(454, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "City :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(454, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Country :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(70, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "E - Mail : ";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(74, 359);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(641, 29);
            this.TextBoxEmail.TabIndex = 2;
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.BackColor = System.Drawing.Color.White;
            this.TextBoxCity.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCity.Location = new System.Drawing.Point(458, 112);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(257, 29);
            this.TextBoxCity.TabIndex = 2;
            // 
            // TextBoxCountry
            // 
            this.TextBoxCountry.BackColor = System.Drawing.Color.White;
            this.TextBoxCountry.Location = new System.Drawing.Point(458, 235);
            this.TextBoxCountry.Name = "TextBoxCountry";
            this.TextBoxCountry.Size = new System.Drawing.Size(257, 29);
            this.TextBoxCountry.TabIndex = 2;
            // 
            // ContactInfoTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxSecondPhoneNumber);
            this.Controls.Add(this.TextBoxCountry);
            this.Controls.Add(this.TextBoxCity);
            this.Controls.Add(this.TextBoxFirstPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ContactInfoTap";
            this.Size = new System.Drawing.Size(807, 731);
            this.Load += new System.EventHandler(this.ContactInfoTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFirstPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSecondPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxCity;
        private System.Windows.Forms.TextBox TextBoxCountry;
    }
}

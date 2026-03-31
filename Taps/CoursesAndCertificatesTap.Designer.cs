namespace CvBuilder
{
    partial class CoursesAndCertificatesTap
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
            this.TextBoxCertificateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxInstituteName = new System.Windows.Forms.TextBox();
            this.ButtonAddCertificate = new System.Windows.Forms.Button();
            this.ListViewCertificates = new System.Windows.Forms.ListView();
            this.ColumnCertificateName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnInstituteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDateObtained = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBoxDateObtained = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Certificate Name :";
            // 
            // TextBoxCertificateName
            // 
            this.TextBoxCertificateName.Location = new System.Drawing.Point(71, 102);
            this.TextBoxCertificateName.Name = "TextBoxCertificateName";
            this.TextBoxCertificateName.Size = new System.Drawing.Size(697, 29);
            this.TextBoxCertificateName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Institute Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date Obtained :";
            // 
            // TextBoxInstituteName
            // 
            this.TextBoxInstituteName.Location = new System.Drawing.Point(71, 195);
            this.TextBoxInstituteName.Name = "TextBoxInstituteName";
            this.TextBoxInstituteName.Size = new System.Drawing.Size(697, 29);
            this.TextBoxInstituteName.TabIndex = 2;
            // 
            // ButtonAddCertificate
            // 
            this.ButtonAddCertificate.BackColor = System.Drawing.Color.Silver;
            this.ButtonAddCertificate.FlatAppearance.BorderSize = 0;
            this.ButtonAddCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCertificate.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddCertificate.Location = new System.Drawing.Point(71, 316);
            this.ButtonAddCertificate.Name = "ButtonAddCertificate";
            this.ButtonAddCertificate.Size = new System.Drawing.Size(169, 39);
            this.ButtonAddCertificate.TabIndex = 8;
            this.ButtonAddCertificate.Text = "Add";
            this.ButtonAddCertificate.UseVisualStyleBackColor = false;
            this.ButtonAddCertificate.Click += new System.EventHandler(this.ButtonAddCertificate_Click);
            // 
            // ListViewCertificates
            // 
            this.ListViewCertificates.BackColor = System.Drawing.Color.Silver;
            this.ListViewCertificates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCertificateName,
            this.ColumnInstituteName,
            this.ColumnDateObtained});
            this.ListViewCertificates.ForeColor = System.Drawing.Color.Black;
            this.ListViewCertificates.Location = new System.Drawing.Point(71, 386);
            this.ListViewCertificates.Name = "ListViewCertificates";
            this.ListViewCertificates.Size = new System.Drawing.Size(697, 238);
            this.ListViewCertificates.TabIndex = 10;
            this.ListViewCertificates.UseCompatibleStateImageBehavior = false;
            this.ListViewCertificates.View = System.Windows.Forms.View.Details;
            // 
            // ColumnCertificateName
            // 
            this.ColumnCertificateName.Text = "Name";
            this.ColumnCertificateName.Width = 249;
            // 
            // ColumnInstituteName
            // 
            this.ColumnInstituteName.Text = "Institute";
            this.ColumnInstituteName.Width = 219;
            // 
            // ColumnDateObtained
            // 
            this.ColumnDateObtained.Text = "Date";
            this.ColumnDateObtained.Width = 180;
            // 
            // TextBoxDateObtained
            // 
            this.TextBoxDateObtained.Location = new System.Drawing.Point(220, 258);
            this.TextBoxDateObtained.Name = "TextBoxDateObtained";
            this.TextBoxDateObtained.Size = new System.Drawing.Size(262, 29);
            this.TextBoxDateObtained.TabIndex = 2;
            // 
            // CoursesAndCertificatesTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ListViewCertificates);
            this.Controls.Add(this.ButtonAddCertificate);
            this.Controls.Add(this.TextBoxDateObtained);
            this.Controls.Add(this.TextBoxInstituteName);
            this.Controls.Add(this.TextBoxCertificateName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CoursesAndCertificatesTap";
            this.Size = new System.Drawing.Size(807, 731);
            this.Load += new System.EventHandler(this.CoursesAndCertificatesTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCertificateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxInstituteName;
        private System.Windows.Forms.Button ButtonAddCertificate;
        private System.Windows.Forms.ListView ListViewCertificates;
        private System.Windows.Forms.ColumnHeader ColumnCertificateName;
        private System.Windows.Forms.ColumnHeader ColumnInstituteName;
        private System.Windows.Forms.ColumnHeader ColumnDateObtained;
        private System.Windows.Forms.TextBox TextBoxDateObtained;
    }
}

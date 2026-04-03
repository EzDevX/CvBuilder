namespace CvBuilder
{
    partial class ExperiencesTap
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
            this.TextBoxJobTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxResposes = new System.Windows.Forms.TextBox();
            this.ListViewExperiences = new System.Windows.Forms.ListView();
            this.ColumnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunmFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonAddExperience = new System.Windows.Forms.Button();
            this.TextBoxFromDate = new System.Windows.Forms.TextBox();
            this.TextBoxToDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job Title :";
            // 
            // TextBoxJobTitle
            // 
            this.TextBoxJobTitle.Location = new System.Drawing.Point(68, 104);
            this.TextBoxJobTitle.Name = "TextBoxJobTitle";
            this.TextBoxJobTitle.Size = new System.Drawing.Size(673, 29);
            this.TextBoxJobTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name :";
            // 
            // TextBoxCompanyName
            // 
            this.TextBoxCompanyName.Location = new System.Drawing.Point(68, 183);
            this.TextBoxCompanyName.Name = "TextBoxCompanyName";
            this.TextBoxCompanyName.Size = new System.Drawing.Size(673, 29);
            this.TextBoxCompanyName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(427, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "To :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(66, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Responsibilities :";
            // 
            // TextBoxResposes
            // 
            this.TextBoxResposes.Location = new System.Drawing.Point(70, 309);
            this.TextBoxResposes.Multiline = true;
            this.TextBoxResposes.Name = "TextBoxResposes";
            this.TextBoxResposes.Size = new System.Drawing.Size(671, 83);
            this.TextBoxResposes.TabIndex = 3;
            // 
            // ListViewExperiences
            // 
            this.ListViewExperiences.BackColor = System.Drawing.Color.Silver;
            this.ListViewExperiences.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTitle,
            this.ColumnCompanyName,
            this.ColunmFrom,
            this.ColumnTo});
            this.ListViewExperiences.ForeColor = System.Drawing.Color.Black;
            this.ListViewExperiences.Location = new System.Drawing.Point(72, 452);
            this.ListViewExperiences.Name = "ListViewExperiences";
            this.ListViewExperiences.Size = new System.Drawing.Size(669, 189);
            this.ListViewExperiences.TabIndex = 8;
            this.ListViewExperiences.UseCompatibleStateImageBehavior = false;
            this.ListViewExperiences.View = System.Windows.Forms.View.Details;
            this.ListViewExperiences.ItemActivate += new System.EventHandler(this.ListViewExperiences_ItemActivate);
            this.ListViewExperiences.SelectedIndexChanged += new System.EventHandler(this.ListViewExperiences_SelectedIndexChanged);
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.Text = "Title";
            this.ColumnTitle.Width = 135;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.Text = "Co.";
            this.ColumnCompanyName.Width = 170;
            // 
            // ColunmFrom
            // 
            this.ColunmFrom.Text = "From";
            this.ColunmFrom.Width = 115;
            // 
            // ColumnTo
            // 
            this.ColumnTo.Text = "To";
            this.ColumnTo.Width = 89;
            // 
            // ButtonAddExperience
            // 
            this.ButtonAddExperience.BackColor = System.Drawing.Color.Silver;
            this.ButtonAddExperience.FlatAppearance.BorderSize = 0;
            this.ButtonAddExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddExperience.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddExperience.Location = new System.Drawing.Point(70, 402);
            this.ButtonAddExperience.Name = "ButtonAddExperience";
            this.ButtonAddExperience.Size = new System.Drawing.Size(169, 39);
            this.ButtonAddExperience.TabIndex = 9;
            this.ButtonAddExperience.Text = "Add";
            this.ButtonAddExperience.UseVisualStyleBackColor = false;
            this.ButtonAddExperience.Click += new System.EventHandler(this.ButtonAddExperience_Click);
            // 
            // TextBoxFromDate
            // 
            this.TextBoxFromDate.Location = new System.Drawing.Point(129, 236);
            this.TextBoxFromDate.Name = "TextBoxFromDate";
            this.TextBoxFromDate.Size = new System.Drawing.Size(283, 29);
            this.TextBoxFromDate.TabIndex = 3;
            // 
            // TextBoxToDate
            // 
            this.TextBoxToDate.Location = new System.Drawing.Point(476, 236);
            this.TextBoxToDate.Name = "TextBoxToDate";
            this.TextBoxToDate.Size = new System.Drawing.Size(265, 29);
            this.TextBoxToDate.TabIndex = 3;
            // 
            // ExperiencesTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ButtonAddExperience);
            this.Controls.Add(this.ListViewExperiences);
            this.Controls.Add(this.TextBoxResposes);
            this.Controls.Add(this.TextBoxToDate);
            this.Controls.Add(this.TextBoxFromDate);
            this.Controls.Add(this.TextBoxCompanyName);
            this.Controls.Add(this.TextBoxJobTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExperiencesTap";
            this.Size = new System.Drawing.Size(807, 731);
            this.Load += new System.EventHandler(this.ExperiencesTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxJobTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxResposes;
        private System.Windows.Forms.ListView ListViewExperiences;
        private System.Windows.Forms.ColumnHeader ColumnTitle;
        private System.Windows.Forms.ColumnHeader ColumnCompanyName;
        private System.Windows.Forms.ColumnHeader ColunmFrom;
        private System.Windows.Forms.ColumnHeader ColumnTo;
        private System.Windows.Forms.Button ButtonAddExperience;
        private System.Windows.Forms.TextBox TextBoxFromDate;
        private System.Windows.Forms.TextBox TextBoxToDate;
    }
}

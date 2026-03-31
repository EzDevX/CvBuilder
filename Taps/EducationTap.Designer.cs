namespace CvBuilder
{
    partial class EducationTap
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
            this.TextBoxDegreeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUniversityName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxGraduationGrade = new System.Windows.Forms.ComboBox();
            this.ButtonAddEducation = new System.Windows.Forms.Button();
            this.ListViewEducation = new System.Windows.Forms.ListView();
            this.ColumnDegree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnUniversity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxGraduationYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Degree Name :";
            // 
            // TextBoxDegreeName
            // 
            this.TextBoxDegreeName.Location = new System.Drawing.Point(68, 113);
            this.TextBoxDegreeName.Name = "TextBoxDegreeName";
            this.TextBoxDegreeName.Size = new System.Drawing.Size(427, 29);
            this.TextBoxDegreeName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "University Or School Name :";
            // 
            // TextBoxUniversityName
            // 
            this.TextBoxUniversityName.Location = new System.Drawing.Point(68, 224);
            this.TextBoxUniversityName.Name = "TextBoxUniversityName";
            this.TextBoxUniversityName.Size = new System.Drawing.Size(427, 29);
            this.TextBoxUniversityName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(515, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Graduation Year :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(515, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Graduation Grade :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ComboBoxGraduationGrade
            // 
            this.ComboBoxGraduationGrade.FormattingEnabled = true;
            this.ComboBoxGraduationGrade.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Fair"});
            this.ComboBoxGraduationGrade.Location = new System.Drawing.Point(519, 224);
            this.ComboBoxGraduationGrade.Name = "ComboBoxGraduationGrade";
            this.ComboBoxGraduationGrade.Size = new System.Drawing.Size(217, 29);
            this.ComboBoxGraduationGrade.TabIndex = 5;
            // 
            // ButtonAddEducation
            // 
            this.ButtonAddEducation.BackColor = System.Drawing.Color.Silver;
            this.ButtonAddEducation.FlatAppearance.BorderSize = 0;
            this.ButtonAddEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddEducation.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddEducation.Location = new System.Drawing.Point(68, 280);
            this.ButtonAddEducation.Name = "ButtonAddEducation";
            this.ButtonAddEducation.Size = new System.Drawing.Size(169, 39);
            this.ButtonAddEducation.TabIndex = 6;
            this.ButtonAddEducation.Text = "Add";
            this.ButtonAddEducation.UseVisualStyleBackColor = false;
            this.ButtonAddEducation.Click += new System.EventHandler(this.ButtonAddEducation_Click);
            // 
            // ListViewEducation
            // 
            this.ListViewEducation.BackColor = System.Drawing.Color.Silver;
            this.ListViewEducation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnDegree,
            this.ColumnYear,
            this.ColumnUniversity,
            this.ColumnGrade});
            this.ListViewEducation.ForeColor = System.Drawing.Color.Black;
            this.ListViewEducation.Location = new System.Drawing.Point(68, 378);
            this.ListViewEducation.Name = "ListViewEducation";
            this.ListViewEducation.Size = new System.Drawing.Size(668, 257);
            this.ListViewEducation.TabIndex = 7;
            this.ListViewEducation.UseCompatibleStateImageBehavior = false;
            this.ListViewEducation.View = System.Windows.Forms.View.Details;
            // 
            // ColumnDegree
            // 
            this.ColumnDegree.Text = "Degree";
            this.ColumnDegree.Width = 241;
            // 
            // ColumnYear
            // 
            this.ColumnYear.Text = "Year";
            this.ColumnYear.Width = 93;
            // 
            // ColumnUniversity
            // 
            this.ColumnUniversity.Text = "University";
            this.ColumnUniversity.Width = 167;
            // 
            // ColumnGrade
            // 
            this.ColumnGrade.Text = "Grade";
            this.ColumnGrade.Width = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Education List :";
            // 
            // TextBoxGraduationYear
            // 
            this.TextBoxGraduationYear.Location = new System.Drawing.Point(519, 113);
            this.TextBoxGraduationYear.Name = "TextBoxGraduationYear";
            this.TextBoxGraduationYear.Size = new System.Drawing.Size(217, 29);
            this.TextBoxGraduationYear.TabIndex = 2;
            // 
            // EducationTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ListViewEducation);
            this.Controls.Add(this.ButtonAddEducation);
            this.Controls.Add(this.ComboBoxGraduationGrade);
            this.Controls.Add(this.TextBoxUniversityName);
            this.Controls.Add(this.TextBoxGraduationYear);
            this.Controls.Add(this.TextBoxDegreeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EducationTap";
            this.Size = new System.Drawing.Size(807, 731);
            this.Load += new System.EventHandler(this.EducationTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxDegreeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUniversityName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxGraduationGrade;
        private System.Windows.Forms.Button ButtonAddEducation;
        private System.Windows.Forms.ListView ListViewEducation;
        private System.Windows.Forms.ColumnHeader ColumnDegree;
        private System.Windows.Forms.ColumnHeader ColumnYear;
        private System.Windows.Forms.ColumnHeader ColumnUniversity;
        private System.Windows.Forms.ColumnHeader ColumnGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxGraduationYear;
    }
}

namespace CvBuilder
{
    partial class PersonalInfoTap
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
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumricAge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxMaritalState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxMilitaryState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.TextBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PictureBoxPersonalPhoto = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RadioButtonON = new System.Windows.Forms.RadioButton();
            this.RadioButtonOFF = new System.Windows.Forms.RadioButton();
            this.ButtonAddPhoto = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonDeletePhoto = new System.Windows.Forms.Button();
            this.ButtonUpdatePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumricAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPersonalPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(72, 104);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(299, 29);
            this.TextBoxFirstName.TabIndex = 1;
            this.TextBoxFirstName.TextChanged += new System.EventHandler(this.TextBoxFirstName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name :";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(72, 200);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(299, 29);
            this.TextBoxLastName.TabIndex = 1;
            this.TextBoxLastName.TextChanged += new System.EventHandler(this.TextBoxLastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(428, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age :";
            // 
            // NumricAge
            // 
            this.NumricAge.Location = new System.Drawing.Point(431, 199);
            this.NumricAge.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.NumricAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NumricAge.Name = "NumricAge";
            this.NumricAge.Size = new System.Drawing.Size(142, 29);
            this.NumricAge.TabIndex = 2;
            this.NumricAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(428, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Of Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(68, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Marital Statues :";
            // 
            // ComboBoxMaritalState
            // 
            this.ComboBoxMaritalState.FormattingEnabled = true;
            this.ComboBoxMaritalState.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.ComboBoxMaritalState.Location = new System.Drawing.Point(72, 308);
            this.ComboBoxMaritalState.Name = "ComboBoxMaritalState";
            this.ComboBoxMaritalState.Size = new System.Drawing.Size(297, 29);
            this.ComboBoxMaritalState.TabIndex = 4;
            this.ComboBoxMaritalState.TextChanged += new System.EventHandler(this.ComboBoxMaritalState_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(68, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Military Statues : ";
            // 
            // ComboBoxMilitaryState
            // 
            this.ComboBoxMilitaryState.FormattingEnabled = true;
            this.ComboBoxMilitaryState.Items.AddRange(new object[] {
            "Completed",
            "Exempted",
            "Not Served"});
            this.ComboBoxMilitaryState.Location = new System.Drawing.Point(72, 411);
            this.ComboBoxMilitaryState.Name = "ComboBoxMilitaryState";
            this.ComboBoxMilitaryState.Size = new System.Drawing.Size(297, 29);
            this.ComboBoxMilitaryState.TabIndex = 4;
            this.ComboBoxMilitaryState.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMilitaryState_SelectedIndexChanged);
            this.ComboBoxMilitaryState.TextChanged += new System.EventHandler(this.ComboBoxMilitaryState_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(428, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender :";
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ComboBoxGender.Location = new System.Drawing.Point(429, 307);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(302, 29);
            this.ComboBoxGender.TabIndex = 4;
            this.ComboBoxGender.TextChanged += new System.EventHandler(this.ComboBoxGender_TextChanged);
            // 
            // TextBoxDateOfBirth
            // 
            this.TextBoxDateOfBirth.Location = new System.Drawing.Point(432, 109);
            this.TextBoxDateOfBirth.Name = "TextBoxDateOfBirth";
            this.TextBoxDateOfBirth.Size = new System.Drawing.Size(299, 29);
            this.TextBoxDateOfBirth.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(428, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Preview :";
            this.label8.Visible = false;
            // 
            // PictureBoxPersonalPhoto
            // 
            this.PictureBoxPersonalPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxPersonalPhoto.Location = new System.Drawing.Point(432, 411);
            this.PictureBoxPersonalPhoto.Name = "PictureBoxPersonalPhoto";
            this.PictureBoxPersonalPhoto.Size = new System.Drawing.Size(151, 227);
            this.PictureBoxPersonalPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPersonalPhoto.TabIndex = 5;
            this.PictureBoxPersonalPhoto.TabStop = false;
            this.PictureBoxPersonalPhoto.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(68, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Personal Photo :";
            // 
            // RadioButtonON
            // 
            this.RadioButtonON.AutoSize = true;
            this.RadioButtonON.Location = new System.Drawing.Point(208, 469);
            this.RadioButtonON.Name = "RadioButtonON";
            this.RadioButtonON.Size = new System.Drawing.Size(53, 25);
            this.RadioButtonON.TabIndex = 6;
            this.RadioButtonON.Text = "ON";
            this.RadioButtonON.UseVisualStyleBackColor = true;
            this.RadioButtonON.CheckedChanged += new System.EventHandler(this.RadioButtonON_CheckedChanged);
            // 
            // RadioButtonOFF
            // 
            this.RadioButtonOFF.AutoSize = true;
            this.RadioButtonOFF.Checked = true;
            this.RadioButtonOFF.Location = new System.Drawing.Point(208, 510);
            this.RadioButtonOFF.Name = "RadioButtonOFF";
            this.RadioButtonOFF.Size = new System.Drawing.Size(56, 25);
            this.RadioButtonOFF.TabIndex = 6;
            this.RadioButtonOFF.TabStop = true;
            this.RadioButtonOFF.Text = "OFF";
            this.RadioButtonOFF.UseVisualStyleBackColor = true;
            this.RadioButtonOFF.CheckedChanged += new System.EventHandler(this.RadioButtonOFF_CheckedChanged);
            // 
            // ButtonAddPhoto
            // 
            this.ButtonAddPhoto.BackColor = System.Drawing.Color.Silver;
            this.ButtonAddPhoto.FlatAppearance.BorderSize = 0;
            this.ButtonAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddPhoto.Location = new System.Drawing.Point(599, 411);
            this.ButtonAddPhoto.Name = "ButtonAddPhoto";
            this.ButtonAddPhoto.Size = new System.Drawing.Size(132, 29);
            this.ButtonAddPhoto.TabIndex = 7;
            this.ButtonAddPhoto.Text = "Add Photo";
            this.ButtonAddPhoto.UseVisualStyleBackColor = false;
            this.ButtonAddPhoto.Visible = false;
            this.ButtonAddPhoto.Click += new System.EventHandler(this.ButtonAddPhoto_Click);
            // 
            // ButtonDeletePhoto
            // 
            this.ButtonDeletePhoto.BackColor = System.Drawing.Color.Maroon;
            this.ButtonDeletePhoto.FlatAppearance.BorderSize = 0;
            this.ButtonDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeletePhoto.ForeColor = System.Drawing.Color.White;
            this.ButtonDeletePhoto.Location = new System.Drawing.Point(599, 446);
            this.ButtonDeletePhoto.Name = "ButtonDeletePhoto";
            this.ButtonDeletePhoto.Size = new System.Drawing.Size(132, 29);
            this.ButtonDeletePhoto.TabIndex = 7;
            this.ButtonDeletePhoto.Text = "Delete";
            this.ButtonDeletePhoto.UseVisualStyleBackColor = false;
            this.ButtonDeletePhoto.Visible = false;
            this.ButtonDeletePhoto.Click += new System.EventHandler(this.ButtonDeletePhoto_Click);
            // 
            // ButtonUpdatePhoto
            // 
            this.ButtonUpdatePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonUpdatePhoto.FlatAppearance.BorderSize = 0;
            this.ButtonUpdatePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdatePhoto.Location = new System.Drawing.Point(599, 481);
            this.ButtonUpdatePhoto.Name = "ButtonUpdatePhoto";
            this.ButtonUpdatePhoto.Size = new System.Drawing.Size(132, 29);
            this.ButtonUpdatePhoto.TabIndex = 7;
            this.ButtonUpdatePhoto.Text = "Update";
            this.ButtonUpdatePhoto.UseVisualStyleBackColor = false;
            this.ButtonUpdatePhoto.Visible = false;
            this.ButtonUpdatePhoto.Click += new System.EventHandler(this.ButtonAddPhoto_Click);
            // 
            // PersonalInfoTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ButtonUpdatePhoto);
            this.Controls.Add(this.ButtonDeletePhoto);
            this.Controls.Add(this.ButtonAddPhoto);
            this.Controls.Add(this.RadioButtonOFF);
            this.Controls.Add(this.RadioButtonON);
            this.Controls.Add(this.PictureBoxPersonalPhoto);
            this.Controls.Add(this.ComboBoxMilitaryState);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.ComboBoxMaritalState);
            this.Controls.Add(this.NumricAge);
            this.Controls.Add(this.TextBoxDateOfBirth);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonalInfoTap";
            this.Size = new System.Drawing.Size(807, 731);
            this.Load += new System.EventHandler(this.PersonalInfoTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumricAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPersonalPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumricAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxMaritalState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxMilitaryState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.TextBox TextBoxDateOfBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PictureBoxPersonalPhoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RadioButtonON;
        private System.Windows.Forms.RadioButton RadioButtonOFF;
        private System.Windows.Forms.Button ButtonAddPhoto;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.Button ButtonDeletePhoto;
        private System.Windows.Forms.Button ButtonUpdatePhoto;
    }
}

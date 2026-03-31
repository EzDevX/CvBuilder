namespace CvBuilder
{
    partial class LanguagesTap
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
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAddLanguage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ListViewLanguages = new System.Windows.Forms.ListView();
            this.ColumnLanguageName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnLanguageLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBoxLanguageName = new System.Windows.Forms.TextBox();
            this.ComboBoxLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Language :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(400, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level :";
            // 
            // ButtonAddLanguage
            // 
            this.ButtonAddLanguage.BackColor = System.Drawing.Color.Silver;
            this.ButtonAddLanguage.FlatAppearance.BorderSize = 0;
            this.ButtonAddLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddLanguage.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddLanguage.Location = new System.Drawing.Point(68, 163);
            this.ButtonAddLanguage.Name = "ButtonAddLanguage";
            this.ButtonAddLanguage.Size = new System.Drawing.Size(169, 39);
            this.ButtonAddLanguage.TabIndex = 7;
            this.ButtonAddLanguage.Text = "Add";
            this.ButtonAddLanguage.UseVisualStyleBackColor = false;
            this.ButtonAddLanguage.Click += new System.EventHandler(this.ButtonAddLanguage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Languages List :";
            // 
            // ListViewLanguages
            // 
            this.ListViewLanguages.BackColor = System.Drawing.Color.Silver;
            this.ListViewLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnLanguageName,
            this.ColumnLanguageLevel});
            this.ListViewLanguages.ForeColor = System.Drawing.Color.Black;
            this.ListViewLanguages.Location = new System.Drawing.Point(68, 289);
            this.ListViewLanguages.Name = "ListViewLanguages";
            this.ListViewLanguages.Size = new System.Drawing.Size(668, 193);
            this.ListViewLanguages.TabIndex = 9;
            this.ListViewLanguages.UseCompatibleStateImageBehavior = false;
            this.ListViewLanguages.View = System.Windows.Forms.View.Details;
            // 
            // ColumnLanguageName
            // 
            this.ColumnLanguageName.Text = "Name";
            this.ColumnLanguageName.Width = 406;
            // 
            // ColumnLanguageLevel
            // 
            this.ColumnLanguageLevel.Text = "Level";
            this.ColumnLanguageLevel.Width = 96;
            // 
            // TextBoxLanguageName
            // 
            this.TextBoxLanguageName.Location = new System.Drawing.Point(68, 103);
            this.TextBoxLanguageName.Name = "TextBoxLanguageName";
            this.TextBoxLanguageName.Size = new System.Drawing.Size(319, 29);
            this.TextBoxLanguageName.TabIndex = 10;
            // 
            // ComboBoxLevel
            // 
            this.ComboBoxLevel.FormattingEnabled = true;
            this.ComboBoxLevel.Items.AddRange(new object[] {
            "Good",
            "Very Good",
            "Fluent",
            "Mother Tounge"});
            this.ComboBoxLevel.Location = new System.Drawing.Point(404, 103);
            this.ComboBoxLevel.Name = "ComboBoxLevel";
            this.ComboBoxLevel.Size = new System.Drawing.Size(332, 29);
            this.ComboBoxLevel.TabIndex = 3;
            // 
            // LanguagesTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TextBoxLanguageName);
            this.Controls.Add(this.ListViewLanguages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonAddLanguage);
            this.Controls.Add(this.ComboBoxLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LanguagesTap";
            this.Size = new System.Drawing.Size(807, 731);
            this.Load += new System.EventHandler(this.LanguagesTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAddLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView ListViewLanguages;
        private System.Windows.Forms.ColumnHeader ColumnLanguageName;
        private System.Windows.Forms.ColumnHeader ColumnLanguageLevel;
        private System.Windows.Forms.TextBox TextBoxLanguageName;
        private System.Windows.Forms.ComboBox ComboBoxLevel;
    }
}

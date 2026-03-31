namespace CvBuilder
{
    partial class PersonalSkillsTap
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
            this.TextBoxSkillTitle = new System.Windows.Forms.TextBox();
            this.ButtonAddSkill = new System.Windows.Forms.Button();
            this.ListBoxSkills = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title :";
            // 
            // TextBoxSkillTitle
            // 
            this.TextBoxSkillTitle.Location = new System.Drawing.Point(69, 97);
            this.TextBoxSkillTitle.Multiline = true;
            this.TextBoxSkillTitle.Name = "TextBoxSkillTitle";
            this.TextBoxSkillTitle.Size = new System.Drawing.Size(656, 58);
            this.TextBoxSkillTitle.TabIndex = 4;
            // 
            // ButtonAddSkill
            // 
            this.ButtonAddSkill.BackColor = System.Drawing.Color.Silver;
            this.ButtonAddSkill.FlatAppearance.BorderSize = 0;
            this.ButtonAddSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddSkill.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddSkill.Location = new System.Drawing.Point(69, 180);
            this.ButtonAddSkill.Name = "ButtonAddSkill";
            this.ButtonAddSkill.Size = new System.Drawing.Size(169, 39);
            this.ButtonAddSkill.TabIndex = 8;
            this.ButtonAddSkill.Text = "Add";
            this.ButtonAddSkill.UseVisualStyleBackColor = false;
            this.ButtonAddSkill.Click += new System.EventHandler(this.ButtonAddSkill_Click);
            // 
            // ListBoxSkills
            // 
            this.ListBoxSkills.BackColor = System.Drawing.Color.Silver;
            this.ListBoxSkills.FormattingEnabled = true;
            this.ListBoxSkills.ItemHeight = 21;
            this.ListBoxSkills.Location = new System.Drawing.Point(69, 308);
            this.ListBoxSkills.Name = "ListBoxSkills";
            this.ListBoxSkills.Size = new System.Drawing.Size(656, 214);
            this.ListBoxSkills.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(65, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skills List :";
            // 
            // PersonalSkillsTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ListBoxSkills);
            this.Controls.Add(this.ButtonAddSkill);
            this.Controls.Add(this.TextBoxSkillTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonalSkillsTap";
            this.Size = new System.Drawing.Size(807, 731);
            this.Load += new System.EventHandler(this.PersonalSkillsTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSkillTitle;
        private System.Windows.Forms.Button ButtonAddSkill;
        private System.Windows.Forms.ListBox ListBoxSkills;
        private System.Windows.Forms.Label label2;
    }
}

namespace CvBuilder
{
    partial class FinishingTap
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
            this.TextBoxFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSaveLocation = new System.Windows.Forms.TextBox();
            this.ButtonBrowseFiles = new System.Windows.Forms.Button();
            this.ButtonBuildAndSave = new System.Windows.Forms.Button();
            this.MySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name :";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Location = new System.Drawing.Point(68, 100);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Size = new System.Drawing.Size(576, 29);
            this.TextBoxFileName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save Location :";
            // 
            // TextBoxSaveLocation
            // 
            this.TextBoxSaveLocation.Location = new System.Drawing.Point(68, 201);
            this.TextBoxSaveLocation.Name = "TextBoxSaveLocation";
            this.TextBoxSaveLocation.Size = new System.Drawing.Size(576, 29);
            this.TextBoxSaveLocation.TabIndex = 3;
            // 
            // ButtonBrowseFiles
            // 
            this.ButtonBrowseFiles.BackColor = System.Drawing.Color.Silver;
            this.ButtonBrowseFiles.FlatAppearance.BorderSize = 0;
            this.ButtonBrowseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBrowseFiles.ForeColor = System.Drawing.Color.Black;
            this.ButtonBrowseFiles.Location = new System.Drawing.Point(650, 201);
            this.ButtonBrowseFiles.Name = "ButtonBrowseFiles";
            this.ButtonBrowseFiles.Size = new System.Drawing.Size(83, 30);
            this.ButtonBrowseFiles.TabIndex = 7;
            this.ButtonBrowseFiles.Text = "Browse";
            this.ButtonBrowseFiles.UseVisualStyleBackColor = false;
            this.ButtonBrowseFiles.Click += new System.EventHandler(this.ButtonBrowseFiles_Click);
            // 
            // ButtonBuildAndSave
            // 
            this.ButtonBuildAndSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonBuildAndSave.FlatAppearance.BorderSize = 0;
            this.ButtonBuildAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBuildAndSave.ForeColor = System.Drawing.Color.Black;
            this.ButtonBuildAndSave.Location = new System.Drawing.Point(260, 311);
            this.ButtonBuildAndSave.Name = "ButtonBuildAndSave";
            this.ButtonBuildAndSave.Size = new System.Drawing.Size(270, 70);
            this.ButtonBuildAndSave.TabIndex = 8;
            this.ButtonBuildAndSave.Text = "Build And Save";
            this.ButtonBuildAndSave.UseVisualStyleBackColor = false;
            this.ButtonBuildAndSave.Click += new System.EventHandler(this.ButtonBuildAndSave_Click);
            // 
            // FinishingTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ButtonBuildAndSave);
            this.Controls.Add(this.ButtonBrowseFiles);
            this.Controls.Add(this.TextBoxSaveLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxFileName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FinishingTap";
            this.Size = new System.Drawing.Size(807, 731);
            this.Load += new System.EventHandler(this.FinishingTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSaveLocation;
        private System.Windows.Forms.Button ButtonBrowseFiles;
        private System.Windows.Forms.Button ButtonBuildAndSave;
        private System.Windows.Forms.SaveFileDialog MySaveFileDialog;
    }
}

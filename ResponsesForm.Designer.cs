namespace CvBuilder
{
    partial class ResponsesForm
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
            this.ListBoxResponses = new System.Windows.Forms.ListBox();
            this.ButtonOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxResponses
            // 
            this.ListBoxResponses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxResponses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxResponses.FormattingEnabled = true;
            this.ListBoxResponses.HorizontalScrollbar = true;
            this.ListBoxResponses.ItemHeight = 21;
            this.ListBoxResponses.Location = new System.Drawing.Point(12, 11);
            this.ListBoxResponses.Name = "ListBoxResponses";
            this.ListBoxResponses.ScrollAlwaysVisible = true;
            this.ListBoxResponses.Size = new System.Drawing.Size(841, 420);
            this.ListBoxResponses.TabIndex = 0;
            // 
            // ButtonOkay
            // 
            this.ButtonOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOkay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOkay.Location = new System.Drawing.Point(12, 437);
            this.ButtonOkay.Name = "ButtonOkay";
            this.ButtonOkay.Size = new System.Drawing.Size(137, 32);
            this.ButtonOkay.TabIndex = 1;
            this.ButtonOkay.Text = "OK";
            this.ButtonOkay.UseVisualStyleBackColor = true;
            // 
            // ResponsesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 481);
            this.Controls.Add(this.ButtonOkay);
            this.Controls.Add(this.ListBoxResponses);
            this.MaximumSize = new System.Drawing.Size(869, 520);
            this.Name = "ResponsesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResponsesForm";
            this.Load += new System.EventHandler(this.ResponsesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxResponses;
        private System.Windows.Forms.Button ButtonOkay;
    }
}
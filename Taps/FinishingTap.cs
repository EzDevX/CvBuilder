using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvBuilder
{
    public partial class FinishingTap : UserControl
    {
        public FinishingTap()
        {
            InitializeComponent();
        }

        public Form1 MainForm;

        string FileNameLocation;

        public string FileName()
        {
            return FileNameLocation;
        }

        public void SetFileName(string Text)
        {
            TextBoxFileName.Text = Text;
        }

        public void SetLocationName(string Text)
        {
            
            TextBoxSaveLocation.Text = Text;
            FileNameLocation = Text;
        }


        private  void ButtonBuildAndSave_Click(object sender, EventArgs e)
        {
            
            ProgressBarFinishing.Visible = true;
            ButtonBuildAndSave.BackColor = Color.Gray;
            ButtonBuildAndSave.ForeColor = Color.FromArgb(64, 64, 64);
            ButtonBuildAndSave.Text = "Loading ...";
            ButtonBuildAndSave.Enabled = false;
            MainForm.Build();

            
            
        }

        private void ButtonBrowseFiles_Click(object sender, EventArgs e)
        {
            MySaveFileDialog.FileName = TextBoxFileName.Text;
            MySaveFileDialog.Filter = "Word File (*.docx)|*.docx";

            if(MySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileNameLocation = MySaveFileDialog.FileName;

                TextBoxSaveLocation.Text = FileNameLocation;
            }

        }

        public  void IncreaseProgressBar (string Text , int Volume)
        {
            System.Threading.Thread.Sleep(250);
            ProgressBarFinishing.Value += Volume;

        }

        public void ShutProgressBar()
        {
            ProgressBarFinishing.Visible = false;
            ProgressBarFinishing.Value = 0;
            ButtonBuildAndSave.BackColor = Color.FromArgb(0,192,0);
            ButtonBuildAndSave.ForeColor = Color.Black;
            ButtonBuildAndSave.Text = "Build And Save";
            ButtonBuildAndSave.Enabled = true;


        }

        public void DarkMode()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;

        }
        public void LightMode()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }

        private void FinishingTap_Load(object sender, EventArgs e)
        {
            
        }

        private void LabelFinishing_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxFileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

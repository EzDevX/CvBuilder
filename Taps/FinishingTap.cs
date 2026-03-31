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


        private void ButtonBuildAndSave_Click(object sender, EventArgs e)
        {
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
    }
}

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
    public partial class EducationTap : UserControl
    {
        public EducationTap()
        {
            InitializeComponent();
        }
        public Form1 MainForm;

        public List<csEducationInfo> EducationInfos()
        {
            List<csEducationInfo> EducationInfos = new List<csEducationInfo>();


            foreach(ListViewItem OneEducation in ListViewEducation.Items)
            {
                csEducationInfo Edu = new csEducationInfo();

                Edu.DegreeName = OneEducation.Text;
                Edu.Year = OneEducation.SubItems[1].Text;
                Edu.University = OneEducation.SubItems[2].Text;
                Edu.Grade = OneEducation.SubItems[3].Text;

                EducationInfos.Add(Edu);


            }

            return EducationInfos;
        }

        private void ButtonAddEducation_Click(object sender, EventArgs e)
        {
            ListViewItem EducationRecord = new ListViewItem(TextBoxDegreeName.Text);

            EducationRecord.SubItems.Add(TextBoxGraduationYear.Text);
            EducationRecord.SubItems.Add(TextBoxUniversityName.Text);
            EducationRecord.SubItems.Add(ComboBoxGraduationGrade.SelectedItem.ToString());

            ListViewEducation.Items.Add(EducationRecord);

            ListViewEducation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


        }

        public void AddToList(ListViewItem OneItem)
        {
            ListViewEducation.Items.Add(OneItem);

            ListViewEducation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        public void DarkMode()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;

            ListViewEducation.BackColor = Color.FromArgb(55, 55, 55);
            ListViewEducation.ForeColor = Color.White;

            ButtonAddEducation.BackColor = Color.FromArgb(55, 55, 55);
            ButtonAddEducation.ForeColor = Color.White;



        }
        public void LightMode()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;


            ListViewEducation.BackColor = Color.Silver;
            ListViewEducation.ForeColor = Color.Black;

            ButtonAddEducation.BackColor = Color.Silver;
            ButtonAddEducation.ForeColor = Color.Black;
        }

        private void EducationTap_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

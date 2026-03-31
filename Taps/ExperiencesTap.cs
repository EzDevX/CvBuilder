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
    public partial class ExperiencesTap : UserControl
    {
        public ExperiencesTap()
        {
            InitializeComponent();
        }
        public Form1 MainForm;
        private ResponsesForm MyForm = new ResponsesForm();


        private List<List<string>> Responses = new List<List<string>>();

        private void AddOneResponses(string[] Lines)
        {
            List<string> OneResponses = new List<string>();

            foreach (string OneLine in Lines)
            {
                OneResponses.Add(OneLine);
            }

            Responses.Add(OneResponses);
        }

        public List<csExperienceInfo> ExperiencesInfos()
        {
            List<csExperienceInfo> Experiences = new List<csExperienceInfo>();


            int Counter = 0;

            foreach(ListViewItem OneExperinceItem in ListViewExperiences.Items)
            {
                
                csExperienceInfo OneExp = new csExperienceInfo();

                OneExp.Title = OneExperinceItem.Text;
                OneExp.Company = OneExperinceItem.SubItems[1].Text;
                OneExp.FromDate = OneExperinceItem.SubItems[2].Text;
                OneExp.ToDate = OneExperinceItem.SubItems[3].Text;
                OneExp.Responses = Responses[Counter];
                

                Experiences.Add(OneExp);

                Counter++;

            }

            return Experiences;



        }

        public void AddToList(ListViewItem OneItem)
        {
            ListViewExperiences.Items.Add(OneItem);
            ListViewExperiences.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        public void AddToResponses(List<string> Data)
        {
            Responses.Add(Data);
        }

        public void DarkMode()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;

            ListViewExperiences.BackColor = Color.FromArgb(55, 55, 55);
            ListViewExperiences.ForeColor = Color.White;

            TextBoxResposes.BackColor  = Color.FromArgb(55, 55, 55);
            TextBoxResposes.ForeColor = Color.White;

            ButtonAddExperience.BackColor = Color.FromArgb(55, 55, 55);
            ButtonAddExperience.ForeColor = Color.White;

        }
        public void LightMode()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;

            ListViewExperiences.BackColor = Color.Silver;
            ListViewExperiences.ForeColor = Color.Black;

            TextBoxResposes.BackColor = Color.White;
            TextBoxResposes.ForeColor = Color.Black;

            ButtonAddExperience.BackColor = Color.Silver;
            ButtonAddExperience.ForeColor = Color.Black;


        }

        private void ExperiencesTap_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonAddExperience_Click(object sender, EventArgs e)
        {
            ListViewItem ExperienceRecord = new ListViewItem(TextBoxJobTitle.Text);

            ExperienceRecord.SubItems.Add(TextBoxCompanyName.Text);
            ExperienceRecord.SubItems.Add(TextBoxFromDate.Text);
            ExperienceRecord.SubItems.Add(TextBoxToDate.Text);

            AddOneResponses(TextBoxResposes.Lines);

            ListViewExperiences.Items.Add(ExperienceRecord);
            ListViewExperiences.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void ListViewExperiences_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem SelectedItem = ((ListView)sender).SelectedItems[0];

            foreach(string OneLine in Responses[SelectedItem.Index])
            {
                MyForm.AddToList(OneLine);
            }

            if(MyForm.ShowDialog() == DialogResult.OK)
            {
                MyForm.ClearList();
                
                
            }
            



        }
    }
}

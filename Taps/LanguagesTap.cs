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
    public partial class LanguagesTap : UserControl
    {
        public LanguagesTap()
        {
            InitializeComponent();
        }
        public Form1 MainForm;

        public bool IsEmpty()
        {
            if(ListViewLanguages.Items.Count == 0)
            {
                return true;
            }
            return false;
        }

        public List<csLanguageInfo> Languages()
        {
            List<csLanguageInfo> AllLanguages = new List<csLanguageInfo>();

            foreach(ListViewItem OneLanguageItem in ListViewLanguages.Items)
            {
                csLanguageInfo OneLanguage = new csLanguageInfo();

                OneLanguage.Name = OneLanguageItem.Text;
                OneLanguage.Level = OneLanguageItem.SubItems[1].Text;

                AllLanguages.Add(OneLanguage);

            }



            return AllLanguages;

        }

        public void AddToList(ListViewItem OneItem)
        {
            ListViewLanguages.Items.Add(OneItem);
            ListViewLanguages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        public void DarkMode()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            ComboBoxLevel.BackColor = Color.FromArgb(55, 55, 55);
            ComboBoxLevel.ForeColor = Color.White;

            ListViewLanguages.BackColor = Color.FromArgb(55, 55, 55);
            ListViewLanguages.ForeColor = Color.White;

            ButtonAddLanguage.BackColor = Color.FromArgb(55, 55, 55);
            ButtonAddLanguage.ForeColor = Color.White;

        }
        public void LightMode()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            ComboBoxLevel.BackColor = Color.Silver;
            ComboBoxLevel.ForeColor = Color.Black;


            ListViewLanguages.BackColor = Color.Silver;
            ListViewLanguages.ForeColor = Color.Black;

            ButtonAddLanguage.BackColor = Color.Silver;
            ButtonAddLanguage.ForeColor = Color.Black;
        }

        private void LanguagesTap_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddLanguage_Click(object sender, EventArgs e)
        {
            ListViewItem LanguageRecord = new ListViewItem(TextBoxLanguageName.Text);

            LanguageRecord.SubItems.Add(ComboBoxLevel.SelectedItem.ToString());

            ListViewLanguages.Items.Add(LanguageRecord);
            ListViewLanguages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void ComboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxLevel_TextChanged(object sender, EventArgs e)
        {
            ComboBoxLevel.Text = "";
        }
    }
}

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
    public partial class CoursesAndCertificatesTap : UserControl
    {
        public CoursesAndCertificatesTap()
        {
            InitializeComponent();
        }
        public Form1 MainForm;

        public bool IsEmpty()
        {
            if(ListViewCertificates.Items.Count == 0)
            {
                return true;
            }
            return false;
        }

        public List<csCertificatInfo> Certificates()
        {
            List<csCertificatInfo> AllCertificates = new List<csCertificatInfo>();


            foreach(ListViewItem OneItem in ListViewCertificates.Items)
            {
                csCertificatInfo OneCertificate = new csCertificatInfo();

                OneCertificate.Name = OneItem.Text;
                OneCertificate.Institute = OneItem.SubItems[1].Text;
                OneCertificate.DateObtained = OneItem.SubItems[2].Text;

                AllCertificates.Add(OneCertificate);
            }

            return AllCertificates;


        }

        private void ButtonAddCertificate_Click(object sender, EventArgs e)
        {

            ListViewItem NewCertificate = new ListViewItem(TextBoxCertificateName.Text);

            NewCertificate.SubItems.Add (TextBoxInstituteName.Text);
            NewCertificate.SubItems.Add (TextBoxDateObtained.Text);


            ListViewCertificates.Items.Add(NewCertificate);
            ListViewCertificates.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        public void AddToList (ListViewItem NewItem)
        {
            ListViewCertificates.Items.Add(NewItem);
            ListViewCertificates.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        public void DarkMode()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;

            ListViewCertificates.BackColor = Color.FromArgb(55, 55, 55);
            ListViewCertificates.ForeColor = Color.White;

            ButtonAddCertificate.BackColor = Color.FromArgb(55, 55, 55);
            ButtonAddCertificate.ForeColor = Color.White;

        }
        public void LightMode()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;

            ListViewCertificates.BackColor = Color.Silver;
            ListViewCertificates.ForeColor = Color.Black;


            ButtonAddCertificate.BackColor = Color.Silver;
            ButtonAddCertificate.ForeColor = Color.Black;

        }

        private void CoursesAndCertificatesTap_Load(object sender, EventArgs e)
        {

        }
    }
}

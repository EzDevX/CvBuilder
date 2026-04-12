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
    public partial class ContactInfoTap : UserControl
    {
        public ContactInfoTap()
        {
            InitializeComponent();
        }
        public Form1 MainForm;

        public bool IsEmpty()
        {
            if(TextBoxFirstPhoneNumber.Text == ""
                ||TextBoxCity.Text == ""
                || TextBoxCountry.Text == ""
                || TextBoxSecondPhoneNumber.Text == ""
                || TextBoxEmail.Text == "")
            {
                return true;
            }
            return false;
        }

        public csContactInfo ContactInfo()
        {
            csContactInfo MyContactInfo = new csContactInfo();
            MyContactInfo.City = TextBoxCity.Text;
            MyContactInfo.Country = TextBoxCountry.Text;
            MyContactInfo.Email = TextBoxEmail.Text;
            MyContactInfo.FirstPhoneNumber = TextBoxFirstPhoneNumber.Text;
            MyContactInfo.SecondPhoneNumber = TextBoxSecondPhoneNumber.Text;

            return MyContactInfo;
        }

        public void FirstPhoneNumber(string PhoneNumberOne)
        {
            TextBoxFirstPhoneNumber.Text = PhoneNumberOne;
        }
        public void SecondPhoneNumber(string PhoneNumberTwo)
        {
            TextBoxSecondPhoneNumber.Text = PhoneNumberTwo;
        }
        public void City(string City)
        {
            TextBoxCity.Text = City;
        }
        
        public void Country(string Country)
        {
            TextBoxCountry.Text = Country;
        }
        public void Email(string Email)
        {
            TextBoxEmail.Text = Email;

        }

        public void LightMode()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
        }

        public void DarkMode()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }

        private void ContactInfoTap_Load(object sender, EventArgs e)
        {

        }
    }
}

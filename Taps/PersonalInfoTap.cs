using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CvBuilder
{
    public partial class PersonalInfoTap : UserControl
    {
        public PersonalInfoTap()
        {
            InitializeComponent();
        }

        public bool Flag = false;

        public bool IsPersonalPhoto = false;
        public Image MyPersonlPhoto;

        public bool IsEmpty()
        {
            if(TextBoxFirstName.Text == ""
                || TextBoxLastName.Text == ""
                || TextBoxDateOfBirth.Text == ""
                || ComboBoxGender.Text == ""
                || ComboBoxMaritalState.Text == ""
                || ComboBoxMilitaryState.Text == ""
                )
            {
                return true;
            }
            return false;
        }

        public Form1 MainForm;

        public csPersonalInfo PersonalInfo()
        {
            csPersonalInfo MyPersonalInfo = new csPersonalInfo();

            MyPersonalInfo.Age = NumricAge.Value.ToString();
            MyPersonalInfo.DateOfBirth = TextBoxDateOfBirth.Text;
            MyPersonalInfo.FirstName = TextBoxFirstName.Text;
            MyPersonalInfo.LastName = TextBoxLastName.Text;
            MyPersonalInfo.Gender = ComboBoxGender.SelectedItem?.ToString();
            MyPersonalInfo.MaritalState = ComboBoxMaritalState.SelectedItem?.ToString();
            MyPersonalInfo.MilitartState = ComboBoxMilitaryState.SelectedItem?.ToString();
            if (IsPersonalPhoto)
            {
                MyPersonalInfo.IsPersonalPhoto = true;
                MyPersonalInfo.PersonalPhoto = MyPersonlPhoto;
            }

            return MyPersonalInfo;


        }

        public void FirstName(string FirstName)
        {
            TextBoxFirstName.Text = FirstName;
        }
        public void LastName(string LastName)
        {
            TextBoxLastName.Text = LastName;
        }
        public void DateOfBirth(string DateOfBirth)
        {
            TextBoxDateOfBirth.Text = DateOfBirth;
        }
        public void MaritalStatus(string Current)
        {
            ComboBoxMaritalState.SelectedItem = Current;

        }
        public void MilitaryState(string Current)
        {
            ComboBoxMilitaryState.SelectedItem = Current;
        }
        public void Gender(string Gender)
        {
            ComboBoxGender.SelectedItem = Gender;
        }
        public void Age(int Age)
        {
            NumricAge.Value = Age;
        }

        public void DarkMode()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            ComboBoxGender.BackColor = Color.FromArgb(55, 55, 55);
            ComboBoxMaritalState.BackColor = Color.FromArgb(55, 55, 55);
            ComboBoxMilitaryState.BackColor = Color.FromArgb(55, 55, 55);
            ComboBoxGender.ForeColor = Color.White;
            ComboBoxMaritalState.ForeColor = Color.White;
            ComboBoxMilitaryState.ForeColor = Color.White;



            RadioButtonOFF.ForeColor = Color.White;
            RadioButtonON.ForeColor = Color.White;

            ButtonAddPhoto.BackColor = Color.FromArgb(55, 55, 55);
            ButtonAddPhoto.ForeColor = Color.White;

        }
        public void LightMode()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            ComboBoxGender.BackColor = Color.Silver;
            ComboBoxMaritalState.BackColor = Color.Silver;
            ComboBoxMilitaryState.BackColor = Color.Silver;
            ComboBoxGender.ForeColor = Color.Black;
            ComboBoxMaritalState.ForeColor = Color.Black;
            ComboBoxMilitaryState.ForeColor = Color.Black;

            RadioButtonOFF.ForeColor = Color.Black;
            RadioButtonON.ForeColor = Color.Black;

            ButtonAddPhoto.BackColor = Color.Silver;
            ButtonAddPhoto.ForeColor = Color.Black;

        }

        public void SetPersonalPhoto(string FileName)
        {
            RadioButtonON.Checked = true;
            IsPersonalPhoto = true;

            using (Image NewImage = Image.FromFile(FileName))
            {
                MyPersonlPhoto = new Bitmap(NewImage);
                PictureBoxPersonalPhoto.Image = MyPersonlPhoto;
            }


        }

        private void PersonalInfoTap_Load(object sender, EventArgs e)
        {

        }

        private void RadioButtonON_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            PictureBoxPersonalPhoto.Visible = true;
            ButtonAddPhoto.Visible = true;
            IsPersonalPhoto = true;
        }

        private void RadioButtonOFF_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            PictureBoxPersonalPhoto.Image = null;
            PictureBoxPersonalPhoto.Visible = false;
            ButtonAddPhoto.Visible = false;
            IsPersonalPhoto = false;
        }

        private void ButtonAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "JPG Files! (*.jpg)|*.jpg|PNG Files! (*.png)|*.png|JPEG Files! (*.jpeg)|*.jpeg";
            OpenFileDialog1.Multiselect = false;

            if(OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Image NewImage = Image.FromFile(OpenFileDialog1.FileName))
                {
                    MyPersonlPhoto = new Bitmap(NewImage);
                    PictureBoxPersonalPhoto.Image = MyPersonlPhoto;
                }

            }

        }

        private void TextBoxLastName_TextChanged(object sender, EventArgs e)
        {

             MainForm.UpdateFileName(TextBoxFirstName.Text + "_" + TextBoxLastName.Text + "_" + "CV");
            MainForm.UpdateLocationName(TextBoxFirstName.Text + "_" + TextBoxLastName.Text + "_" + "CV.docx");
        }

        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            MainForm.UpdateFileName(TextBoxFirstName.Text + "_" + TextBoxLastName.Text + "_" + "CV");
            MainForm.UpdateLocationName(TextBoxFirstName.Text + "_" + TextBoxLastName.Text + "_" + "CV.docx");

        }

        private void ComboBoxMaritalState_TextChanged(object sender, EventArgs e)
        {
            if (!Flag)
            {
                ComboBoxMaritalState.Text = "";

            }
        }

        private void ComboBoxGender_TextChanged(object sender, EventArgs e)
        {
            if (!Flag)
            {
                ComboBoxGender.Text = "";

            }
        }

        private void ComboBoxMilitaryState_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxMilitaryState_TextChanged(object sender, EventArgs e)
        {
            if (!Flag)
            {
                ComboBoxMilitaryState.Text = "";

            }
        }
    }
}

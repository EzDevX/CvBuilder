using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;





namespace CvBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
        }
        private string SettingsFileName = "Settings.txt";

        class csSettings
        {
            public bool IsNightMode = false;
        }

        csSettings Settings = new csSettings();
          
        public enum enTaps
        {
             enPersonalInfoTap = 1 , enContactInfoTap = 2 ,
             enEducationTap = 3 , enExperienceTap = 4 ,
             enCoursesAndCertificatesTap = 5 ,
             enLanguagesTap = 6 , enPersonalSkillsTap = 7 ,
             enFinishingTap = 8
        };

        PersonalInfoTap MyPersonalInfoTap = new PersonalInfoTap();
        ContactInfoTap MyContactInfoTap = new ContactInfoTap();
        EducationTap MyEducationTap = new EducationTap();
        ExperiencesTap MyExperienceTap = new ExperiencesTap();
        CoursesAndCertificatesTap MyCoursesTap = new CoursesAndCertificatesTap();
        LanguagesTap MyLanguagesTap = new LanguagesTap();
        PersonalSkillsTap MyPersonalSkillsTap = new PersonalSkillsTap();
        FinishingTap MyFinishingTap = new FinishingTap();
        
        
        public bool IsEmpty()
        {
            if(MyContactInfoTap.IsEmpty() || MyCoursesTap.IsEmpty() || MyEducationTap.IsEmpty() || MyExperienceTap.IsEmpty() || MyLanguagesTap.IsEmpty() || MyPersonalInfoTap.IsEmpty() || MyPersonalSkillsTap.IsEmpty())
            {
                return true;
            }
            return false;
        }

        public csPerson FillPeroson()
        {
            csPerson MyPerson = new csPerson();

            MyPerson.PersonalInfo = MyPersonalInfoTap.PersonalInfo();
            MyPerson.ContactInfo = MyContactInfoTap.ContactInfo();
            MyPerson.EducationsInfo = MyEducationTap.EducationInfos();
            MyPerson.Experiences = MyExperienceTap.ExperiencesInfos();
            MyPerson.CertificatesAndCoursesInfo = MyCoursesTap.Certificates();
            MyPerson.LanguagesInfo = MyLanguagesTap.Languages();
            MyPerson.PersonalSkillsInfo = MyPersonalSkillsTap.Skills();
            


            return MyPerson;



        }

        public void UpdateFileName(string Text)
        {
            MyFinishingTap.SetFileName(Text);
        }

        public void UpdateLocationName(string Text)
        {
            MyFinishingTap.SetLocationName(Text);

        }

        public void IncreaseProgress(string Text , int Volume)
        {
            MyFinishingTap.IncreaseProgressBar(Text, Volume);
        }

        public void ShutProgressBar()
        {
            MyFinishingTap.ShutProgressBar();
        }

        public void Build()
        {
            IncreaseProgress("Gathering Data", 20);

            if (IsEmpty())
            {
                if(MessageBox.Show("Fill All Required Data First !", "Missing Data!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    ShutProgressBar();
                }
                
            }
            else
            {
                csPerson MyPerson = FillPeroson();

                Engine MyEngine = new Engine();
                MyEngine.MainForm = this;

                MyEngine.LunchCV(MyPerson, MyFinishingTap.FileName() , Engine.enDesigns.enClean);

                if (MessageBox.Show("Your CV is Ready!", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ShutProgressBar();
                }
            }




        }

        private void AutoFillForm()
        {
            MyPersonalInfoTap.Flag = true;
            MyPersonalInfoTap.FirstName("Daniel");
            MyPersonalInfoTap.LastName("Alexander Morgan");
            MyPersonalInfoTap.DateOfBirth("14 March 1996");
            MyPersonalInfoTap.Age(29);
            MyPersonalInfoTap.Gender("Male");
            MyPersonalInfoTap.MaritalStatus("Single");
            MyPersonalInfoTap.MilitaryState("Exempted");
            MyPersonalInfoTap.SetPersonalPhoto(@"D:\Repos\CvBuilder\BahgatSaber.png");
            MyPersonalInfoTap.Flag = false;



            MyContactInfoTap.FirstPhoneNumber("+1 202 555 0147");
            MyContactInfoTap.SecondPhoneNumber("+1 202 555 0198");
            MyContactInfoTap.City("Boston, Massachusetts");
            MyContactInfoTap.Country("USA");
            MyContactInfoTap.Email("daniel.morgan.dev@gmail.com");





            ListViewItem FirstEducationItem = new ListViewItem("Bachelor of Computer Science");
            FirstEducationItem.SubItems.Add("2018");
            FirstEducationItem.SubItems.Add("University of California, Los Angeles");
            FirstEducationItem.SubItems.Add("Very Good");
            
            ListViewItem SecondEducationItem = new ListViewItem("Diploma in Software Engineering");
            SecondEducationItem.SubItems.Add("2019");
            SecondEducationItem.SubItems.Add("Boston Technical Institute");
            SecondEducationItem.SubItems.Add("Excellent");
            
            MyEducationTap.AddToList(FirstEducationItem);
            MyEducationTap.AddToList(SecondEducationItem);





            ListViewItem FirstExperienceItem = new ListViewItem("Junior Software Developer");
            FirstExperienceItem.SubItems.Add("BrightTech Solutions");
            FirstExperienceItem.SubItems.Add("Jan 2018");
            FirstExperienceItem.SubItems.Add("Dec 2018");

            List<string> FirstExperienceResponses = new List<string>();
            FirstExperienceResponses.Add("1 - Assisted in developing internal desktop tools");
            FirstExperienceResponses.Add("2 - Fixed bugs and improved application performance");
            FirstExperienceResponses.Add("3 - Wrote technical documentation");



            ListViewItem SecondExperienceItem = new ListViewItem("Software Developer");
            SecondExperienceItem.SubItems.Add("BrightTech Solutions");
            SecondExperienceItem.SubItems.Add("Jan 2019");
            SecondExperienceItem.SubItems.Add("Dec 2022");

            List<string> SecondExperienceResponses = new List<string>();
            SecondExperienceResponses.Add("1 - Developed Windows Forms applications using C#");
            SecondExperienceResponses.Add("2 - Designed and managed SQL Server databases");
            SecondExperienceResponses.Add("3- Integrated third - party APIs");
            SecondExperienceResponses.Add("4 - Participated in Agile sprints");


            ListViewItem ThirdExperienceItem = new ListViewItem("Senior Software Developer");
            ThirdExperienceItem.SubItems.Add("Nova Systems");
            ThirdExperienceItem.SubItems.Add("Jan 2023");
            ThirdExperienceItem.SubItems.Add("Present");

            List<string> ThirdExperienceResponses = new List<string>();
            ThirdExperienceResponses.Add("1 - Leading backend development team");
            ThirdExperienceResponses.Add("2 - Designing scalable system architecture");
            ThirdExperienceResponses.Add("3 - Building RESTful APIs using .NET");
            ThirdExperienceResponses.Add("4 - Conducting code reviews");
            ThirdExperienceResponses.Add("5 - Mentoring junior developers");



            MyExperienceTap.AddToList(FirstExperienceItem);
            MyExperienceTap.AddToResponses(FirstExperienceResponses);
            MyExperienceTap.AddToList(SecondExperienceItem);
            MyExperienceTap.AddToResponses(SecondExperienceResponses);
            MyExperienceTap.AddToList(ThirdExperienceItem);
            MyExperienceTap.AddToResponses(ThirdExperienceResponses);







            ListViewItem FirstCertificateItem = new ListViewItem("Advanced C# Programming");
            FirstCertificateItem.SubItems.Add("Udemy");
            FirstCertificateItem.SubItems.Add("June 2020");

            ListViewItem SecondCertificateItem = new ListViewItem("ASP.NET Core Web Development");
            SecondCertificateItem.SubItems.Add("Coursera");
            SecondCertificateItem.SubItems.Add("September 2021");

            ListViewItem ThirdCertificateItem = new ListViewItem("Microsoft SQL Server Administration");
            ThirdCertificateItem.SubItems.Add("Pluralsight");
            ThirdCertificateItem.SubItems.Add("February 2022");

            ListViewItem FourthCertificateItem = new ListViewItem("Azure Fundamentals (AZ-900)");
            FourthCertificateItem.SubItems.Add("Microsoft");
            FourthCertificateItem.SubItems.Add("November 2023");


            MyCoursesTap.AddToList(FirstCertificateItem);
            MyCoursesTap.AddToList(SecondCertificateItem);
            MyCoursesTap.AddToList(ThirdCertificateItem);
            MyCoursesTap.AddToList(FourthCertificateItem);







            ListViewItem FirstLanguageItem = new ListViewItem("English");
            FirstLanguageItem.SubItems.Add("Mother Tongue");

            ListViewItem SecondLanguageItem = new ListViewItem("Spanish");
            SecondLanguageItem.SubItems.Add("Very Good");

            ListViewItem ThirdLanguageItem = new ListViewItem("French");
            ThirdLanguageItem.SubItems.Add("Good");


            MyLanguagesTap.AddToList(FirstLanguageItem);
            MyLanguagesTap.AddToList(SecondLanguageItem);
            MyLanguagesTap.AddToList(ThirdLanguageItem);








            MyPersonalSkillsTap.AddToList("Problem Solving");
            MyPersonalSkillsTap.AddToList("Analytical Thinking");
            MyPersonalSkillsTap.AddToList("Team Leadership");
            MyPersonalSkillsTap.AddToList("Time Management");
            MyPersonalSkillsTap.AddToList("Communication Skills");
            MyPersonalSkillsTap.AddToList("Adaptability");
            MyPersonalSkillsTap.AddToList("Attention to Detail");
            MyPersonalSkillsTap.AddToList("Critical Thinking");
            MyPersonalSkillsTap.AddToList("Analytical Thinking");








        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ApplySettings();
            ShowTaps(enTaps.enPersonalInfoTap);
        }

        private void ShowTaps(enTaps TapName)
        {
            PanelTaps.Controls.Clear();

            switch (TapName)
            {
                case enTaps.enPersonalInfoTap:
                    
                    MyPersonalInfoTap.MainForm = this;
                    PanelTaps.Controls.Add(MyPersonalInfoTap);
                    MyPersonalInfoTap.Dock = DockStyle.Fill;
                    break;

                case enTaps.enContactInfoTap:
                    MyContactInfoTap.MainForm = this;
                    PanelTaps.Controls.Add(MyContactInfoTap);
                    MyContactInfoTap.Dock = DockStyle.Fill;
                    break;

                case enTaps.enEducationTap:
                    MyEducationTap.MainForm = this;
                    PanelTaps.Controls.Add(MyEducationTap);
                    MyEducationTap.Dock = DockStyle.Fill;
                    break;

                case enTaps.enExperienceTap:
                    MyExperienceTap.MainForm = this;
                    PanelTaps.Controls.Add(MyExperienceTap);
                    MyExperienceTap.Dock = DockStyle.Fill;
                    break;

                case enTaps.enCoursesAndCertificatesTap:
                    MyCoursesTap.MainForm = this;
                    PanelTaps.Controls.Add(MyCoursesTap);
                    MyCoursesTap.Dock = DockStyle.Fill;
                    break;

                case enTaps.enLanguagesTap:
                    MyLanguagesTap.MainForm = this;
                    PanelTaps.Controls.Add(MyLanguagesTap);
                    MyLanguagesTap.Dock = DockStyle.Fill;
                    break;

                case enTaps.enPersonalSkillsTap:
                    MyPersonalSkillsTap.MainForm = this;
                    PanelTaps.Controls.Add(MyPersonalSkillsTap);
                    MyPersonalSkillsTap.Dock = DockStyle.Fill;
                    break;

                case enTaps.enFinishingTap:
                    MyFinishingTap.MainForm = this;
                    PanelTaps.Controls.Add(MyFinishingTap);
                    MyFinishingTap.Dock = DockStyle.Fill;
                    break;

            }

        }

        private csSettings ConvertListSettingsToClass(List<string> ListSettings)
        {
            csSettings Settings = new csSettings();
            if(ListSettings[0] == "IsNightMode = true")
            {
                Settings.IsNightMode = true;
            }
            else if(ListSettings[0] == "IsNightMode = false")
            {
                Settings.IsNightMode = false;
            }
            return Settings;
        }

        private string ConvertSettingsClassToString(csSettings Settings)
        {
            string Line = "";

            if (Settings.IsNightMode)
            {
                Line += "IsNightMode = true";
            }
            if(Settings.IsNightMode == false)
            {
                Line += "IsNightMode = false";
            }

            return Line;

        }

        private void LoadSettingsFromFile()
        {
            List<string> SettingsLine = File.ReadAllLines(SettingsFileName).ToList();
            Settings = ConvertListSettingsToClass(SettingsLine);
        }

        private void UpdateSettingsToFile()
        {
            string Line = ConvertSettingsClassToString(Settings);
            File.WriteAllText(SettingsFileName, Line);
        }

        private void NightMode()
        {
            
            Settings.IsNightMode = true;

            BackColor = Color.FromArgb(30, 30, 30);

            PanelList.BackColor = Color.FromArgb(55, 55, 55);
            menuStrip1.BackColor = Color.Goldenrod;
            ButtonPersonalInfo.ForeColor = Color.Goldenrod;
            ButtonContactInfo.ForeColor = Color.Goldenrod;
            ButtonCorssAndCers.ForeColor = Color.Goldenrod;
            ButtonEducation.ForeColor = Color.Goldenrod;
            ButtonExperience.ForeColor = Color.Goldenrod;
            ButtonFinishing.ForeColor = Color.Goldenrod;
            ButtonLanguages.ForeColor = Color.Goldenrod;
            ButtonPersonalSkills.ForeColor = Color.Goldenrod;




            MyContactInfoTap.DarkMode();
            MyCoursesTap.DarkMode();
            MyEducationTap.DarkMode();
            MyExperienceTap.DarkMode();
            MyFinishingTap.DarkMode();
            MyLanguagesTap.DarkMode();
            MyPersonalInfoTap.DarkMode();
            MyPersonalSkillsTap.DarkMode();


            
        }
        private void LightMode()
        {
            Settings.IsNightMode = false;


            BackColor = Color.White;


            PanelList.BackColor = Color.Silver;
            menuStrip1.BackColor = Color.NavajoWhite;
            ButtonPersonalInfo.ForeColor = Color.Black;
            ButtonContactInfo.ForeColor = Color.Black;
            ButtonCorssAndCers.ForeColor = Color.Black;
            ButtonEducation.ForeColor = Color.Black;
            ButtonExperience.ForeColor = Color.Black;
            ButtonFinishing.ForeColor = Color.Black;
            ButtonLanguages.ForeColor = Color.Black;
            ButtonPersonalSkills.ForeColor = Color.Black;






            MyContactInfoTap.LightMode();
            MyCoursesTap.LightMode();
            MyEducationTap.LightMode();
            MyExperienceTap.LightMode();
            MyFinishingTap.LightMode();
            MyLanguagesTap.LightMode();
            MyPersonalInfoTap.LightMode();
            MyPersonalSkillsTap.LightMode();
        }

        private void ApplySettings()
        {
            LoadSettingsFromFile();

            if (Settings.IsNightMode)
            {
                NightMode();
            }
            else if(Settings.IsNightMode == false)
            {
                LightMode();
            }
        }

        private void ButtonPersonalInfo_Click(object sender, EventArgs e)
        {

            ShowTaps(enTaps.enPersonalInfoTap);

        }

        private void ButtonContactInfo_Click(object sender, EventArgs e)
        {
            ShowTaps(enTaps.enContactInfoTap);
        }

        private void ButtonEducation_Click(object sender, EventArgs e)
        {
            ShowTaps(enTaps.enEducationTap);
        }

        private void ButtonExperience_Click(object sender, EventArgs e)
        {
            ShowTaps(enTaps.enExperienceTap);
        }

        private void ButtonCorssAndCers_Click(object sender, EventArgs e)
        {
            ShowTaps(enTaps.enCoursesAndCertificatesTap);
        }

        private void ButtonLanguages_Click(object sender, EventArgs e)
        {
            ShowTaps(enTaps.enLanguagesTap);
        }

        private void ButtonPersonalSkills_Click(object sender, EventArgs e)
        {
            ShowTaps(enTaps.enPersonalSkillsTap);
        }

        private void ButtonFinishing_Click(object sender, EventArgs e)
        {
            ShowTaps(enTaps.enFinishingTap);
        }

        private void PanelTaps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShortcutPressed(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.F)
            {
                AutoFillForm();
            }
        }

        private void PanelList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NightMode();
        }

        private void dayModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LightMode();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateSettingsToFile();
        }
    }
}

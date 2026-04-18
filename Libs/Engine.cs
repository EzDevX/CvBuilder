using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvBuilder
{
    public class Engine
    {

        public Form1 MainForm;

        public enum enDesigns
        {
            enDefault = 1 , enClean = 2
        };

        void BuildDefault(csPerson Person, string FileName)
        {
            MainForm.IncreaseProgress("Preparing Fonts and Margins!", 10);

            WORD MyWordFile = new WORD(FileName);

            MyWordFile.ChangeMargin(WORD.enMargin.enNarrow);
            MyWordFile.RemoveProofing();

            WORD.csFontSettings HeaderSet = new WORD.csFontSettings();

            HeaderSet.Alienment = WORD.enAlienment.enCenter;
            HeaderSet.Bold = true;
            HeaderSet.FontSize = 28;
            HeaderSet.FontStyle = "Times New Roman";
            HeaderSet.Italic = false;
            HeaderSet.Underline = false;

            WORD.csFontSettings TitleSet = new WORD.csFontSettings();

            TitleSet.Alienment = WORD.enAlienment.enLeft;
            TitleSet.Bold = true;
            TitleSet.FontSize = 18;
            TitleSet.FontStyle = "Times New Roman";
            TitleSet.Italic = false;
            TitleSet.Underline = true;

            WORD.csFontSettings NormalUnderlinedTitleSet = new WORD.csFontSettings();

            NormalUnderlinedTitleSet.Alienment = WORD.enAlienment.enLeft;
            NormalUnderlinedTitleSet.Bold = false;
            NormalUnderlinedTitleSet.FontSize = 16;
            NormalUnderlinedTitleSet.FontStyle = "Times New Roman";
            NormalUnderlinedTitleSet.Italic = false;
            NormalUnderlinedTitleSet.Underline = true;

            WORD.csFontSettings NormalBoldTitleSet = new WORD.csFontSettings();

            NormalBoldTitleSet.Alienment = WORD.enAlienment.enLeft;
            NormalBoldTitleSet.Bold = true;
            NormalBoldTitleSet.FontSize = 16;
            NormalBoldTitleSet.FontStyle = "Times New Roman";
            NormalBoldTitleSet.Italic = false;
            NormalBoldTitleSet.Underline = false;

            WORD.csFontSettings NormalSet = new WORD.csFontSettings();

            NormalSet.Alienment = WORD.enAlienment.enLeft;
            NormalSet.Bold = false;
            NormalSet.FontSize = 16;
            NormalSet.FontStyle = "Times New Roman";
            NormalSet.Italic = false;
            NormalSet.Underline = false;

            if (Person.PersonalInfo.IsPersonalPhoto)
            {
                MainForm.IncreaseProgress("Adding the personl photo!", 10);

                MyWordFile.AddPicture(Person.PersonalInfo.PersonalPhoto, 4, 5);
                MyWordFile.AddTextBox(Person.PersonalInfo.FullName(), HeaderSet, 14.5, 5);
            }
            else
            {
                MainForm.IncreaseProgress("writing the header name!", 10);

                MyWordFile.AddTextLine(Person.PersonalInfo.FullName(), HeaderSet);

            }

            MainForm.IncreaseProgress("writing the Personal Info", 10);

            MyWordFile.AddTextLine("Personal Info", TitleSet);

            MyWordFile.AddTextLine("Name		: " + Person.PersonalInfo.FullName(), NormalSet);
            MyWordFile.AddTextLine("Date Of Birth	: " + Person.PersonalInfo.DateOfBirth, NormalSet);
            MyWordFile.AddTextLine("Age			: " + Person.PersonalInfo.Age, NormalSet);
            MyWordFile.AddTextLine("Gender		: " + Person.PersonalInfo.Gender, NormalSet);
            MyWordFile.AddTextLine("Marital Statues	: " + Person.PersonalInfo.MaritalState, NormalSet);
            MyWordFile.AddTextLine("Military Statues	: " + Person.PersonalInfo.MilitartState, NormalSet);

            MainForm.IncreaseProgress("writing the Contact Info", 10);

            MyWordFile.AddTextLine("Contact Info", TitleSet);

            MyWordFile.AddTextLine("Phone No.1	: " + Person.ContactInfo.FirstPhoneNumber, NormalSet);
            MyWordFile.AddTextLine("Phone No.2	:" + Person.ContactInfo.SecondPhoneNumber, NormalSet);
            MyWordFile.AddTextLine("Address		: " + Person.ContactInfo.City + " ," + Person.ContactInfo.Country, NormalSet);
            MyWordFile.AddTextLine("Email		: " + Person.ContactInfo.Email, NormalSet);

            MainForm.IncreaseProgress("writing the Eduction Info", 10);

            MyWordFile.AddTextLine("Education", TitleSet);

            foreach (csEducationInfo Education in Person.EducationsInfo)
            {

                MyWordFile.AddTextLine(Education.DegreeName + " - " + Education.University, NormalBoldTitleSet);
                MyWordFile.AddTextLine("Graduation Grade : " + Education.Grade + " - " + Education.Year, NormalSet);

            }

            MainForm.IncreaseProgress("writing the Experiences", 10);


            MyWordFile.AddTextLine("Experiences", TitleSet);

            foreach (csExperienceInfo Experience in Person.Experiences)
            {
                MyWordFile.AddTextLine(Experience.Title + " in " + Experience.Company, NormalBoldTitleSet);
                MyWordFile.AddTextLine("From (" + Experience.FromDate + ") To (" + Experience.ToDate + ")", NormalSet);

                MyWordFile.AddTextLine("Responsiblities :", NormalUnderlinedTitleSet);

                foreach (string OneLine in Experience.Responses)
                {
                    MyWordFile.AddTextLine(OneLine, NormalSet);
                }


            }

            MainForm.IncreaseProgress("Courses & Certificates !", 10);


            MyWordFile.AddTextLine("Courses & Certificates", TitleSet);

            foreach (csCertificatInfo OneCertificate in Person.CertificatesAndCoursesInfo)
            {
                MyWordFile.AddTextLine(OneCertificate.Name, NormalBoldTitleSet);
                MyWordFile.AddTextLine(OneCertificate.Institute + " - " + OneCertificate.DateObtained, NormalSet);
            }

            MainForm.IncreaseProgress("Languages!", 5);


            MyWordFile.AddTextLine("Languages", TitleSet);

            foreach (csLanguageInfo OneLanguage in Person.LanguagesInfo)
            {
                MyWordFile.AddTextLine(OneLanguage.Name + "  [ " + OneLanguage.Level + " ]", NormalSet);
            }

            MainForm.IncreaseProgress("Personal Skills!", 5);

            MyWordFile.AddTextLine("Personal Skills", TitleSet);


            foreach (csPersonalSkillInfo OneSkill in Person.PersonalSkillsInfo)
            {
                MyWordFile.AddTextLine(OneSkill.Title, NormalSet);
            }
        }

        void BuildClean(csPerson Person , string FileName)
        {
            MainForm.IncreaseProgress("Preparing Fonts and Margins!", 10);

            WORD MyWordFile = new WORD(FileName);

            MyWordFile.ChangeMargin(WORD.enMargin.enNarrow);
            MyWordFile.RemoveProofing();

            WORD.csFontSettings HeaderSet = new WORD.csFontSettings();

            HeaderSet.Alienment = WORD.enAlienment.enCenter;
            HeaderSet.Bold = true;
            HeaderSet.FontSize = 22;
            HeaderSet.FontStyle = "Calibri";
            HeaderSet.Italic = false;
            HeaderSet.Underline = false;

            WORD.csFontSettings SubHeaderSet = new WORD.csFontSettings();

            SubHeaderSet.Alienment = WORD.enAlienment.enCenter;
            SubHeaderSet.Bold = true;
            SubHeaderSet.FontSize = 11;
            SubHeaderSet.FontStyle = "Calibri";
            SubHeaderSet.Italic = false;
            SubHeaderSet.Underline = false;

            WORD.csFontSettings TitleSet = new WORD.csFontSettings();

            TitleSet.Alienment = WORD.enAlienment.enLeft;
            TitleSet.Bold = true;
            TitleSet.FontSize = 11;
            TitleSet.FontStyle = "Calibri";
            TitleSet.Italic = false;
            TitleSet.Underline = true;

            WORD.csFontSettings SubTitleDefinitionSet = new WORD.csFontSettings();

            SubTitleDefinitionSet.Alienment = WORD.enAlienment.enLeft;
            SubTitleDefinitionSet.Bold = true;
            SubTitleDefinitionSet.FontSize = 11;
            SubTitleDefinitionSet.FontStyle = "Calibri";
            SubTitleDefinitionSet.Italic = false;
            SubTitleDefinitionSet.Underline = false;

            WORD.csFontSettings SubTitleUnderlineSet = new WORD.csFontSettings();

            SubTitleUnderlineSet.Alienment = WORD.enAlienment.enLeft;
            SubTitleUnderlineSet.Bold = true;
            SubTitleUnderlineSet.FontSize = 10;
            SubTitleUnderlineSet.FontStyle = "Calibri";
            SubTitleUnderlineSet.Italic = false;
            SubTitleUnderlineSet.Underline = true;

            WORD.csFontSettings NormalSet = new WORD.csFontSettings();

            NormalSet.Alienment = WORD.enAlienment.enLeft;
            NormalSet.Bold = false;
            NormalSet.FontSize = 11;
            NormalSet.FontStyle = "Calibri";
            NormalSet.Italic = false;
            NormalSet.Underline = false;

            MainForm.IncreaseProgress("writing the header name!", 10);

            MyWordFile.AddText(Person.PersonalInfo.FullName(), HeaderSet);
            MyWordFile.ShiftEnter();
            MyWordFile.AddText(Person.ContactInfo.FirstPhoneNumber + " - " + Person.ContactInfo.SecondPhoneNumber , SubHeaderSet);
            MyWordFile.ShiftEnter();
            MyWordFile.AddText(Person.ContactInfo.Email + " | " + Person.ContactInfo.City + " ," + Person.ContactInfo.Country, SubHeaderSet);
            MyWordFile.ShiftEnter();

            MainForm.IncreaseProgress("Adding Education", 10);

            MyWordFile.AddTextLine("EDUCTION", TitleSet);

            foreach(csEducationInfo OneEducation in Person.EducationsInfo)
            {
                MyWordFile.AddTextLine(OneEducation.DegreeName, SubTitleDefinitionSet);
                MyWordFile.ShiftEnter();
                MyWordFile.AddText(OneEducation.University, NormalSet);
                MyWordFile.AddText(" | " + OneEducation.Grade + " | " + OneEducation.Year, SubTitleDefinitionSet);
            }

            MainForm.IncreaseProgress("Adding Courses", 10);

            MyWordFile.AddTextLine("Courses & Certificates", TitleSet);

            foreach(csCertificatInfo OneCourse in Person.CertificatesAndCoursesInfo)
            {
                MyWordFile.AddTextLine(OneCourse.Name, SubTitleDefinitionSet);
                MyWordFile.ShiftEnter();
                MyWordFile.AddText(OneCourse.Institute, NormalSet);
                MyWordFile.AddText(" | " + OneCourse.DateObtained, SubTitleDefinitionSet);
            }

            MainForm.IncreaseProgress("Adding Experiences", 10);

            MyWordFile.AddTextLine("Experiences", TitleSet);
            MyWordFile.ShiftEnter();

            foreach (csExperienceInfo OneExp in Person.Experiences)
            {
                MyWordFile.AddText(OneExp.Title ,SubTitleDefinitionSet);
                MyWordFile.AddText( " | " + OneExp.Company, NormalSet);
                MyWordFile.AddText(" | " + OneExp.FromDate + " - " + OneExp.ToDate, SubTitleDefinitionSet);
                MyWordFile.ShiftEnter();
                MyWordFile.AddText("Responsiblities :", SubTitleUnderlineSet);
                MyWordFile.ShiftEnter();

                foreach(string OneRespon in OneExp.Responses)
                {
                    MyWordFile.AddText(OneRespon, NormalSet);
                    MyWordFile.ShiftEnter();
                }

                MyWordFile.ShiftEnter();

                
            }


            MainForm.IncreaseProgress("Adding Languages", 10);

            MyWordFile.AddText("Languages", TitleSet);
            MyWordFile.ShiftEnter();
            foreach(csLanguageInfo OneLanguage in Person.LanguagesInfo)
            {
                MyWordFile.AddText(OneLanguage.Name, SubTitleDefinitionSet);
                MyWordFile.AddText(" | " + OneLanguage.Level, NormalSet);
                MyWordFile.ShiftEnter();
            }

            MainForm.IncreaseProgress("Adding Personal Skills", 10);

            MyWordFile.ShiftEnter();
            MyWordFile.AddText("Personal Skills", TitleSet);
            MyWordFile.ShiftEnter();

            foreach (csPersonalSkillInfo OneSkill in Person.PersonalSkillsInfo)
            {
                MyWordFile.AddText(OneSkill.Title, NormalSet);
                MyWordFile.ShiftEnter();


            }




        }

        public void LunchCV(csPerson Person , string FileName , enDesigns Design)
        {
            switch (Design)
            {
                case enDesigns.enDefault:
                    BuildDefault(Person, FileName);
                    break;
                case enDesigns.enClean:
                    BuildClean(Person, FileName);
                    break;

            }


        }



    }
}

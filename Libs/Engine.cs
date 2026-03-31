using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBuilder
{
    public class Engine
    {

        public void LunchCV(csPerson Person , string FileName)
        {
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
                MyWordFile.AddPicture(Person.PersonalInfo.PersonalPhoto , 4 , 5);
                MyWordFile.AddTextBox(Person.PersonalInfo.FullName(), HeaderSet ,14.5,5);
            }
            else
            {
                MyWordFile.AddTextLine(Person.PersonalInfo.FullName(), HeaderSet);

            }

            MyWordFile.AddTextLine("Personal Info", TitleSet);

            MyWordFile.AddTextLine("Name		: " + Person.PersonalInfo.FullName(), NormalSet);
            MyWordFile.AddTextLine("Date Of Birth	: " + Person.PersonalInfo.DateOfBirth, NormalSet);
            MyWordFile.AddTextLine("Age			: " + Person.PersonalInfo.Age, NormalSet);
            MyWordFile.AddTextLine("Gender		: " + Person.PersonalInfo.Gender, NormalSet);
            MyWordFile.AddTextLine("Marital Statues	: " + Person.PersonalInfo.MaritalState, NormalSet);
            MyWordFile.AddTextLine("Military Statues	: " + Person.PersonalInfo.MilitartState, NormalSet);

            MyWordFile.AddTextLine("Contact Info", TitleSet);

            MyWordFile.AddTextLine("Phone No.1	: " + Person.ContactInfo.FirstPhoneNumber, NormalSet);
            MyWordFile.AddTextLine("Phone No.2	:" + Person.ContactInfo.SecondPhoneNumber, NormalSet);
            MyWordFile.AddTextLine("Address		: " + Person.ContactInfo.City + " ," + Person.ContactInfo.Country, NormalSet);
            MyWordFile.AddTextLine("Email		: " + Person.ContactInfo.Email, NormalSet);

            MyWordFile.AddTextLine("Education", TitleSet);

            foreach(csEducationInfo Education in Person.EducationsInfo)
            {

                MyWordFile.AddTextLine(Education.DegreeName + " - " + Education.University, NormalBoldTitleSet);
                MyWordFile.AddTextLine("Graduation Grade : " + Education.Grade + " - " + Education.Year, NormalSet);

            }


            MyWordFile.AddTextLine("Experiences", TitleSet);

            foreach (csExperienceInfo Experience in Person.Experiences)
            {
                MyWordFile.AddTextLine(Experience.Title + " in " + Experience.Company , NormalBoldTitleSet);
                MyWordFile.AddTextLine("From (" + Experience.FromDate + ") To (" + Experience.ToDate + ")", NormalSet);

                MyWordFile.AddTextLine("Responsiblities :", NormalUnderlinedTitleSet);

                foreach(string OneLine in Experience.Responses)
                {
                    MyWordFile.AddTextLine(OneLine, NormalSet);
                }


            }


            MyWordFile.AddTextLine("Courses & Certificates", TitleSet);

            foreach(csCertificatInfo OneCertificate in Person.CertificatesAndCoursesInfo)
            {
                MyWordFile.AddTextLine(OneCertificate.Name, NormalBoldTitleSet);
                MyWordFile.AddTextLine(OneCertificate.Institute + " - " + OneCertificate.DateObtained, NormalSet);
            }



            MyWordFile.AddTextLine("Languages", TitleSet);

            foreach(csLanguageInfo OneLanguage in Person.LanguagesInfo)
            {
                MyWordFile.AddTextLine(OneLanguage.Name + "  [ " + OneLanguage.Level + " ]", NormalSet);
            }

            MyWordFile.AddTextLine("Personal Skills", TitleSet);


            foreach(csPersonalSkillInfo OneSkill in Person.PersonalSkillsInfo)
            {
                MyWordFile.AddTextLine(OneSkill.Title, NormalSet);
            }


        }



    }
}

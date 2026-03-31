using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CvBuilder
{
    public class csPersonalInfo
    {
        public string FirstName;
        public string LastName;
        public string MaritalState;
        public string MilitartState;
        public string DateOfBirth;
        public string Age;
        public string Gender;
        public bool IsPersonalPhoto = false;
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public Image PersonalPhoto;


    }

    public class csContactInfo
    {
        public string FirstPhoneNumber;
        public string SecondPhoneNumber;
        public string City;
        public string Country;
        public string Email;
    }

    public class csEducationInfo
    {
        public string DegreeName;
        public string Year;
        public string University;
        public string Grade;
    }

    public class csExperienceInfo
    {
        public string Title;
        public string Company;
        public string FromDate;
        public string ToDate;
        public List<string> Responses;
    }

    public class csCertificatInfo
    {
        public string Name;
        public string Institute;
        public string DateObtained;
    }

    public class csLanguageInfo
    {
        public string Name;
        public string Level;
    }

    public class csPersonalSkillInfo
    {
        public string Title;
    }

    public class csPerson
    {
        public csPersonalInfo PersonalInfo = new csPersonalInfo();
        public csContactInfo ContactInfo = new csContactInfo();
        public List<csEducationInfo> EducationsInfo = new List<csEducationInfo>();
        public List<csCertificatInfo> CertificatesAndCoursesInfo = new List<csCertificatInfo>();
        public List<csLanguageInfo> LanguagesInfo = new List<csLanguageInfo>();
        public List<csPersonalSkillInfo> PersonalSkillsInfo = new List<csPersonalSkillInfo>();
        public List<csExperienceInfo> Experiences = new List<csExperienceInfo>();


    }
}

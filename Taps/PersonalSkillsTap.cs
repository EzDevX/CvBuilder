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
    public partial class PersonalSkillsTap : UserControl
    {
        public PersonalSkillsTap()
        {
            InitializeComponent();
        }
        public Form1 MainForm;

        public bool IsEmpty()
        {
            if(ListBoxSkills.Items.Count == 0)
            {
                return true;
            }
            return false;
        }

        private int Counter = 1;

        public List<csPersonalSkillInfo> Skills()
        {
            List<csPersonalSkillInfo> AllSkills = new List<csPersonalSkillInfo>();

            foreach(var OneSkill in ListBoxSkills.Items)
            {

                csPersonalSkillInfo Skill = new csPersonalSkillInfo();

                Skill.Title = OneSkill.ToString();

                AllSkills.Add(Skill);


            }

            return AllSkills;


        }

        public void DarkMode()
        {

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            ListBoxSkills.BackColor = Color.FromArgb(55, 55, 55);
            ListBoxSkills.ForeColor = Color.White;

            ButtonAddSkill.BackColor = Color.FromArgb(55, 55, 55);
            ButtonAddSkill.ForeColor = Color.White;

            TextBoxSkillTitle.BackColor = Color.FromArgb(55, 55, 55);
            TextBoxSkillTitle.ForeColor = Color.White;



        }
        public void LightMode()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;

            ListBoxSkills.BackColor = Color.Silver;
            ListBoxSkills.ForeColor = Color.Black;

            ButtonAddSkill.BackColor = Color.Silver;
            ButtonAddSkill.ForeColor = Color.Black;

            TextBoxSkillTitle.BackColor = Color.White;
            TextBoxSkillTitle.ForeColor = Color.Black;

        }

        public void AddToList(string TextLine)
        {
            ListBoxSkills.Items.Add(Counter.ToString() + " - " + TextLine);
            Counter++;
        }

        private void PersonalSkillsTap_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddSkill_Click(object sender, EventArgs e)
        {
            ListBoxSkills.Items.Add(Counter.ToString() + " - " + TextBoxSkillTitle.Text);
            Counter++;
        }
    }
}

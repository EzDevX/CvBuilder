using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvBuilder
{
    public partial class ResponsesForm : Form
    {
        public ResponsesForm()
        {
            InitializeComponent();
        }

        public void AddToList(string Line)
        {
            ListBoxResponses.Items.Add(Line);
        }

        public void ClearList()
        {
            ListBoxResponses.Items.Clear();
        }

        private void ResponsesForm_Load(object sender, EventArgs e)
        {

        }
    }
}

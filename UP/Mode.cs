using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP
{
    public partial class Mode : Form
    {
        public MainForm mainForm;
        public Mode(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pass_TextChanged_1(object sender, EventArgs e)
        {
            string s = "0000";
            if (Pass.Text == s)
            {
                mainForm.Show();
                mainForm.Add.Visible = true;
                mainForm.Edit.Visible = true;
                mainForm.Del.Visible = true;
                Close();
            }
            
        }
    }
}

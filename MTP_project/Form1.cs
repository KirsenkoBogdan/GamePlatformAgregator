using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MTP_project
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = (sender as CheckBox).Checked;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm s = new RegistrationForm();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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


        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (ShowPassword_checkBox.Checked)
                {
                    Password_textBox.UseSystemPasswordChar = false;
                }
                else
                {
                    Password_textBox.UseSystemPasswordChar = true;
                }
            };
        }
        

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Enter_button_Click(object sender, EventArgs e)
        {

        }

        private void ToRegister_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm s = new RegistrationForm();
            s.ShowDialog();
            this.Close();
        }
    }
}

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
using ServerLibrary;
using Newtonsoft.Json.Linq;
using System.Threading;

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

        private async void button1_Click(object sender, EventArgs e) {
            button1.Enabled = false;
            button2.Enabled = false;
            var user = new User(textBox1.Text, textBox2.Text);
            var answer = await user.Enter();
            MessageBox.Show(answer.ToString());
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}

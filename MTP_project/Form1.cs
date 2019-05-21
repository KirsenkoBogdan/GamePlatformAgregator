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
            Connection.Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection.NEVER_EAT_POISON_Disable_CertificateValidation();
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

        private void ToRegister_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm s = new RegistrationForm();
            s.ShowDialog();
            this.Close();
        }

        private async void Enter_button_Click(object sender, EventArgs e) {
            Enter_button.Enabled = false;
            Exit_button.Enabled = false;
            var user = new User(Login_textBox.Text, Password_textBox.Text);
            var answer = await user.Enter();
            MessageBox.Show(answer.ToString());
            ResponseLabel.Text = (string)answer["Message"];
            Enter_button.Enabled = true;
            Exit_button.Enabled = true;
        }
    }
}

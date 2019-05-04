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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than or greater than 12 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm af1 = new AuthorizationForm();
            af1.ShowDialog();
            this.Close();
        }
      
        

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

            Password_textBox.ForeColor = Color.Gray;
            Password_textBox.Text = "Must contain 1 capital letter, number and special character";
        }

        private void Password_textBox_Enter(object sender, EventArgs e)
        {
            if (Password_textBox.Text == "Must contain 1 capital letter, number and special character")
            {
                Password_textBox.Text = String.Empty;
                Password_textBox.ForeColor = Color.Black;
                Password_textBox.UseSystemPasswordChar = true;
            }
        }
    }
}

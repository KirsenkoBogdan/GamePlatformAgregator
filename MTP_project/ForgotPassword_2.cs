using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerLibrary;

namespace MTP_project
{
    public partial class ForgotPassword_2 : Form
    {
        public ForgotPassword_2()
        {
            InitializeComponent();
        }

        private async void ConfirmTempPassword_button_Click(object sender, EventArgs e) {
            ConfirmTempPassword_button.Enabled = false;
            var answer = await User.SetEmailVerif(TempPassword_textBox.Text);
            ResponseLabel.Text = (string)answer["message"]["Message"];
            ConfirmTempPassword_button.Enabled = true;
            if ((bool)answer["answer"]) {
                this.Hide();
                AuthorizationForm s = new AuthorizationForm();
                s.ShowDialog();
                this.Close();
            }
        }
    }
}

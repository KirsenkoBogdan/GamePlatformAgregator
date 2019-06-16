using CefSharp;
using ServerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTP_project
{
    public partial class MainForm : Form
    {
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void RegisterGogButton_Click(object sender, EventArgs e) {
            ChromiumWebBrowser.Load(EnterPlatform.OAuthString());
        }

        private void ChromiumWebBrowser_AddressChanged(object sender, AddressChangedEventArgs e) {
            MessageBox.Show(e.Address);
            if (e.Address.IndexOf("https://embed.gog.com/on_login_success") == 0) {
                var usercode = LoginSuccessParse(e.Address);
            }
        }

        private string LoginSuccessParse(string address) {
            var start = address.IndexOf("code=");
            return address.Substring(start + "code=".Length);
        }
    }
}

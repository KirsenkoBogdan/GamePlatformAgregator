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
            browser = new CefSharp.WinForms.ChromiumWebBrowser("https://login.gog.com/login") {
                Size = new Size(600, 400),
                Location = new Point(500, 100)
            };
            WebPanel.Controls.Add(browser);
        }
    }
}

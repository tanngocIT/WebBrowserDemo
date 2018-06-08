using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace WebBrowserDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.google.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
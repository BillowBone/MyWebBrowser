using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MyWebBrowser
{
    //This form allows the user to modify the settings
    //Settings are composed of the name of the web browser, the home page's URL and the with ot without history option
    public partial class Settings : XtraForm
    {
        public Settings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textEdit1.Text = Browser.browserName;
            textEdit2.Text = Browser.homeUrl;
            if (Browser.withHistory)
                checkEdit1.Checked = true;
            else
                checkEdit1.Checked = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                ManageSettings.SetBrowserName(textEdit1.Text);
                ManageSettings.SetHomeURL(textEdit2.Text);
                if (checkEdit1.Checked)
                    ManageSettings.SetHistoryBoolean("True");
                else
                    ManageSettings.SetHistoryBoolean("False");
                this.Dispose();
            }
        }
    }
}
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MyWebBrowser
{
    //This class is an interface to the Favorites, History and Settings form
    //This class is called when the user clicks on the top-right corner's button from the Browser form
    public partial class Options : XtraForm
    {
        public Options()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            Favorites fav = new Favorites();
            if (fav.ShowDialog() == DialogResult.OK)
                this.Dispose();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History h = new History();
            if (h.ShowDialog() == DialogResult.OK)
                this.Dispose();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
        }
    }
}
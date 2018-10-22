using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MyWebBrowser
{
    //Main window, manages the web browser itself, tabs, navigation buttons, search bar and options/settings calls
    public partial class Browser : XtraForm
    {
        public static string actualUrl = null;
        public static string previousUrl = null;
        public static string homeUrl = null;
        public static string browserName = null;
        public static bool withHistory = true;
        public static bool actualizeSettings = false;
        public static bool actualizeFavsBar = false;
        private WebBrowser newWebTab = null;
        private int nbTabsMax = 10;

        public Browser()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private void InitializeBrowser()
        {
            ManageFavorites.Initialize();
            ManageHistory.Initialize();
            ManageSettings.Initialize();
            SetFavoritesBar();
            browserName = ManageSettings.GetBrowserName();
            this.Text = browserName;
            homeUrl = ManageSettings.GetHomeURL();
            withHistory = ManageSettings.GetHistoryBoolean();
            webBrowser.Navigate(homeUrl);
            actualUrl = homeUrl;
            urlTextEdit.Text = homeUrl;
            tabControl.TabPages[0].Text = webBrowser.DocumentTitle;
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.IsWebBrowserContextMenuEnabled = false;
        }

        //Limits the the name of a favorites in the favorites bar to a length of 29 characters
        private string MakeFavoriteNameFit(string nameFavorite)
        {
            if (nameFavorite.Length < 28) {
                return (nameFavorite);
            } else {
                string shortName = nameFavorite.Substring(0, 25) + "...";
                return (shortName);
            }
        }

        //Gets the name of each favorite in the favorites bar and fill the LabelControl tab with it
        //Non used favorites in the tab are set to invisible
        private void SetFavoritesBar()
        {
            string[] parsedFavsBar = ManageFavorites.GetFavoritesBar();
            LabelControl[] tabFavsBar = new LabelControl[] { fav1, fav2, fav3, fav4, fav5, fav6, fav7, fav8, fav9, fav10 };
            int i = 0;

            while (i < parsedFavsBar.Length / 2)
            {
                if (i != parsedFavsBar.Length / 2 - 1)
                    tabFavsBar[i].Text = MakeFavoriteNameFit(parsedFavsBar[2 * i]) + "  |  ";
                else
                    tabFavsBar[i].Text = MakeFavoriteNameFit(parsedFavsBar[2 * i]);
                tabFavsBar[i].Visible = true;
                i++;
            }
            while (i < tabFavsBar.Length)
            {
                tabFavsBar[i].Visible = false;
                i++;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null && web.CanGoBack)
                web.GoBack();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null && web.CanGoForward)
                web.GoForward();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Refresh();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate(homeUrl);
                previousUrl = actualUrl;
                actualUrl = homeUrl;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate(urlTextEdit.Text);
                previousUrl = actualUrl;
                actualUrl = web.Url.ToString();
            }
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                ManageFavorites.AddFavorite(web.DocumentTitle + Environment.NewLine);
                ManageFavorites.AddFavorite(web.Url.ToString() + Environment.NewLine);
            }
        }

        //Calls the options form and checks if favorites or settings have changed
        //Visits a new URL if the user asked to visit a favorite / history website
        private void optionsButton_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            previousUrl = actualUrl;
            opt.ShowDialog();
            if (actualizeSettings)
            {
                browserName = ManageSettings.GetBrowserName();
                this.Text = browserName;
                homeUrl = ManageSettings.GetHomeURL();
                withHistory = ManageSettings.GetHistoryBoolean();
                actualizeSettings = false;
            }
            if (actualizeFavsBar)
            {
                SetFavoritesBar();
                actualizeFavsBar = false;
            }
            if (actualUrl != previousUrl)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                    web.Navigate(actualUrl);
            }
        }

        //Add a new tab control to tabControl, verifies that there is 10 tabs max
        private void newTabButton_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount < nbTabsMax) {
                TabPage newTab = new TabPage();
                newTab.Text = "New tab";
                tabControl.Controls.Add(newTab);
                tabControl.SelectTab(tabControl.TabCount - 1);
                newWebTab = new WebBrowser() { ScriptErrorsSuppressed = true };
                newWebTab.Parent = newTab;
                newWebTab.Dock = DockStyle.Fill;
                newWebTab.Navigate(homeUrl);
                urlTextEdit.Text = homeUrl;
                newWebTab.DocumentCompleted += DocumentCompleted;
            } else {
                XtraMessageBox.Show("You can't have more than " + tabControl.TabCount.ToString() + " tabs open at the same time !");
            }
        }

        //Actualize the URL at the top of the web browser when a new page is visited
        //If the history option has been checked, it adds a new element to the history
        //Actualize the name of the actual tab with the current document title
        private void DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                urlTextEdit.Text = web.Url.ToString();
                if (withHistory)
                {
                    ManageHistory.InsertNewUrl(web.DocumentTitle + Environment.NewLine, true);
                    ManageHistory.InsertNewUrl(web.Url.ToString() + Environment.NewLine, true);
                }
                previousUrl = actualUrl;
                actualUrl = web.Url.ToString();
                tabControl.SelectedTab.Text = web.DocumentTitle;
            }
        }

        //Happens when the user deletes a tab, checks if it's the only one and if so it close the program
        private void deleteTabButton_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount == 1) {
                DialogResult res = XtraMessageBox.Show("Do you really wants to close the only tab ?"
                    + " This action will close the program", "Tab closing", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                    this.Dispose();
            } else {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                web.Dispose();
                TabPage actualTab = tabControl.SelectedTab;
                tabControl.Controls.Remove(actualTab);
            }
        }

        private void urlTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(urlTextEdit.Text);
                    previousUrl = actualUrl;
                    actualUrl = web.Url.ToString();
                }
            }
        }

        private bool IsIdentical(string fav, LabelControl lab)
        {
            if (fav == lab.Text || (fav == lab.Text.Substring(0, lab.Text.Length - 5)))
                return (true);
            else if (lab.Text.Length > 25 && fav.Length > 25 && fav.Substring(0, 25) == lab.Text.Substring(0, 25))
                return (true);
            else
                return (false);
        }

        //Happens when the user clicks on the favorites bar
        private void fav_Click(object sender, EventArgs e)
        {
            string[] parsedFavsBar = ManageFavorites.GetFavoritesBar();

            for (int i = 0; i < parsedFavsBar.Length; i = i + 2)
            {
                if (IsIdentical(parsedFavsBar[i], (LabelControl)sender))
                {
                    WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                    web.Navigate(parsedFavsBar[i + 1]);
                    break;
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MyWebBrowser
{
    public partial class Favorites : XtraForm
    {
        private ListBox listBoxUrl = new ListBox();
        private ListBox listBoxFinal = new ListBox();
        private ListBox listBoxBarUrl = new ListBox();
        private ListBox listBoxBarTitle = new ListBox();
        private ListBox listBoxBarFinal = new ListBox();
        private bool favListModified = false;

        public Favorites()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            FillListBoxes();
            visitButton.Enabled = false;
            deleteButton.Enabled = false;
            addBarbutton.Enabled = false;
            deleteBarButton.Enabled = false;
        }

        //Fills the list boxes with document title and URL of each favorites
        //Does the same for the favorites bar
        private void FillListBoxes()
        {
            string[] favorites = ManageFavorites.GetFavorites();
            string[] favoritesBar = ManageFavorites.GetFavoritesBar();
            int i = 0;

            foreach (string str in favorites)
            {
                if (i % 2 == 0)
                    listBoxTitle.Items.Add(str);
                else
                    listBoxUrl.Items.Add(str);
                i++;
            }
            i = 0;
            foreach (string str in favoritesBar)
            {
                if (i % 2 == 0)
                    listBoxBarTitle.Items.Add(str);
                else
                    listBoxBarUrl.Items.Add(str);
                i++;
            }
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            int selected = listBoxTitle.SelectedIndex;

            if (selected != -1)
            {
                Browser.actualUrl = listBoxUrl.Items[selected].ToString();
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        //Deletes a favorite from the list and also from the favorites bar
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selected = listBoxTitle.SelectedIndex;

            if (selected != -1)
            {
                favListModified = true;
                listBoxBarTitle.Items.Remove(listBoxTitle.Items[selected]);
                listBoxBarUrl.Items.Remove(listBoxTitle.Items[selected]);
                listBoxTitle.Items.RemoveAt(selected);
                listBoxUrl.Items.RemoveAt(selected);
            }
        }

        //Checks if modifications have been made and if so, send modified lists to the ManageFavorites class
        private void Favorites_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (favListModified)
            {
                int i = 0;

                while (i < listBoxTitle.Items.Count)
                {
                    listBoxFinal.Items.Add(listBoxTitle.Items[i]);
                    listBoxFinal.Items.Add(listBoxUrl.Items[i]);
                    i++;
                }
                i = 0;
                while (i < listBoxBarTitle.Items.Count)
                {
                    listBoxBarFinal.Items.Add(listBoxBarTitle.Items[i]);
                    listBoxBarFinal.Items.Add(listBoxBarUrl.Items[i]);
                    i++;
                }
                ManageFavorites.ActualizeFavoritesList(listBoxFinal.Items);
                ManageFavorites.ActualizeFavoritesBarList(listBoxBarFinal.Items);
            }
        }

        //Manages which buttons are enabled or not depending on the actual element selected
        private void listBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = listBoxTitle.SelectedIndex;

            if (selected != -1)
            {
                visitButton.Enabled = true;
                deleteButton.Enabled = true;
                if (ManageFavorites.FavoriteIsInListBoxBar(listBoxTitle.Items[selected].ToString(), listBoxBarTitle.Items)) {
                    deleteBarButton.Enabled = true;
                    addBarbutton.Enabled = false;
                } else {
                    addBarbutton.Enabled = true;
                    deleteBarButton.Enabled = false;
                }
            } else {
                visitButton.Enabled = false;
                deleteButton.Enabled = false;
                addBarbutton.Enabled = false;
                deleteBarButton.Enabled = false;
            }
        }

        //Checks if the user can add a new favorite to the favorites bar
        private void addBarbutton_Click(object sender, EventArgs e)
        {
            int selected = listBoxTitle.SelectedIndex;

            if (selected != -1)
            {
                if (listBoxBarTitle.Items.Count < 10) {
                    favListModified = true;
                    listBoxBarTitle.Items.Add(listBoxTitle.Items[selected]);
                    listBoxBarUrl.Items.Add(listBoxUrl.Items[selected]);
                    addBarbutton.Enabled = false;
                    deleteBarButton.Enabled = true;
                } else {
                    XtraMessageBox.Show("You can't put more than 10 favorites in the favorites bar !");
                }
            }
        }

        private void deleteBarButton_Click(object sender, EventArgs e)
        {
            int selected = listBoxTitle.SelectedIndex;

            if (selected != -1)
            {
                favListModified = true;
                listBoxBarTitle.Items.Remove(listBoxTitle.Items[selected]);
                listBoxBarUrl.Items.Remove(listBoxUrl.Items[selected]);
                addBarbutton.Enabled = true;
                deleteBarButton.Enabled = false;
            }
        }
    }
}
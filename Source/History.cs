using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MyWebBrowser
{
    public partial class History : XtraForm
    {
        private ListBox listBoxUrl = new ListBox();
        private ListBox listBoxFinal = new ListBox();
        private bool historyModified = false;

        public History()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            visitButton.Enabled = false;
            deleteButton.Enabled = false;
            FillListBoxes();
        }

        //Fill history in two lists so the user only sees the document title of each website he visited
        private void FillListBoxes()
        {
            string[] fullHistory = ManageHistory.GetFullHistory();
            int i = 0;

            foreach (string str in fullHistory)
            {
                if (i % 2 == 0)
                    listBoxUrl.Items.Add(str);
                else
                    listBoxTitle.Items.Add(str);
                i++;
            }
        }

        private string RemoveDateAndTimeFromHistoryLine(string historyLine)
        {
            int i = 0;
            string result = null;

            foreach (char c in historyLine)
            {
                i++;
                if (c == '\t')
                    break;
            }
            result = historyLine.Substring(i, historyLine.Length - i);
            return (result);
        }

        //Checks if there is an element selected and if so, enable the buttons
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = listBoxTitle.SelectedIndex;

            if (selected != -1)
            {
                visitButton.Enabled = true;
                deleteButton.Enabled = true;
            } else {
                visitButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            int selected = listBoxTitle.SelectedIndex;

            if (selected != -1)
            {
                Browser.actualUrl = RemoveDateAndTimeFromHistoryLine(listBoxUrl.Items[selected].ToString());
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selected = listBoxTitle.SelectedIndex;

            if (selected != -1)
            {
                historyModified = true;
                listBoxTitle.Items.RemoveAt(selected);
                listBoxUrl.Items.RemoveAt(selected);
            }
        }

        //Clear the whole history and asks the user if he is certain before
        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            DialogResult res = XtraMessageBox.Show("Are you sure you want to delete all the history ?", "Delete full history", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                historyModified = true;
                listBoxTitle.Items.Clear();
                listBoxUrl.Items.Clear();
            }
        }

        //Checks if the user modified the history and if so send mofidications to the ManageHistory class
        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (historyModified)
            {
                int i = 0;

                while (i < listBoxTitle.Items.Count)
                {
                    listBoxFinal.Items.Add(listBoxUrl.Items[i]);
                    listBoxFinal.Items.Add(listBoxTitle.Items[i]);
                    i++;
                }
                ManageHistory.Actualizehistory(listBoxFinal.Items);
            }
        }
    }
}
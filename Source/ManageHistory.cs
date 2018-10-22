using System;
using System.Windows.Forms;
using System.IO;

namespace MyWebBrowser
{
    class ManageHistory
    {
        private static string appLocation;
        private static string historyLocation;
        private static FileStream fs;

        //Gets the location of the app on the computer hierarchy
        //Checks if the history file exists and if not, creates it
        public static void Initialize()
        {
            appLocation = Application.StartupPath;
            historyLocation = Path.Combine(appLocation, "history");
            if (!File.Exists(historyLocation))
            {
                fs = File.Create(historyLocation);
                fs.Close();
            }
        }

        public static void InsertNewUrl(string url, bool withDate)
        {
            string fullHistory = File.ReadAllText(historyLocation);

            if (withDate) {
                string dateAndTime = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + "\t";
                File.WriteAllText(historyLocation, dateAndTime + url + fullHistory);
            } else {
                File.WriteAllText(historyLocation, url + fullHistory);
            }
        }

        public static string[] GetFullHistory()
        {
            string fullHistory = File.ReadAllText(historyLocation);
            string[] parsedHistory = fullHistory.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return (parsedHistory);
        }

        //Needs to revers the history before actualizing it so the most recent website appears at the top
        public static void Actualizehistory(ListBox.ObjectCollection history)
        {
            string[] reverseHistory = new string[history.Count];
            int i = 1;
            File.Delete(historyLocation);
            fs = File.Create(historyLocation);
            fs.Close();
            foreach (object obj in history)
            {
                reverseHistory[history.Count - i] = obj.ToString();
                i++;
            }
            foreach (string str in reverseHistory)
            {
                InsertNewUrl(str + Environment.NewLine, false);
            }
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace MyWebBrowser
{
    class ManageSettings
    {
        private static string appLocation;
        private static string settingsLocation;
        private static string defaultBrowserName = "My Web Browser";
        private static string defaultHomeURL = "http://www.google.com";
        private static FileStream fs;

        //Gets the location of the app on the computer hierarchy
        //Checks if the settings file exists and if not, creates it
        public static void Initialize()
        {
            appLocation = Application.StartupPath;
            settingsLocation = Path.Combine(appLocation, "settings");
            if (!File.Exists(settingsLocation))
            {
                fs = File.Create(settingsLocation);
                fs.Close();
                File.WriteAllText(settingsLocation, defaultBrowserName + Environment.NewLine
                    + defaultHomeURL + Environment.NewLine + Browser.withHistory.ToString());
            }
        }

        private static string[] parseSettingsFile()
        {
            if (!File.Exists(settingsLocation))
                Initialize();
            string settings = File.ReadAllText(settingsLocation);
            string[] parsedSettings = settings.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return (parsedSettings);
        }

        public static string GetBrowserName()
        {
            string[] parsedSettings = parseSettingsFile();
            if (parsedSettings.Length == 3)
                return (parsedSettings[0]);
            return (null);
        }

        public static string GetHomeURL()
        {
            string[] parsedSettings = parseSettingsFile();
            if (parsedSettings.Length == 3)
                return (parsedSettings[1]);
            return (null);
        }

        public static bool GetHistoryBoolean()
        {
            string[] parsedSettings = parseSettingsFile();
            if (parsedSettings.Length == 3 && parsedSettings[2] == "False")
                return (false);
            else
                return (true);
        }

        public static void SetBrowserName(string newBrowserName)
        {
            string[] parsedSettings = parseSettingsFile();
            ActualizeSettings(newBrowserName, parsedSettings[1], parsedSettings[2]);
        }

        public static void SetHomeURL(string newHomeUrl)
        {
            string[] parsedSettings = parseSettingsFile();
            ActualizeSettings(parsedSettings[0], newHomeUrl, parsedSettings[2]);
        }

        public static void SetHistoryBoolean(string newHistoryBoolean)
        {
            string[] parsedSettings = parseSettingsFile();
            ActualizeSettings(parsedSettings[0], parsedSettings[1], newHistoryBoolean);
        }

        private static void ActualizeSettings(string browserName, string homeUrl, string historyBoolean)
        {
            File.WriteAllText(settingsLocation, browserName + Environment.NewLine + homeUrl
                + Environment.NewLine + historyBoolean);
            Browser.actualizeSettings = true;
        }
    }
}

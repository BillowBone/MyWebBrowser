using System;
using System.Windows.Forms;
using System.IO;

namespace MyWebBrowser
{
    class ManageFavorites
    {
        private static string appLocation;
        private static string favoritesLocation;
        private static string favoritesBarLocation;
        private static FileStream fs;

        //Gets the location of the app on the computer hierarchy
        //Checks if the favorites and favoritesBar files exists and if not, creates it
        public static void Initialize()
        {
            appLocation = Application.StartupPath;
            favoritesLocation = Path.Combine(appLocation, "favorites");
            favoritesBarLocation = Path.Combine(appLocation, "favoritesBar");
            if (!File.Exists(favoritesLocation))
            {
                fs = File.Create(favoritesLocation);
                fs.Close();
            }
            if (!File.Exists(favoritesBarLocation))
            {
                fs = File.Create(favoritesBarLocation);
                fs.Close();
            }
        }

        public static void AddFavorite(string urlFavorite)
        {
            Initialize();
            string allFavs = File.ReadAllText(favoritesLocation);

            File.WriteAllText(favoritesLocation, allFavs + urlFavorite);
        }

        public static string[] GetFavorites()
        {
            Initialize();
            string allFavs = File.ReadAllText(favoritesLocation);
            string[] parsedFavs = allFavs.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return (parsedFavs);
        }

        public static void ActualizeFavoritesList(ListBox.ObjectCollection favorites)
        {
            File.Delete(favoritesLocation);
            foreach (object obj in favorites)
            {
                AddFavorite(obj.ToString() + Environment.NewLine);
            }
        }

        public static void AddFavoriteBar(string urlFavoriteBar)
        {
            Initialize();
            string allFavsBar = File.ReadAllText(favoritesBarLocation);

            File.WriteAllText(favoritesBarLocation, allFavsBar + urlFavoriteBar);
        }

        public static string[] GetFavoritesBar()
        {
            Initialize();
            string allFavsBar = File.ReadAllText(favoritesBarLocation);
            string[] parsedFavsBar = allFavsBar.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return (parsedFavsBar);
        }

        public static void ActualizeFavoritesBarList(ListBox.ObjectCollection favoritesBar)
        {
            File.Delete(favoritesBarLocation);
            foreach (object obj in favoritesBar)
            {
                AddFavoriteBar(obj.ToString() + Environment.NewLine);
            }
            Browser.actualizeFavsBar = true;
        }

        //The favorites class can call the method to know if a given favorite is in the favorites bar
        public static bool FavoriteIsInListBoxBar(string favorite, ListBox.ObjectCollection listBoxBar)
        {
            foreach (object obj in listBoxBar)
            {
                if (obj.ToString() == favorite)
                    return (true);
            }
            return (false);
        }
    }
}

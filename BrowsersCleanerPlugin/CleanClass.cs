/* This file is part of BrowsersCleanerPlugin for Cleaner .NET

    BrowsersCleanerPlugin for Cleaner .NET is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 3 of the License.

    BrowsersCleanerPlugin for Cleaner .NET is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with BrowsersCleanerPlugin for Cleaner .NET; if not, write to the Free Software
    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA */
using System;
using System.IO;

namespace BrowsersCleanerPlugin
{
    public class CleanClass
    {
        public static string CleanFirefoxCache(bool DoClean)
        {
            double Size = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Mozilla\\Firefox\\Profiles\\";
            if (Directory.Exists(path))
            {
                string[] FilesPath = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                Size += DeleteFiles(FilesPath, DoClean);
                if (DoClean)
                {
                    DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Mozilla\\Firefox\\Profiles");
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        try
                        {
                            dir.Delete(true);
                        }
                        catch { }
                    }
                }
            }
            return "Firefox, " + Lang.Cache + ": " + Size + " MB" + "\n\n";
        }

        public static string CleanFirefoxHistory(bool DoClean)
        {
            double Size = 0;
            string[] PathProfile = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles\\");
            foreach (string Path in PathProfile)
            {
                string[] array = { Path + "\\places.sqlite", Path + "\\formhistory.sqlite" };
                Size += DeleteFiles(array, DoClean);
            }
            return "Firefox, " + Lang.History + ": " + Size + " MB" + "\n\n";
        }

        public static string CleanFirefoxDownload(bool DoClean)
        {
            double Size = 0;
            string[] PathProfile = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles\\");
            foreach (string Path in PathProfile)
            {
                string[] array = { Path + "\\mimeTypes.rdf" };
                Size += DeleteFiles(array, DoClean);
            }
            return "Firefox, " + Lang.Download + ": " + Size + " MB" + "\n\n";
        }

        public static string CleanFirefoxCookies(bool DoClean)
        {
            double Size = 0;
            string[] PathProfile = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles\\");
            foreach (string Path in PathProfile)
            {
                string[] array = { Path + "\\cookies.sqlite" };
                Size += DeleteFiles(array, DoClean);
            }
            return "Firefox, " + Lang.Cookies + ": " + Size + " MB" + "\n\n";
        }

        public static string CleanFirefoxPasswords(bool DoClean)
        {
            double Size = 0;
            string[] PathProfile = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles\\");
            foreach (string Path in PathProfile)
            {
                string[] array = { Path + "\\key3.db", Path + "\\signons.sqlite" };
                Size += DeleteFiles(array, DoClean);
            }
            return "Firefox, " + Lang.Passwords + ": " + Size + " MB" + "\n\n";
        }

        public static string CleanFirefoxSitesSettings(bool DoClean)
        {
            double Size = 0;
            string[] PathProfile = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles\\");
            foreach (string Path in PathProfile)
            {
                string[] array = { Path + "\\permissions.sqlite" };
                Size += DeleteFiles(array, DoClean);
            }
            return "Firefox, " + Lang.SitesSettings + ": " + Size + " MB" + "\n\n";
        }

        /* chrome */
        public static string CleanChromeCache(bool DoClean)
        {
            double Size = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Cache\\";
            if (Directory.Exists(path))
            {
                string[] FilesPath = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                Size += DeleteFiles(FilesPath, DoClean);
                if (DoClean)
                {
                    DirectoryInfo di = new DirectoryInfo(path);
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        try
                        {
                            dir.Delete(true);
                        }
                        catch { }
                    }
                }
            }
            return "Chrome, " + Lang.Cache + ": " + Size + " MB" + "\n\n";
        }
        public static string CleanChromeHistory(bool DoClean)
        {
            double Size = 0;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\";

            string[] array = { Path + "Visited Links", Path + "Current Tabs", Path + "Top Sites", Path + "History Provider Cache", Path + "Network Action Predictor", Path + "History" };
            Size += DeleteFiles(array, DoClean);

            return "Chrome, " + Lang.History + ": " + Size + " MB" + "\n\n";
        }
        public static string CleanChromeCookies(bool DoClean)
        {
            double Size = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Local Storage\\";
            if (Directory.Exists(path))
            {
                string[] FilesPath = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

                Size += DeleteFiles(FilesPath, DoClean);

                string Path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\";

                string[] array = { Path + "Cookies" };
                Size += DeleteFiles(array, DoClean);
            }
            return "Chrome, " + Lang.Cookies + ": " + Size + " MB" + "\n\n";
        }
        public static string CleanChromeSession(bool DoClean)
        {
            double Size = 0;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\";

            string[] array = { Path + "Last Session", Path + "Current Session" };
            Size += DeleteFiles(array, DoClean);

            return "Chrome, " + Lang.Session + ": " + Size + " MB" + "\n\n";
        }
        public static string CleanChromePasswords(bool DoClean)
        {
            double Size = 0;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\";

            string[] array = { Path + "Login Data" };
            Size += DeleteFiles(array, DoClean);

            return "Chrome, " + Lang.Passwords + ": " + Size + " MB" + "\n\n";
        }
        /* opera */
        public static string CleanOperaCache(bool DoClean)
        {
            double Size = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Opera Software\\Opera Stable\\Cache\\";
            if (Directory.Exists(path))
            {
                string[] FilesPath = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                Size += DeleteFiles(FilesPath, DoClean);
                if (DoClean)
                {
                    DirectoryInfo di = new DirectoryInfo(path);
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        try
                        {
                            dir.Delete(true);
                        }
                        catch { }
                    }
                }
            }
            return "Opera, " + Lang.Cache + ": " + Size + " MB" + "\n\n";
        }
        public static string CleanOperaHistory(bool DoClean)
        {
            double Size = 0;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\";

            string[] array = { Path + "Visited Links", Path + "Current Tabs", Path + "Top Sites", Path + "History Provider Cache", Path + "Network Action Predictor", Path + "History" };
            Size += DeleteFiles(array, DoClean);

            return "Opera, " + Lang.History + ": " + Size + " MB" + "\n\n";
        }
        public static string CleanOperaCookies(bool DoClean)
        {
            double Size = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\";
            if (Directory.Exists(path))
            {
                string[] array = { path + "Cookies", path + "Cookies-journal"};
                Size += DeleteFiles(array, DoClean);
            }
            return "Opera, " + Lang.Cookies + ": " + Size + " MB" + "\n\n";
        }
        public static string CleanOperaSession(bool DoClean)
        {
            double Size = 0;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\";

            string[] array = { Path + "Last Session", Path + "Current Session" };
            Size += DeleteFiles(array, DoClean);

            return "Opera, " + Lang.Session + ": " + Size + " MB" + "\n\n";
        }
        public static string CleanOperaPasswords(bool DoClean)
        {
            double Size = 0;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\";

            string[] array = { Path + "Login Data" };
            Size += DeleteFiles(array, DoClean);

            return "Opera, " + Lang.Passwords + ": " + Size + " MB" + "\n\n";
        }
        ////////////
        private static double DeleteFiles(string[] PathToFiles, bool DoDelete)
        {
            float Size = 0;
            foreach (string path in PathToFiles)
            {
                try
                {
                    FileInfo info = new FileInfo(path);
                    Size += info.Length;
                    try
                    {
                        if (DoDelete)
                            File.Delete(path);
                    }
                    catch { Size -= info.Length; }
                } catch { }
            }
            return Math.Round(Size / (1024 * 1024), 2);
        }          
    }
}

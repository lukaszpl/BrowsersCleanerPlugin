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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace BrowsersCleanerPlugin
{
    public class Items
    {
        public static TextBlock GetFirefoxTextBlock()
        {
            TextBlock tb = new TextBlock();
            BitmapImage MyImageSource = new BitmapImage(new Uri("pack://application:,,,/BrowsersCleanerPlugin;component/Resources/mozilla_firefox.png", UriKind.RelativeOrAbsolute));

            Image image = new Image();
            image.Source = MyImageSource;
            image.Width = 24;
            image.Height = 24;
            image.Visibility = Visibility.Visible;

            InlineUIContainer container = new InlineUIContainer(image);
            tb.Inlines.Add(container);

            var textRem = new Run("Firefox:");
            tb.Inlines.Add(textRem);
            tb.FontWeight = FontWeights.Bold;

            return tb;
        }
        public static CheckBox GetFirefoxCacheCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_FirefoxCache";
            checkBox.Content = Lang.Cache;
            return checkBox;
        }
        public static CheckBox GetFirefoxHistoryCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_FirefoxHistory";
            checkBox.Content = Lang.History;
            return checkBox;
        }
        public static CheckBox GetFirefoxDownloadCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_FirefoxDownload";
            checkBox.Content = Lang.Download;
            return checkBox;
        }
        public static CheckBox GetFirefoxCookiesCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_FirefoxCookies";
            checkBox.Content = Lang.Cookies;
            return checkBox;
        }
        public static CheckBox GetFirefoxPasswordsCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_FirefoxPasswords";
            checkBox.Content = Lang.Passwords;
            return checkBox;
        }
        public static CheckBox GetFirefoxSitesSettingsCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_FirefoxSitesSettings";
            checkBox.Content = Lang.SitesSettings;
            return checkBox;
        }
        ///
        public static TextBlock GetChromeTextBlock()
        {
            TextBlock tb = new TextBlock();
            BitmapImage MyImageSource = new BitmapImage(new Uri("pack://application:,,,/BrowsersCleanerPlugin;component/Resources/chrome.png", UriKind.RelativeOrAbsolute));

            Image image = new Image();
            image.Source = MyImageSource;
            image.Width = 24;
            image.Height = 24;
            image.Visibility = Visibility.Visible;

            InlineUIContainer container = new InlineUIContainer(image);
            tb.Inlines.Add(container);

            var textRem = new Run("Google Chrome:");
            tb.Inlines.Add(textRem);
            tb.FontWeight = FontWeights.Bold;

            return tb;
        }
        public static CheckBox GetChromeCacheCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_ChromeCache";
            checkBox.Content = Lang.Cache;
            return checkBox;
        }
        public static CheckBox GetChromeHistoryCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_ChromeHistory";
            checkBox.Content = Lang.History;
            return checkBox;
        }
        public static CheckBox GetChromeSessionCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_ChromeSession";
            checkBox.Content = Lang.Session;
            return checkBox;
        }
        public static CheckBox GetChromeCookiesCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_ChromeCookies";
            checkBox.Content = Lang.Cookies;
            return checkBox;
        }
        public static CheckBox GetChromePasswordsCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_ChromePasswords";
            checkBox.Content = Lang.Passwords;
            return checkBox;
        }

        public static TextBlock GetOperaTextBlock()
        {
            TextBlock tb = new TextBlock();
            BitmapImage MyImageSource = new BitmapImage(new Uri("pack://application:,,,/BrowsersCleanerPlugin;component/Resources/opera.png", UriKind.RelativeOrAbsolute));

            Image image = new Image();
            image.Source = MyImageSource;
            image.Width = 24;
            image.Height = 24;
            image.Visibility = Visibility.Visible;

            InlineUIContainer container = new InlineUIContainer(image);
            tb.Inlines.Add(container);

            var textRem = new Run("Opera:");
            tb.Inlines.Add(textRem);
            tb.FontWeight = FontWeights.Bold;

            return tb;
        }
        public static CheckBox GetOperaCacheCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_OperaCache";
            checkBox.Content = Lang.Cache;
            return checkBox;
        }
        public static CheckBox GetOperaHistoryCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_OperaHistory";
            checkBox.Content = Lang.History;
            return checkBox;
        }
        public static CheckBox GetOperaSessionCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_OperaSession";
            checkBox.Content = Lang.Session;
            return checkBox;
        }
        public static CheckBox GetOperaCookiesCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_OperaCookies";
            checkBox.Content = Lang.Cookies;
            return checkBox;
        }
        public static CheckBox GetOperaPasswordsCheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "BrowsersPlugin_OperaPasswords";
            checkBox.Content = Lang.Passwords;
            return checkBox;
        }
    }
}

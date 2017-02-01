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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace BrowsersCleanerPlugin
{
    public class Main
    {
        #region informations
        public int CleanerNetVersion { get { return 1; } }
        public string PluginName { get { return "Browsers Plugin v" + Assembly.GetExecutingAssembly().GetName().Version.ToString(); } }
        #endregion 

        CheckBox FirefoxCache_checkBox = Items.GetFirefoxCacheCheckBox();
        CheckBox FirefoxHistory_checkBox = Items.GetFirefoxHistoryCheckBox();
        CheckBox FirefoxDownload_checkBox = Items.GetFirefoxDownloadCheckBox();
        CheckBox FirefoxCookies_checkBox = Items.GetFirefoxCookiesCheckBox();
        CheckBox FirefoxPasswords_checkBox = Items.GetFirefoxPasswordsCheckBox();
        CheckBox FirefoxSitesSettings_checkBox = Items.GetFirefoxSitesSettingsCheckBox();

        CheckBox ChromeCache_checkBox = Items.GetChromeCacheCheckBox();
        CheckBox ChromeHistory_checkBox = Items.GetChromeHistoryCheckBox();
        CheckBox ChromeSession_checkBox = Items.GetChromeSessionCheckBox();
        CheckBox ChromeCookies_checkBox = Items.GetChromeCookiesCheckBox();
        CheckBox ChromePasswords_checkBox = Items.GetChromePasswordsCheckBox();

        CheckBox OperaCache_checkBox = Items.GetOperaCacheCheckBox();
        CheckBox OperaHistory_checkBox = Items.GetOperaHistoryCheckBox();
        CheckBox OperaSession_checkBox = Items.GetOperaSessionCheckBox();
        CheckBox OperaCookies_checkBox = Items.GetOperaCookiesCheckBox();
        CheckBox OperaPasswords_checkBox = Items.GetOperaPasswordsCheckBox();

        /* Method return objects for ItemsControl*/
        public List<object> GUIElements()
        {
            List<object> objList = new List<object>();
            // firefox
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles\\")){
                objList.Add(Items.GetFirefoxTextBlock());
                objList.Add(FirefoxCache_checkBox);
                objList.Add(FirefoxHistory_checkBox);
                objList.Add(FirefoxDownload_checkBox);
                objList.Add(FirefoxCookies_checkBox);
                objList.Add(FirefoxPasswords_checkBox);
                objList.Add(FirefoxSitesSettings_checkBox);
            }
            //chrome
            if(Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\")){
                objList.Add(Items.GetChromeTextBlock());
                objList.Add(ChromeCache_checkBox);
                objList.Add(ChromeHistory_checkBox);
                objList.Add(ChromeSession_checkBox);
                objList.Add(ChromeCookies_checkBox);
                objList.Add(ChromePasswords_checkBox);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Opera Software\\Opera Stable\\Cache\\"))
            {
                objList.Add(Items.GetOperaTextBlock());
                objList.Add(OperaCache_checkBox);
                objList.Add(OperaHistory_checkBox);
                objList.Add(OperaSession_checkBox);
                objList.Add(OperaCookies_checkBox);
                objList.Add(OperaPasswords_checkBox);
            }
            //add object for execute code in PluginMethod, pose IndexToExecute
            CheckBox hidden = new CheckBox();
            hidden.IsChecked = true;
            hidden.Name = "Hidden";
            hidden.Visibility = Visibility.Collapsed;
            objList.Add(hidden);
            return objList;
        }

        /* Events for elements */
        bool FirefoxIsRunning = false;
        bool ChromeIsRunning = false;
        bool OperaIsRunning = false;
        public string PluginMethod(CheckBox obj, bool DoClean, Dispatcher GuiThr, CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            int IndexToExecute = 0;
            GuiThr.Invoke(new Action(() =>
            {
                if (obj == FirefoxCache_checkBox)
                    IndexToExecute = 1;
                if (obj == FirefoxHistory_checkBox)
                    IndexToExecute = 2;
                if (obj == FirefoxDownload_checkBox)
                    IndexToExecute = 3;
                if (obj == FirefoxCookies_checkBox)
                    IndexToExecute = 4;
                if (obj == FirefoxPasswords_checkBox)
                    IndexToExecute = 5;
                if (obj == FirefoxSitesSettings_checkBox)
                    IndexToExecute = 6;

                if (obj == ChromeCache_checkBox)
                    IndexToExecute = 7;
                if (obj == ChromeHistory_checkBox)
                    IndexToExecute = 8;
                if (obj == ChromeSession_checkBox)
                    IndexToExecute = 9;
                if (obj == ChromeCookies_checkBox)
                    IndexToExecute = 10;
                if (obj == ChromePasswords_checkBox)
                    IndexToExecute = 11;

                if (obj == OperaCache_checkBox)
                    IndexToExecute = 12;
                if (obj == OperaHistory_checkBox)
                    IndexToExecute = 13;
                if (obj == OperaSession_checkBox)
                    IndexToExecute = 14;
                if (obj == OperaCookies_checkBox)
                    IndexToExecute = 15;
                if (obj == OperaPasswords_checkBox)
                    IndexToExecute = 16;
            }));
        
            if ((((RunningPrograms.GetIsItRunningProcess("firefox")) && (!FirefoxIsRunning)) && (DoClean)) && ((IndexToExecute == 1) || (IndexToExecute == 2) || (IndexToExecute == 3) || (IndexToExecute == 4) || (IndexToExecute == 5) || (IndexToExecute == 6)))
            {
                GuiThr.Invoke(new Action(() =>
                {
                    MessageBox.Show("Firefox " + Lang.ProgramIsRunning, Lang.Warning, MessageBoxButton.OK, MessageBoxImage.Warning);
                }));
                FirefoxIsRunning = true;
            }
            if ((((RunningPrograms.GetIsItRunningProcess("chrome")) && (!ChromeIsRunning)) && (DoClean)) && ((IndexToExecute == 7) || (IndexToExecute == 8) || (IndexToExecute == 9) || (IndexToExecute == 10) || (IndexToExecute == 11)))
            {
                GuiThr.Invoke(new Action(() =>
                {
                    MessageBox.Show("Chrome " + Lang.ProgramIsRunning, Lang.Warning, MessageBoxButton.OK, MessageBoxImage.Warning);
                }));
                ChromeIsRunning = true;
            }
            if ((((RunningPrograms.GetIsItRunningProcess("opera")) && (!OperaIsRunning)) && (DoClean)) && ((IndexToExecute == 12) || (IndexToExecute == 13) || (IndexToExecute == 14) || (IndexToExecute == 15) || (IndexToExecute == 16)))
            {
                GuiThr.Invoke(new Action(() =>
                {
                    MessageBox.Show("Opera " + Lang.ProgramIsRunning, Lang.Warning, MessageBoxButton.OK, MessageBoxImage.Warning);
                }));
                OperaIsRunning = true;
            }

            if (IndexToExecute == 1)
            {
                if (!FirefoxIsRunning)
                    return CleanClass.CleanFirefoxCache(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 2)
            {
                if (!FirefoxIsRunning)
                    return CleanClass.CleanFirefoxHistory(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 3)
            {
                if (!FirefoxIsRunning)
                    return CleanClass.CleanFirefoxDownload(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 4)
            {
                if (!FirefoxIsRunning)
                    return CleanClass.CleanFirefoxCookies(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 5)
            {
                if (!FirefoxIsRunning)
                    return CleanClass.CleanFirefoxPasswords(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 6)
            {
                if (!FirefoxIsRunning)
                    return CleanClass.CleanFirefoxSitesSettings(DoClean);
                else
                    return null;
            }

            ///////////////////////////////////////////////////////////////
            if (IndexToExecute == 7)
            {
                if (!ChromeIsRunning)
                    return CleanClass.CleanChromeCache(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 8)
            {
                if (!ChromeIsRunning)
                    return CleanClass.CleanChromeHistory(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 9)
            {
                if (!ChromeIsRunning)
                    return CleanClass.CleanChromeSession(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 10)
            {
                if (!ChromeIsRunning)
                    return CleanClass.CleanChromeCookies(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 11)
            {
                if (!ChromeIsRunning)
                    return CleanClass.CleanChromePasswords(DoClean);
                else
                    return null;
            }

            //////////////////////////////////////////////////
            if (IndexToExecute == 12)
            {
                if (!OperaIsRunning)
                    return CleanClass.CleanOperaCache(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 13)
            {
                if (!OperaIsRunning)
                    return CleanClass.CleanOperaHistory(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 14)
            {
                if (!OperaIsRunning)
                    return CleanClass.CleanOperaSession(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 15)
            {
                if (!OperaIsRunning)
                    return CleanClass.CleanOperaCookies(DoClean);
                else
                    return null;
            }
            if (IndexToExecute == 16)
            {
                if (!OperaIsRunning)
                    return CleanClass.CleanOperaPasswords(DoClean);
                else
                    return null;
            }

            FirefoxIsRunning = false;
            ChromeIsRunning = false;
            OperaIsRunning = false;

            return null;
        }
    }

}

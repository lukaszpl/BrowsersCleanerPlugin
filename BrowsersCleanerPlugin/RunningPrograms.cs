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
using System.Diagnostics;

namespace BrowsersCleanerPlugin
{
    class RunningPrograms
    {
        public static bool GetIsItRunningProcess(string name)
        {
            Process[] AllProcess = Process.GetProcesses();
            foreach (Process process in AllProcess)
            {
                if (process.ProcessName == name)
                    return true;
            }
            return false;
        }
    }
}

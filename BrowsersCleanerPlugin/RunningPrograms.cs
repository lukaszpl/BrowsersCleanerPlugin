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

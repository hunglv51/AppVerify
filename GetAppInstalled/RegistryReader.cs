using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAppInstalled
{
    public static class RegitryReader
    {
        static void GetNameApp(HashSet<string> listApp, RegistryHive hive, RegistryView view, string registryKey)
        {
            using (RegistryKey key = RegistryKey.OpenBaseKey(hive, view).OpenSubKey(registryKey))
            {
                foreach (var subKeyName in key.GetSubKeyNames())
                {
                    using (RegistryKey subKey = key.OpenSubKey(subKeyName))
                    {
                        if (subKey.GetValue("DisplayName") != null)
                        {
                            listApp.Add(subKey.GetValue("DisplayName").ToString());
                        }
                    }
                }
            }
        }

       //public static void VerifyApps(List<string> validApps, List<string> invalidApps, HashSet<string> listApp, string[] allowedApps)
       // {
       //     foreach (var appName in listApp)
       //     {
       //         if (IsAllowedApp(appName, allowedApps))
       //             validApps.Add(appName);
       //         else
       //             invalidApps.Add(appName);

       //     }
       // }

       // static bool IsAllowedApp(string appName, string[] allowedApps)
       // {
       //     //foreach (var keyword in AllowedAppName.AlwaysPassKeyWord)
       //     //{
       //     //    if (appName.ToLower().Contains(keyword.ToLower()))
       //     //        return true;
       //     //}

       //     //foreach (var app in allowedApps)
       //     //{
       //     //    if (appName.ToLower().Contains(app.ToLower()))
       //     //        return true;
       //     //}
       //     return false;

       // }

       public  static HashSet<string> GetInstalledApps()
        {
            string registryKey32Bit = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string registryKey64Bit = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            HashSet<string> listApp = new HashSet<string>();

            if (Environment.Is64BitOperatingSystem)
            {
                GetNameApp(listApp, RegistryHive.CurrentUser, RegistryView.Registry64, registryKey32Bit);
                GetNameApp(listApp, RegistryHive.LocalMachine, RegistryView.Registry64, registryKey32Bit);
                GetNameApp(listApp, RegistryHive.LocalMachine, RegistryView.Registry64, registryKey64Bit);
            }
            else
            {
                GetNameApp(listApp, RegistryHive.CurrentUser, RegistryView.Registry32, registryKey32Bit);
                GetNameApp(listApp, RegistryHive.LocalMachine, RegistryView.Registry32, registryKey32Bit);
                GetNameApp(listApp, RegistryHive.LocalMachine, RegistryView.Registry32, registryKey64Bit);
            }
            return listApp;
        }
    }
}

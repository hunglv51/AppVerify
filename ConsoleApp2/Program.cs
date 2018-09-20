﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
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

        static void VerifyApps(List<string> validApps, List<string> invalidApps, HashSet<string> listApp, string[] allowedApps)
        {
            foreach(var appName in listApp)
            {
                if (IsAllowedApp(appName, allowedApps))
                    validApps.Add(appName);
                else
                    invalidApps.Add(appName);

            }
        }

        static bool IsAllowedApp(string appName, string[] allowedApps)
        {
            foreach(var keyword in AllowedAppName.AlwaysPassKeyWord)
            {
                if (appName.ToLower().Contains(keyword.ToLower()))
                    return true;
            }

            foreach (var app in allowedApps)
            {
                if (appName.ToLower().Contains(app.ToLower()))
                    return true;
            }
            return false;

        }

        static HashSet<string> GetInstalledApps()
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
        static void Main(string[] args)
        {

            HashSet<string> listApp = GetInstalledApps();
            List<string> validApp = new List<string>();
            List<string> inValidApp = new List<string>();
            VerifyApps(validApp, inValidApp, listApp, AllowedAppName.AllAllowedApps);
            Console.WriteLine("Vallid App:" + validApp.Count);
            foreach (var name in validApp)
                Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("Invalid App:" + inValidApp.Count);
            foreach (var name in inValidApp)
                Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}

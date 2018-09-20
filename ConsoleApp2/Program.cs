using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Security.AccessControl;

namespace ConsoleApp2
{
    class Program
    {

        static void AddNameApp(HashSet<string> listApp, RegistryHive hive, RegistryView view)
        {

        }
        static void Main(string[] args)
        {
            string registryKey32Bit = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string registryKey64Bit = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            HashSet<object> AppList = new HashSet<object>();




            //using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKey32Bit,RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.ReadKey))
            //{
            //    //RegistrySecurity rs = new RegistrySecurity();
            //    //rs = key.GetAccessControl();
            //    //string currentUserStr = Environment.UserDomainName + "\\" + Environment.UserName;
            //    //rs.AddAccessRule(new RegistryAccessRule(currentUserStr, RegistryRights.ReadKey, AccessControlType.Allow));
            //    foreach (var subKeyName in key.GetSubKeyNames())
            //    {
            //        using (RegistryKey subKey = key.OpenSubKey(subKeyName))
            //        {

            //            if (subKey.GetValue("DisplayName") != null)
            //            {
            //                Console.WriteLine("App Name: " + subKey.GetValue("DisplayName"));
            //                AppList.Add(subKey.GetValue("DisplayName"));
            //                l.Add(subKey.GetValue("DisplayName"));
            //            }
            //            else
            //                Console.WriteLine(subKey);
            //        }
            //    }

            //}


            //using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey32Bit, RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.ReadKey))

            //{
            //    //RegistrySecurity rs = new RegistrySecurity();
            //    //rs = key.GetAccessControl();
            //    //string currentUserStr = Environment.UserDomainName + "\\" + Environment.UserName;
            //    //rs.AddAccessRule(new RegistryAccessRule(currentUserStr, RegistryRights.ReadKey, AccessControlType.Allow));
            //    foreach (var subKeyName in key.GetSubKeyNames())
            //    {
            //        using (RegistryKey subKey = key.OpenSubKey(subKeyName))
            //        {
            //            var keyName = subKey.GetValue("DisplayName");

            //            if (keyName != null)
            //            {
            //                l.Add(subKey.GetValue("DisplayName"));
            //                AppList.Add(subKey.GetValue("DisplayName"));
            //                Console.WriteLine("App Name: " + subKey.GetValue("DisplayName"));
            //            }
            //            else
            //                Console.WriteLine(subKey);
            //        }
            //    }

            //}
            //using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey64Bit, RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.ReadKey))

            //{
            //    //RegistrySecurity rs = new RegistrySecurity();
            //    //rs = key.GetAccessControl();
            //    //string currentUserStr = Environment.UserDomainName + "\\" + Environment.UserName;
            //    //rs.AddAccessRule(new RegistryAccessRule(currentUserStr, RegistryRights.ReadKey, AccessControlType.Allow));
            //    foreach (var subKeyName in key.GetSubKeyNames())
            //    {
            //        using (RegistryKey subKey = key.OpenSubKey(subKeyName))
            //        {
            //            if (subKey.GetValue("DisplayName") != null)
            //            {
            //                l.Add(subKey.GetValue("DisplayName"));
            //                AppList.Add(subKey.GetValue("DisplayName"));
            //                Console.WriteLine("App Name: " + subKey.GetValue("DisplayName"));
            //            }
            //            else
            //                Console.WriteLine(subKey);
            //        }
            //    }

            //}
            ////foreach (var appName in AppList)
            ////{
            ////    Console.WriteLine(appName);
            ////}
            //Console.WriteLine(AppList.Count);
            //Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Git_is1")
            using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(registryKey32Bit))
            {
                foreach (var subKeyName in key.GetSubKeyNames())
                {
                    using (RegistryKey subKey = key.OpenSubKey(subKeyName))
                    {
                        if (subKey.GetValue("DisplayName") != null)
                        {
                            Console.WriteLine("App Name: " + subKey.GetValue("DisplayName"));
                        }
                        else
                            Console.WriteLine(subKey);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

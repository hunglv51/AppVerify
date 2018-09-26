using System;
using System.Collections.Generic;
using System.IO;

namespace StatisticApp
{
    public static class TextFileUltility
    {

        public static VerifyResult VerifyApps(string fileName, string allowAppFileName)
        {
            var file = new FileInfo(fileName);
            var rs = new VerifyResult();
            List<string> allowedApp = LoadAllowApp(allowAppFileName);
            using(var reader = file.OpenText())
            {
                string[] fileContent = reader.ReadToEnd().Split(';');
                string encrytedKey = fileContent[0];
                string encrytedData = fileContent[1];
                RSADecryptUltility.SetMD5Key(encrytedKey);
                string decryptedData = RSADecryptUltility.MD5Decrypt(encrytedData);
                string[] appsName = decryptedData.Split(';');
                rs.Username = appsName[0];
                for(int i = 1;i < appsName.Length;i++)
                {

                    if (AllowedAppName.IsAllowedApp(appsName[i], allowedApp))
                    {
                        rs.ValidApps.Add(appsName[i]);
                    }
                    else
                    {
                        rs.InValidApps.Add(appsName[i]);
                    }
                }
            }
            return rs;
        }

        public static List<string> LoadAllowApp(string fileName)
        {
            var rs = new List<string>();
            var file = new FileInfo(fileName);
            using (var reader = file.OpenText())
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (IsIgnoredString(line))
                        continue;
                    rs.Add(line);
                }
            }
            return rs;
        }

        private static bool IsIgnoredString(string line)
        {
            if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line) || line.StartsWith("---"))
                return true;
            return false;
        }

    }
}

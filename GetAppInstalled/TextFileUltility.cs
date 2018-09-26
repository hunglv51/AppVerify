using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace GetAppInstalled
{
    public static class TextFileUltility
    {
        public static string CreateFileResult(HashSet<string> listApp)
        {
            var username = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            FileInfo file = new FileInfo(username + "_list_app" + DateTime.Now.ToString("yyyy-MM-dd_hh-mm") + ".klo");
            if (file.Exists)
            {
                file.Delete();
            }
            using (var writer = file.AppendText())
            {
                writer.Write(RSAEncryptUltility.GetEncryptedKey() + ";");
                
                WriteFile(listApp, writer, username);
                writer.Close();
            }
            return file.FullName;
        }

        public static void WriteFile(HashSet<string> data, StreamWriter writer, string username) {
            StringBuilder sb = new StringBuilder(username);
            List<string> sortedListApp = data.OrderBy(a => a).ToList();
            foreach(var app in sortedListApp.OrderBy(a => a))
            {
                sb.Append(";");
                sb.Append(app);
            }
            var tmp = sb.ToString();
            writer.Write(RSAEncryptUltility.MD5Encrypt(sb.ToString()));

        }



    }
}

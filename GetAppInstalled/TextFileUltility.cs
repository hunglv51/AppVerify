using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetAppInstalled
{
    public static class TextFileUltility
    {
        public static string CreateFileResult(HashSet<string> listApp)
        {
            var username = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            FileInfo file = new FileInfo(username + "_list_app.txt");
            if (file.Exists)
            {
                file.Delete();
            }
            using (var writer = file.CreateText())
            {
                writer.WriteLine(EncryptUltility.EncodeData(username));
                WriteFile(listApp, writer);
                writer.Close();
            }
            return file.FullName;
        }

        public static void WriteFile(HashSet<string> data, StreamWriter writer) {
            foreach(var app in data)
            {
                writer.WriteLine(EncryptUltility.EncodeData(app));
            }

        }

       

    }
}

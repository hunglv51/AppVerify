using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                rs.Username = EncryptUltility.DecodeData(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    string decodedString = EncryptUltility.DecodeData(reader.ReadLine());
                    if (AllowedAppName.IsAllowedApp(decodedString, allowedApp))
                    {
                        rs.ValidApps.Add(decodedString);
                    }
                    else
                    {
                        rs.InValidApps.Add(decodedString);
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
                    rs.Add(reader.ReadLine());
                }
            }
            return rs;
        }

    }
}

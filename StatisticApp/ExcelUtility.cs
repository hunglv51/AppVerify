using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticApp
{
    public static class ExcelUtility
    {
        public static void CreateExcel(string dirPath, string allowAppFileName, Action<int, int> updateStatus)
        {
            var outputFile = new FileInfo(dirPath + @"\statistic_result_" + DateTime.Now.ToString("yyyy-MM-dd_hh-mm") + ".xlsx");
            if (outputFile.Exists)
            {
                outputFile.Delete();
            }
            using (var excel = new ExcelPackage())
            {
                string[] files = Directory.GetFiles(dirPath, "*.klo", SearchOption.TopDirectoryOnly);
                //foreach(var file in files)
                //{
                //    CreateSheet(excel, file, allowAppFileName);
                //}
                if (files.Length < 1)
                    throw new Exception("Your directory does not contain input files");

                for(int i = 0;i < files.Length; i++)
                {
                    CreateSheet(excel, files[i], allowAppFileName);
                    updateStatus(i + 1, files.Length);
                }

                excel.SaveAs(outputFile);
            }
        }

        private static void CreateSheet(ExcelPackage excel, string fileName, string allowAppFileName)
        {
            var verifyResult = TextFileUltility.VerifyApps(fileName, allowAppFileName);
            var workSheet = excel.Workbook.Worksheets.Add(verifyResult.Username);

            workSheet.Cells["A1:B1"].Merge = true;
            workSheet.Cells["A1:B1"].Value = verifyResult.Username;
            workSheet.Cells["A2"].Value = "Valid Apps: " + verifyResult.ValidApps.Count;
            workSheet.Cells["B2"].Value = "Invalid Apps: " + verifyResult.InValidApps.Count;
            workSheet.Cells["A3:A" + (verifyResult.ValidApps.Count + 2)].LoadFromCollection(verifyResult.ValidApps);
            workSheet.Cells["B3:B" + (verifyResult.InValidApps.Count + 2)].LoadFromCollection(verifyResult.InValidApps);
            workSheet.Cells["A2:A" + (verifyResult.ValidApps.Count + 2)].AutoFitColumns();
            workSheet.Cells["B2:B" + (verifyResult.InValidApps.Count + 2)].AutoFitColumns();
        } 
    }
}

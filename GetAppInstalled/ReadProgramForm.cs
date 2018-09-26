using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GetAppInstalled
{
    public partial class ReadProgramForm : Form
    {
        private string resultFileLocation;
        public ReadProgramForm()
        {
            InitializeComponent();
            SetBeginUI();
        }

        

        private void btnListApp_Click(object sender, EventArgs e)
        {
            SetRunUI();
            HashSet<string> listApp = RegitryReader.GetInstalledApps();
            string filePath= TextFileUltility.CreateFileResult(listApp);
            SetEndUI(filePath);
        }

        private void SetBeginUI()
        {
            this.btnLocation.Hide();
            this.MaximizeBox = false;
            CenterAlignControl(this.btnListApp);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.lblStatus.Text = "Click get list application button to collect your list application";
        }

        private void SetEndUI(string filePath)
        {
            this.lblStatus.Text = "Getting list application completed";
            this.lblStatus.Text =  "Your result file located at " + filePath;
            this.resultFileLocation = filePath;
            this.progressBar.Value = 100;
            this.btnLocation.Show();

        }

        private void SetRunUI()
        {
            this.lblStatus.Text = "Getting list your applications from registry";
            this.progressBar.Value = 50;

        }

        private void CenterAlignControl(Control control)
        {
            int containerWidth = this.Width;
            control.Location = new Point((containerWidth - control.Width) / 2, control.Location.Y);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetListAppForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            Process.Start(new FileInfo(this.resultFileLocation).DirectoryName);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GetAppInstalled
{
    public partial class GetListAppForm : Form
    {
        public GetListAppForm()
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
            this.lblContact.Hide();
            this.MaximizeBox = false;
            CenterAlignControl(this.lblContact);
            CenterAlignControl(this.btnListApp);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.lblLocation.Hide();
        }

        private void SetEndUI(string filePath)
        {
            this.lblContact.Show();
            this.lblStatus.Text = "Getting list application completed";
            this.lblLocation.Text =  "Your result located at " + filePath;
            this.lblLocation.Show();
            this.progressBar.Value = 100;

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
    }
}

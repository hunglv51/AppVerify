using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticApp
{
    public partial class frmVerify : Form
    {
        public frmVerify()
        {
            InitializeComponent();
            SetBeginUI();
        }

        

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (this.dlgSelectPath.ShowDialog() == DialogResult.OK)
            {
                string path = dlgSelectPath.SelectedPath;
                SetReadyUI(path);    
            }
            
        }

        

        private void btnGenerateExcel_Click(object sender, EventArgs e)
        {
            SetUIBeginGenerate();
            string dirPath = this.txtLocation.Text;
            string allowAppFileName = this.txtAllowApp.Text;
            ExcelUtility.CreateExcel(dirPath, allowAppFileName);
            SetUIEndGenerate();
        }

        private void SetBeginUI()
        {
            this.lblStatus.Text = "Please enter directory path";
            this.btnGenerateExcel.Enabled = false;
        }

        private void SetReadyUI(string path)
        {
            if (!String.IsNullOrEmpty(path))
            {
                this.txtLocation.Text = path;
                this.btnGenerateExcel.Enabled = true;
                this.txtLocation.Text = path;
                this.lblStatus.Text = "Ready";

            }
            else
                this.btnGenerateExcel.Enabled = false;
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            var txtLocation = sender as TextBox;
            SetReadyUI(txtLocation.Text);
        }

        private void SetUIBeginGenerate()
        {
            this.progressBar.Value = 50;
        }

        private void SetUIEndGenerate()
        {
            this.progressBar.Value = 100;
            this.lblStatus.Text = "Create excel file complete at same directory";

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAllowApp_Click(object sender, EventArgs e)
        {
            if (this.dlgFileSelect.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void txtAllowApp_TextChanged(object sender, EventArgs e)
        {
            var txtAllowApp = sender as TextBox;
            
        }

        private void SetAllowApp(object sender, CancelEventArgs e)
        {
            FileDialog fileDlg = sender as FileDialog;
            this.txtAllowApp.Text = fileDlg.FileName;
        }
    }
}

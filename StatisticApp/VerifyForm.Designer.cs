namespace StatisticApp
{
    partial class frmVerify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnGenerateExcel = new System.Windows.Forms.Button();
            this.dlgSelectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocaton = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAllowApp = new System.Windows.Forms.Label();
            this.txtAllowApp = new System.Windows.Forms.TextBox();
            this.btnAllowApp = new System.Windows.Forms.Button();
            this.dlgFileSelect = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLocation
            // 
            this.btnLocation.AutoSize = true;
            this.btnLocation.Location = new System.Drawing.Point(452, 52);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(38, 23);
            this.btnLocation.TabIndex = 0;
            this.btnLocation.Text = "...";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnGenerateExcel
            // 
            this.btnGenerateExcel.Location = new System.Drawing.Point(189, 120);
            this.btnGenerateExcel.Name = "btnGenerateExcel";
            this.btnGenerateExcel.Size = new System.Drawing.Size(151, 23);
            this.btnGenerateExcel.TabIndex = 1;
            this.btnGenerateExcel.Text = "Generate Excel file";
            this.btnGenerateExcel.UseVisualStyleBackColor = true;
            this.btnGenerateExcel.Click += new System.EventHandler(this.btnGenerateExcel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(92, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(91, 54);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(355, 20);
            this.txtLocation.TabIndex = 5;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // lblLocaton
            // 
            this.lblLocaton.AutoSize = true;
            this.lblLocaton.Location = new System.Drawing.Point(13, 57);
            this.lblLocaton.Name = "lblLocaton";
            this.lblLocaton.Size = new System.Drawing.Size(29, 13);
            this.lblLocaton.TabIndex = 6;
            this.lblLocaton.Text = "Path";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 161);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAllowApp
            // 
            this.lblAllowApp.AutoSize = true;
            this.lblAllowApp.Location = new System.Drawing.Point(16, 91);
            this.lblAllowApp.Name = "lblAllowApp";
            this.lblAllowApp.Size = new System.Drawing.Size(68, 13);
            this.lblAllowApp.TabIndex = 8;
            this.lblAllowApp.Text = "Allow app list";
            // 
            // txtAllowApp
            // 
            this.txtAllowApp.Location = new System.Drawing.Point(91, 91);
            this.txtAllowApp.Name = "txtAllowApp";
            this.txtAllowApp.Size = new System.Drawing.Size(355, 20);
            this.txtAllowApp.TabIndex = 9;
            this.txtAllowApp.TextChanged += new System.EventHandler(this.txtAllowApp_TextChanged);
            // 
            // btnAllowApp
            // 
            this.btnAllowApp.Location = new System.Drawing.Point(453, 91);
            this.btnAllowApp.Name = "btnAllowApp";
            this.btnAllowApp.Size = new System.Drawing.Size(37, 23);
            this.btnAllowApp.TabIndex = 10;
            this.btnAllowApp.Text = "...";
            this.btnAllowApp.UseVisualStyleBackColor = true;
            this.btnAllowApp.Click += new System.EventHandler(this.btnAllowApp_Click);
            // 
            // dlgFileSelect
            // 
            this.dlgFileSelect.FileName = "openFileDialog1";
            this.dlgFileSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.SetAllowApp);
            // 
            // frmVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 183);
            this.Controls.Add(this.btnAllowApp);
            this.Controls.Add(this.txtAllowApp);
            this.Controls.Add(this.lblAllowApp);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblLocaton);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnGenerateExcel);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmVerify";
            this.Text = "Verify Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnGenerateExcel;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocaton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblAllowApp;
        private System.Windows.Forms.TextBox txtAllowApp;
        private System.Windows.Forms.Button btnAllowApp;
        private System.Windows.Forms.OpenFileDialog dlgFileSelect;
    }
}


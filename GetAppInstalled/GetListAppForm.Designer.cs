namespace GetAppInstalled
{
    partial class GetListAppForm
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
            this.btnListApp = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListApp
            // 
            this.btnListApp.AutoSize = true;
            this.btnListApp.Location = new System.Drawing.Point(196, 112);
            this.btnListApp.Name = "btnListApp";
            this.btnListApp.Size = new System.Drawing.Size(142, 23);
            this.btnListApp.TabIndex = 0;
            this.btnListApp.Text = "Get list appication installed";
            this.btnListApp.UseVisualStyleBackColor = true;
            this.btnListApp.Click += new System.EventHandler(this.btnListApp_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(111, 170);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(251, 13);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Please send result file to nguyen.hai.nam@kloon.vn";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lblStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 235);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(756, 22);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "statusStrip1";
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
            this.lblStatus.Size = new System.Drawing.Size(400, 17);
            this.lblStatus.Text = "            ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLocation
            // 
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLocation.Location = new System.Drawing.Point(0, 222);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(756, 13);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 9;
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
            this.menuExit.Size = new System.Drawing.Size(180, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // GetListAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 257);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.btnListApp);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GetListAppForm";
            this.Text = "Get list application installed";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListApp;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
    }
}


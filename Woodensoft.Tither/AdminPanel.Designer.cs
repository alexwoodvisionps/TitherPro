namespace Woodensoft.Tither
{
    partial class AdminPanel
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
            this.btnManageUSers = new System.Windows.Forms.Button();
            this.btnManageTithers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageUSers
            // 
            this.btnManageUSers.Location = new System.Drawing.Point(76, 53);
            this.btnManageUSers.Name = "btnManageUSers";
            this.btnManageUSers.Size = new System.Drawing.Size(222, 132);
            this.btnManageUSers.TabIndex = 0;
            this.btnManageUSers.Text = "Manage/Add Users";
            this.btnManageUSers.UseVisualStyleBackColor = true;
            this.btnManageUSers.Click += new System.EventHandler(this.btnManageUSers_Click);
            // 
            // btnManageTithers
            // 
            this.btnManageTithers.Location = new System.Drawing.Point(76, 351);
            this.btnManageTithers.Name = "btnManageTithers";
            this.btnManageTithers.Size = new System.Drawing.Size(231, 140);
            this.btnManageTithers.TabIndex = 1;
            this.btnManageTithers.Text = "Manage/Add Tithers";
            this.btnManageTithers.UseVisualStyleBackColor = true;
            this.btnManageTithers.Click += new System.EventHandler(this.btnManageTithers_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 139);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage/Add New Tithes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewStats
            // 
            this.btnViewStats.Location = new System.Drawing.Point(500, 53);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(219, 132);
            this.btnViewStats.TabIndex = 3;
            this.btnViewStats.Text = "View Statistics";
            this.btnViewStats.UseVisualStyleBackColor = true;
            this.btnViewStats.Click += new System.EventHandler(this.btnViewStats_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(500, 360);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(230, 131);
            this.btnExportData.TabIndex = 4;
            this.btnExportData.Text = "Export/See Tithing Totals";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 547);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnViewStats);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnManageTithers);
            this.Controls.Add(this.btnManageUSers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageUSers;
        private System.Windows.Forms.Button btnManageTithers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
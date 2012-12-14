namespace Woodensoft.Tither
{
    partial class ManageTithers
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
            this.gvTithers = new System.Windows.Forms.DataGridView();
            this.lblHEader = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCheckDups = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvTithers)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTithers
            // 
            this.gvTithers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvTithers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTithers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvTithers.Location = new System.Drawing.Point(23, 40);
            this.gvTithers.Name = "gvTithers";
            this.gvTithers.Size = new System.Drawing.Size(740, 342);
            this.gvTithers.TabIndex = 0;
            // 
            // lblHEader
            // 
            this.lblHEader.AutoSize = true;
            this.lblHEader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEader.Location = new System.Drawing.Point(240, 8);
            this.lblHEader.Name = "lblHEader";
            this.lblHEader.Size = new System.Drawing.Size(233, 29);
            this.lblHEader.TabIndex = 1;
            this.lblHEader.Text = "Tither Member List";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(455, 453);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(23, 453);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(192, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(245, 453);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(179, 20);
            this.txtMiddleName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Tither";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(652, 388);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(111, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCheckDups
            // 
            this.btnCheckDups.Location = new System.Drawing.Point(642, 421);
            this.btnCheckDups.Name = "btnCheckDups";
            this.btnCheckDups.Size = new System.Drawing.Size(138, 23);
            this.btnCheckDups.TabIndex = 10;
            this.btnCheckDups.Text = "Check For Duplicates";
            this.btnCheckDups.UseVisualStyleBackColor = true;
            this.btnCheckDups.Click += new System.EventHandler(this.btnCheckDups_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(652, 479);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageTithers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(824, 547);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCheckDups);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblHEader);
            this.Controls.Add(this.gvTithers);
            this.Name = "ManageTithers";
            this.Text = "Manage Tithers";
            this.Load += new System.EventHandler(this.ManageTithers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTithers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTithers;
        private System.Windows.Forms.Label lblHEader;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCheckDups;
        private System.Windows.Forms.Button btnRefresh;
    }
}
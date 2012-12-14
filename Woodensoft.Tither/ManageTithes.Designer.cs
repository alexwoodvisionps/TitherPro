namespace Woodensoft.Tither
{
    partial class ManageTithes
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
            this.gvTithes = new System.Windows.Forms.DataGridView();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dpTitheDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTithers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTithes)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTithes
            // 
            this.gvTithes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTithes.Location = new System.Drawing.Point(29, 26);
            this.gvTithes.Name = "gvTithes";
            this.gvTithes.Size = new System.Drawing.Size(808, 361);
            this.gvTithes.TabIndex = 0;
            this.gvTithes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTithes_CellDoubleClick);
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(322, 431);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(200, 20);
            this.dpEnd.TabIndex = 1;
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(76, 431);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(200, 20);
            this.dpStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(562, 428);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(728, 428);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(728, 488);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Tithe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dpTitheDate
            // 
            this.dpTitheDate.Location = new System.Drawing.Point(76, 488);
            this.dpTitheDate.Name = "dpTitheDate";
            this.dpTitheDate.Size = new System.Drawing.Size(200, 20);
            this.dpTitheDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tithe Date";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(322, 488);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(104, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount Tithed";
            // 
            // cboTithers
            // 
            this.cboTithers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTithers.FormattingEnabled = true;
            this.cboTithers.Location = new System.Drawing.Point(516, 487);
            this.cboTithers.Name = "cboTithers";
            this.cboTithers.Size = new System.Drawing.Size(121, 21);
            this.cboTithers.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pick A Tither";
            // 
            // ManageTithes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 545);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTithers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpTitheDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.gvTithes);
            this.Name = "ManageTithes";
            this.Text = "Manage Tithes";
            this.Load += new System.EventHandler(this.ManageTithes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTithes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTithes;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dpTitheDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTithers;
        private System.Windows.Forms.Label label5;
    }
}
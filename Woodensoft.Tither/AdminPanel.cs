using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Woodensoft.TitherPro.Core.BusinessLogic;
using Woodensoft.Tither.Utilities;
namespace Woodensoft.Tither
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void ValidateUser()
        {
            SessionValidator.ValidateSession(this, StateManager.Instance.GetUser());
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ValidateUser();
            if (!StateManager.Instance.GetUser().IsAdmin)
            {
                btnManageUSers.Visible = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StateManager.Instance.SetUser(null);
            this.Close();
        }

        private void btnManageUSers_Click(object sender, EventArgs e)
        {
            ValidateUser();
            Form frm = new UserManager();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ValidateUser();
            new ManageTithes().Show();
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            ValidateUser();
            new ViewStats().Show();
        }

        private void btnManageTithers_Click(object sender, EventArgs e)
        {
            ValidateUser();
            new ManageTithers().Show();
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            ValidateUser();
            new ExportTithes().Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dedicated To Anastasia Wood My Mom and Connie Davis my fiancee Copyright - Wooden Software Development Inc License: Your License Is Free, Expires: Never");
        }
    }
}

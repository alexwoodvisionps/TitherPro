using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace Woodensoft.Tither
{
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            gvUsers.DataSource = logic.GetAllUsers();
            gvUsers.Columns[0].ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            logic.AddUser(txtUser.Text, txtPass.Text, cbxAdmin.Checked);
            gvUsers.DataSource = logic.GetAllUsers();
        }

        private void gvUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());
            var row = gvUsers.Rows[e.RowIndex];
            var isAdmin = false;
            var isActive = false;
            var password = "";
            foreach(DataGridViewCell cell in row.Cells)
            {
                if (cell.State == DataGridViewElementStates.ReadOnly)
                    continue;
                if (cell.OwningColumn.Name.ToLower().Contains("password"))
                {
                    password = cell.Value.ToString();
                }
                if (cell.OwningColumn.Name.ToLower().Contains("isadmin"))
                {
                    isAdmin = (bool)cell.Value;
                }
                if (cell.OwningColumn.Name.ToLower().Contains("active"))
                {
                    isActive = (bool)cell.Value;
                }
            }
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            logic.UpdateUser((int)row.Cells[0].Value, password, isAdmin, isActive);
            
        }
    }
}

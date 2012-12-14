using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Woodensoft.TitherPro.Core.BusinessLogic;
using System.Configuration;
namespace Woodensoft.Tither
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var logic = new BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            StateManager.Instance.SetUser(logic.ValidateUserLogin(txtUsername.Text, txtPassword.Text));
            if (StateManager.Instance.GetUser() == null)
            {
                MessageBox.Show("Login Failed Either Your Username or Password was incorrect.");
                return;
            }
            Form frm = new AdminPanel();
            frm.Show();
            //this.Close();
        }
    }
}

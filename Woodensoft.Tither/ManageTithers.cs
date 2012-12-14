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
    public partial class ManageTithers : Form
    {
        public ManageTithers()
        {
            InitializeComponent();
        }

        private void ManageTithers_Load(object sender, EventArgs e)
        {
            Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            gvTithers.DataSource = logic.GetAllTithers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            logic.AddTither(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text);
            gvTithers.DataSource = logic.GetAllTithers();
        }

        private void btnCheckDups_Click(object sender, EventArgs e)
        {
            Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            
            gvTithers.DataSource = logic.RecommendTithers(txtFirstName.Text, txtLastName.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);

            var allTithers = logic.GetAllTithers();
            foreach (var tither in allTithers)
            {
                tither.TitheLogs = null;
            }
            try
            {
                var titherFile = Utilities.ExcelExporter.Export(Utilities.ExcelExporter.ConvertToDataTable<TitherPro.Domain.Contexts.Tither>(allTithers, "Tithers"), "Tithers");
                MessageBox.Show("Your file was exported to: " + System.IO.Path.GetFullPath(titherFile));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Export To Excel File Error: " + ex.Message); 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            gvTithers.DataSource = logic.GetAllTithers();
        }
    }
}

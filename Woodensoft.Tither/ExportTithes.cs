using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Woodensoft.Tither
{
    public partial class ExportTithes : Form
    {
        public ExportTithes()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message);
                return;
            } 
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(System.Configuration.ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            try
            {
                var reportDetails = logic.GetReportDetails(dtStart.Value, dpEnd.Value);
                gvReportDetails.DataSource = reportDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities.SessionValidator.ValidateSession(this, Woodensoft.TitherPro.Core.BusinessLogic.StateManager.Instance.GetUser());

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message);
                return;
            } 
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(System.Configuration.ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            try
            {
                var reportDetails = logic.GetReportDetails(dtStart.Value, dpEnd.Value);
                var fileName = Utilities.ExcelExporter.Export(Utilities.ExcelExporter.ConvertToDataTable<Woodensoft.TitherPro.Domain.Models.TitherReportDetails>(reportDetails, "TithingReport"), "TithingReport");
                MessageBox.Show("Your Excel File Was Created Here: " + System.IO.Path.GetFullPath(fileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Generate Excel File Error: " + ex.Message);
            }
        }   
    }
}

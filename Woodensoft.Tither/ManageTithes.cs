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
    public partial class ManageTithes : Form
    {
        public ManageTithes()
        {
            InitializeComponent();
        }

        private void gvTithes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            
            if (e.ColumnIndex == gvTithes.ColumnCount - 1)
            {
                logic.DeleteTithe((long)gvTithes.Rows[e.RowIndex].Cells[0].Value);
            }
            gvTithes.DataSource = logic.GetAllTitherLogs(dpStart.Value, dpEnd.Value);
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
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);

            var allTithes = logic.GetAllTitherLogs(dpStart.Value, dpEnd.Value);
            foreach (var tithe in allTithes)
            {
                tithe.Tither = null;
            }
            try
            {
                var fileName = Utilities.ExcelExporter.Export(Utilities.ExcelExporter.ConvertToDataTable<TitherPro.Domain.Contexts.TitheLog>(allTithes, "TitheLog"), "TithesLog");
                MessageBox.Show("Excel File Created At: " + System.IO.Path.GetFullPath(fileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Generate Excel File Error: " + ex.Message);
            }
        }

        private void ManageTithes_Load(object sender, EventArgs e)
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
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);

            var allTithers = logic.GetAllTithers();
            cboTithers.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var autoCompList = new AutoCompleteStringCollection();
            autoCompList.AddRange(allTithers.Select(x => x.LastName + ", " + x.FirstName + " " + x.MiddleName ?? "").ToArray());
            cboTithers.AutoCompleteCustomSource = autoCompList;
            cboTithers.DisplayMember = "Text";
            cboTithers.ValueMember = "Id";
            cboTithers.DataSource = allTithers.Select(x => new ViewModels.ListItem { Id = x.TitherId.ToString(), Text = x.LastName + ", " + x.FirstName + " " + x.MiddleName ?? "" }).ToList();
            dpEnd.Value = dpEnd.Value.AddDays(1);
        }
        private void BindData()
        {
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            try
            {
                gvTithes.DataSource = logic.GetReportDetails(dpStart.Value, dpEnd.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
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
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(ConfigurationManager.ConnectionStrings[Utilities.Constants.DbName].ConnectionString);
            decimal amount;
            if(!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Amount is not a valid number!");
                return;
            }
            int titherId;
            if(cboTithers.SelectedValue == null || !int.TryParse(cboTithers.SelectedValue.ToString(), out titherId))
            {
                MessageBox.Show("Error: No Tither Was Selected!");
                return;
            }
            try
            {
                logic.AddTitheLog(dpTitheDate.Value, amount, titherId);
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            BindData();
        }
    }
}

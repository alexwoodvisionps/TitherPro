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
    public partial class ViewStats : Form
    {
        public ViewStats()
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
            var logic = new Woodensoft.TitherPro.Core.BusinessLogic.BusinessLogic(System.Configuration.ConfigurationManager.ConnectionStrings[Woodensoft.Tither.Utilities.Constants.DbName].ConnectionString);
            try
            {
                var report = logic.GetReport(dpBegin.Value, dpEnd.Value);
                if (report == null)
                    return;
                lblTotalTithes.Text = report.TotalTithes.ToString();
                lblMostTithed.Text = report.MaxTithe.ToString();
                lblLeastTithed.Text = report.MinTithe.ToString();
                var sb = new StringBuilder();
                if (report.MinTither != null)
                {
                    var tither = report.MinTither;
                    {
                        sb.Append(tither.LastName + "," + tither.FirstName + " " + tither.MiddleName ?? "" + Environment.NewLine);
                    }
                }
                lblLeastTithers.Text = sb.ToString();
                sb.Clear();
                if (report.MaxTither != null)
                {
                    var tither = report.MaxTither;
                    {
                        sb.Append(tither.LastName + "," + tither.FirstName + " " + tither.MiddleName ?? "" + Environment.NewLine);
                    }
                }
                lblBigTithers.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message);
            }
        }

        private void ViewStats_Load(object sender, EventArgs e)
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
        }
    }
}

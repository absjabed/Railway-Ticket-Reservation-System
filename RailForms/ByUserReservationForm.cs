using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
namespace RailForms
{
    public partial class ByUserReservationForm : Form
    {
        public ByUserReservationForm()
        {
            InitializeComponent();
        }

        private void comboUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load("C:\\Users\\HOME\\Desktop\\Running\\Railway_Reservation_System\\RailForms\\ByUserReservation.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = comboUsername.Text;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["UserName"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void FillComboBox()
        {
            try
            {
                String queryTextU = "SELECT username FROM userinfo ORDER BY username ASC";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(queryTextU, con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("username", typeof(string));
                //dt.Columns.Add("contactname", typeof(string));
                dt.Load(reader);

                comboUsername.ValueMember = "username";
                comboUsername.DisplayMember = "username";
                comboUsername.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        private void ByUserReservationForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace RailForms
{
    public partial class CRviewer : Form
    {
        String PID;
        public CRviewer(String XZ)
        {
            InitializeComponent();
            PID = XZ;
        }

        private void CRviewer_Load(object sender, EventArgs e)
        {
            try
            {
                String PsngrId = PID;



                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load("C:\\Users\\HOME\\Desktop\\Running\\Railway_Reservation_System\\RailForms\\CRticket.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();


                crParameterDiscreteValue.Value = PsngrId;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["PassengerId"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

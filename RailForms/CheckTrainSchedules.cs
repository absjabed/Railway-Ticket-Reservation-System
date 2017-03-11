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

namespace RailForms
{
    public partial class CheckTrainSchedules : Form
    {
        public CheckTrainSchedules()
        {
            InitializeComponent();
        }

        private void comboBoxScheduleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxScheduleType.SelectedItem == (object)"Regular Trains Schedule")
            {
                RegularTrainsPanel.Visible = true;
                MailTrainsPanel.Visible = false;
                panelUpdated.Visible = false;
            }
            else if (comboBoxScheduleType.SelectedItem == (object)"Mail Trains Schedule")
            {
                MailTrainsPanel.Visible = true;
                RegularTrainsPanel.Visible = false;
                panelUpdated.Visible = false;

            }
            else if (comboBoxScheduleType.SelectedItem == (object)"Present Trains Schedule")
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    DataTable dbdataset = new DataTable();
                    BindingSource bSource = new BindingSource();
                    String queryText = "SELECT schedule_id as 'Schedule ID', Train_id as 'Train No', Train_Name as 'Train Name', Date, Dep_Hour, Dep_Min, DepFormat, [From], [To], Arv_Hour, Arv_Min, ArvFormat, Tseats as 'Total Seats' FROM Schedule_Tbl";
                    SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");

               using (SqlCommand cmd = new SqlCommand(queryText, con))
                        {
                                    con.Open();

                                    sda.SelectCommand = cmd;
                                    sda.Fill(dbdataset);
                                    bSource.DataSource = dbdataset;
                                    GridViewUpdated.DataSource = bSource;
                                    sda.Update(dbdataset);

    
                                    con.Close();
                            }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MailTrainsPanel.Visible = false;
                RegularTrainsPanel.Visible = false;
                panelUpdated.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RegularTrainsPanel.Visible = false;
            MailTrainsPanel.Visible = false;
            panelUpdated.Visible = false;

        }

        private void CheckTrainSchedules_Load(object sender, EventArgs e)
        {
            RegularTrainsPanel.Visible = false;
            MailTrainsPanel.Visible = false;
            panelUpdated.Visible = false;
        }

        private void btnOkRegular_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkMail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label155_Click(object sender, EventArgs e)
        {

        }

        private void label149_Click(object sender, EventArgs e)
        {

        }

        private void label141_Click(object sender, EventArgs e)
        {

        }

        private void label160_Click(object sender, EventArgs e)
        {

        }
    }
}

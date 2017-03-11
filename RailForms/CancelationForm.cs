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
    public partial class CancelationForm : Form
    {
        public CancelationForm()
        {
            InitializeComponent();
        }

        void FillComboBoxPNR()
        {
            try
            {
                String queryTextU = "SELECT PNR_no FROM ReservationTbl ORDER BY PNR_no ASC";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(queryTextU, con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("PNR_no", typeof(string));
                //dt.Columns.Add("contactname", typeof(string));
                dt.Load(reader);

                comboBoxCancelPNR.ValueMember = "PNR_no";
                comboBoxCancelPNR.DisplayMember = "PNR_no";
                comboBoxCancelPNR.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }



        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            try
            {
 
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String queryText = "DELETE FROM ReservationTbl WHERE PNR_no = '" + int.Parse(comboBoxCancelPNR.Text) + "'";
                using (SqlCommand cmd = new SqlCommand(queryText, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblConfirmation.Visible = true;
                    con.Close();
                }

                String query2 = "DELETE FROM PassengerInfo WHERE passenger_id = '" + lblPassengerId.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query2, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                String QueryU = "UPDATE Schedule_Tbl SET Tseats = Tseats+@xtraSeats  WHERE train_id = '" + lblCancelTrainNo.Text + "' AND Date = '" + lblCancelDate.Text + "'";
                using (SqlCommand command1 = new SqlCommand(QueryU, con))
                {
                    command1.Connection = con;
                    command1.Connection.Open();
                    command1.Parameters.Add(new SqlParameter("@xtraSeats", System.Data.SqlDbType.Int, 20, "Tseats"));
                    command1.Parameters["@xtraSeats"].Value = int.Parse(lblCancelNoOfSeats.Text);

                    command1.ExecuteNonQuery();

                    command1.Connection.Close();
                }
                lblConfirmation.Text = "Reservation Cancelled Successfully!!!";
                FillComboBoxPNR();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelationForm_Load(object sender, EventArgs e)
        {
            FillComboBoxPNR();
        }

        private void btnPNRinfo_Click(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT PNR_no, ReservationTbl.passenger_id,p_name, Schedule_Tbl.Train_id,Train_Name,ReservationTbl.class_id,Class,ReservationTbl.schedule_id,Schedule_Tbl.[Date],[From],[To],number_of_seats,tfare,seatNo, SeatNo2,Deperture, Arrival FROM ReservationTbl,PassengerInfo,Schedule_Tbl,ClassFareTbl WHERE ReservationTbl.passenger_id = PassengerInfo.passenger_id and ReservationTbl.schedule_id = Schedule_Tbl.schedule_id and ReservationTbl.class_id = ClassFareTbl.Class_id and PNR_no = '"+int.Parse(comboBoxCancelPNR.Text)+"'";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");

                using (SqlCommand cmd = new SqlCommand(queryText, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                    //BindingSource bsItems = new BindingSource();
                    DataSet dsStnid = new DataSet("ItemsSet");
                    sqladp.Fill(dsStnid);
                    foreach (DataRow drItems in dsStnid.Tables[0].Rows)
                    {
                        lblCancelPNRno.Text = drItems["PNR_no"].ToString();
                        lblPassengerId.Text = drItems["passenger_id"].ToString();
                        lblPassengerName.Text = drItems["p_name"].ToString();
                        lblCancelTrainNo.Text = drItems["Train_id"].ToString();
                        lblCancelTrainName.Text = drItems["Train_Name"].ToString();
                        lblCancelDate.Text = drItems["Date"].ToString();
                        lblCancelTime.Text = drItems["Deperture"].ToString();
                        lblCancelFrom.Text = drItems["From"].ToString();
                        lblCancelTo.Text = drItems["To"].ToString();
                        lblCancelClass.Text = drItems["Class"].ToString();
                        lblCancelNoOfSeats.Text = drItems["number_of_seats"].ToString();
                        lblCancelTotalFare.Text = drItems["tfare"].ToString();
                        //btnDelateTrain.Enabled = true;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCancelPNR_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCancelPNRno.Text = "Null";
            lblPassengerId.Text = "Null";
            lblPassengerName.Text = "Null";
            lblCancelTrainNo.Text = "Null";
            lblCancelTrainName.Text = "Null";
            lblCancelDate.Text = "Null";
            lblCancelTime.Text = "Null";
            lblCancelFrom.Text = "Null";
            lblCancelTo.Text = "Null";
            lblCancelClass.Text = "Null";
            lblCancelNoOfSeats.Text = "Null";
            lblCancelTotalFare.Text = "Null";
                        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

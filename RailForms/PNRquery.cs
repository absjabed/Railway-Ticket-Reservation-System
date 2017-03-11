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
    public partial class PNRquery : Form
    {
        public PNRquery()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

                comboPassengerInfoPNR.ValueMember = "PNR_no";
                comboPassengerInfoPNR.DisplayMember = "PNR_no";
                comboPassengerInfoPNR.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        private void PNRquery_Load(object sender, EventArgs e)
        {
            //Passenger Info
            lblPassengerPNRno.Text = "null";
            lblPassengerName.Text = "null";
            lblPassengerAddress.Text = "null";
            lblPassengerPhnNo.Text = "null";
            lblPassengerCity.Text = "null";
            lblPassengerGender.Text = "null";
            lblPassengerAge.Text = "null";
            lblPassengerOccupation.Text = "null";

            //TrainInfo
            lblTrainInfoPnrNo.Text = "null";
            lblTrainInfoTrainNo.Text = "null";
            lblTrainInfoTrainName.Text = "null";
            lblTrainInfoSource.Text = "null";
            lblTrainInfoDestination.Text = "null";
            lblTrainInfoTime.Text = "null";
            lblTrainInfoDate.Text = "null";
            lblTrainInfoClass.Text = "null";
            lblTrainInfoNumberOfSeats.Text = "null";
            lblTrainInfoSeatNo.Text = "null";
            lblTrainInfoTotalFare.Text = "null";         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboPassengerInfoPNR_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT PNR_no,p_name,p_address,phone_no,city,gender,age,occupation,Schedule_Tbl.Train_id,Train_Name,[From],[To],Deperture,Schedule_Tbl.[Date],Class,number_of_seats,seatNo, SeatNo2,tfare FROM ReservationTbl,PassengerInfo,Schedule_Tbl,ClassFareTbl WHERE ReservationTbl.passenger_id = PassengerInfo.passenger_id and ReservationTbl.schedule_id = Schedule_Tbl.schedule_id and ReservationTbl.class_id = ClassFareTbl.Class_id and PNR_no = '"+int.Parse(comboPassengerInfoPNR.Text)+"'";
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
                        //Passenger Info
                        lblPassengerPNRno.Text = drItems["PNR_no"].ToString();
                        lblPassengerName.Text = drItems["p_name"].ToString();
                        lblPassengerAddress.Text = drItems["p_address"].ToString();
                        lblPassengerPhnNo.Text = drItems["phone_no"].ToString();
                        lblPassengerCity.Text = drItems["city"].ToString();
                        lblPassengerGender.Text = drItems["gender"].ToString();
                        lblPassengerAge.Text = drItems["age"].ToString();
                        lblPassengerOccupation.Text = drItems["occupation"].ToString();

                        //TrainInfo Schedule_Tbl.,Train_Name,[From],[To],Deperture,Schedule_Tbl.[Date],Class,number_of_seats,seatNo, SeatNo2,tfare FROM ReservationTbl,PassengerInfo,Schedule_Tbl,ClassFareTbl WHERE ReservationTbl.passenger_id = PassengerInfo.passenger_id and ReservationTbl.schedule_id = Schedule_Tbl.schedule_id and ReservationTbl.class_id = ClassFareTbl.Class_id and PNR_no = ''";                    
                        lblTrainInfoPnrNo.Text = drItems["PNR_no"].ToString();
                        lblTrainInfoTrainNo.Text = drItems["Train_id"].ToString();
                        lblTrainInfoTrainName.Text = drItems["Train_Name"].ToString();
                        lblTrainInfoSource.Text = drItems["From"].ToString();
                        lblTrainInfoDestination.Text = drItems["To"].ToString();
                        lblTrainInfoTime.Text = drItems["Deperture"].ToString();
                        lblTrainInfoDate.Text = drItems["Date"].ToString();
                        lblTrainInfoClass.Text = drItems["Class"].ToString();
                        lblTrainInfoNumberOfSeats.Text = drItems["number_of_seats"].ToString();
                        lblTrainInfoSeatNo.Text = drItems["seatNo"].ToString()+" -> "+ drItems["SeatNo2"].ToString();
                        lblTrainInfoTotalFare.Text = drItems["tfare"].ToString();


                        //lblCancelPNRno.Text = 
                        //lblPassengerId.Text = drItems["passenger_id"].ToString();
                        //lblPassengerName.Text = 
                        //lblCancelTrainNo.Text = drItems["Train_id"].ToString();
                        //lblCancelTrainName.Text = drItems["Train_Name"].ToString();
                        //lblCancelDate.Text = drItems["Date"].ToString();
                        //lblCancelTime.Text = drItems["Deperture"].ToString();
                        //lblCancelFrom.Text = drItems["From"].ToString();
                        //lblCancelTo.Text = drItems["To"].ToString();
                        //lblCancelClass.Text = drItems["Class"].ToString();
                        //lblCancelNoOfSeats.Text = drItems["number_of_seats"].ToString();
                        //lblCancelTotalFare.Text = drItems["tfare"].ToString();
                        ////btnDelateTrain.Enabled = true;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void btnPnrOK_Click(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Passenger Info
            lblPassengerPNRno.Text = "null";
            lblPassengerName.Text = "null";
            lblPassengerAddress.Text = "null";
            lblPassengerPhnNo.Text = "null";
            lblPassengerCity.Text = "null";
            lblPassengerGender.Text = "null";
            lblPassengerAge.Text = "null";
            lblPassengerOccupation.Text = "null";

            //TrainInfo
            lblTrainInfoPnrNo.Text = "null";
            lblTrainInfoTrainNo.Text = "null";
            lblTrainInfoTrainName.Text = "null";
            lblTrainInfoSource.Text = "null";
            lblTrainInfoDestination.Text = "null";
            lblTrainInfoTime.Text = "null";
            lblTrainInfoDate.Text = "null";
            lblTrainInfoClass.Text = "null";
            lblTrainInfoNumberOfSeats.Text = "null";
            lblTrainInfoSeatNo.Text = "null";
            lblTrainInfoTotalFare.Text = "null";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillComboBoxPNR();
  
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}

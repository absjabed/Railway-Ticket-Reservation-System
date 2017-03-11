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
    public partial class Reservation : Form
    {
        String Dhr,By, Dmin, Ahr, Amin,Dformat, Aformat, SCid,gender;
        int Classid;

        public Reservation(String usr)
        {
            InitializeComponent();
            lblConfirmation.Visible = false;
            TrainInfoPanel.Visible = false;
            By = usr;
        }

        void FillComboBox(String Dt) {
            try
            {
                String queryTextU = "SELECT Train_Name FROM Schedule_Tbl WHERE Date = '"+Dt+ "'  ORDER BY Train_Name ASC";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(queryTextU, con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("Train_Name", typeof(string));
                //dt.Columns.Add("contactname", typeof(string));
                dt.Load(reader);

                comboBoxTrainName.ValueMember = "Train_Name";
                comboBoxTrainName.DisplayMember = "Train_Name";
                comboBoxTrainName.DataSource = dt;


                
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void fReservation_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }

        private void PassengerInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrainInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                String today = DateTime.Today.Date.ToShortDateString();
                int reserved = int.Parse(comboTtlSeats.Text);
                String tid = comboBoxTrainName.Text.Trim();
                String date = dateTimePickerR.Text.Trim();
                String Fseat = comboBoxBogi.Text + "-" + comboBoxSeatNo.Text;
                String Tseat = comboBoxBogi2.Text + "-" + comboBoxSeatNo2.Text;
                String DT = Dhr + ":" + Dmin + Dformat;
                String AT = Ahr + ":" + Amin + Aformat;
                String queryTextU = "INSERT INTO ReservationTbl(passenger_id, train_id, class_id, schedule_id, number_of_seats, seatNo, tfare, Deperture, Arrival, SeatNo2, Made_by,Date_Of_Reservation) Values('" + textBoxPassengerID.Text + "','" + textBoxTrainNo.Text + "','" + Classid + "','" + SCid + "','" + int.Parse(comboTtlSeats.Text) + "','" + Fseat + "','" + textBoxTotalFare.Text + "','" + DT + "','" + AT + "','" + Tseat + "','" + By + "','"+today+"')";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                
                using (SqlCommand cmd = new SqlCommand(queryTextU, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblConfirmation.Text = "Reservation Succeed!!!";
                    lblConfirmation.Visible = true;
                    btnPrint.Visible = true;
                    con.Close();
                }

                String Query = "UPDATE Schedule_Tbl SET Tseats = Tseats-@xtraSeats  WHERE train_id = '" + textBoxTrainNo.Text.Trim() + "' AND Date = '" + dateTimePickerR.Text.Trim() + "'";
                using (SqlCommand command1 = new SqlCommand(Query, con))
                {
                    command1.Connection = con;
                    command1.Connection.Open();
                    command1.Parameters.Add(new SqlParameter("@xtraSeats", System.Data.SqlDbType.Int, 20, "Tseats"));
                    command1.Parameters["@xtraSeats"].Value = int.Parse(comboTtlSeats.Text.Trim());

                    command1.ExecuteNonQuery();

                    command1.Connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerR_ValueChanged(object sender, EventArgs e)
        {
            String date;
            date = dateTimePickerR.Text;
            FillComboBox(date);
        }

        private void comboBoxTrainName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                String queryText = "SELECT Train_id,[To],schedule_id,Dep_Hour,Dep_Min,DepFormat,Arv_Hour,Arv_Min,ArvFormat FROM Schedule_Tbl WHERE Train_Name = '" + comboBoxTrainName.Text + "' AND Date = '"+dateTimePickerR.Text+"'";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");

                using (SqlCommand cmd = new SqlCommand(queryText, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                    //BindingSource bsItems = new BindingSource();
                    DataSet dsTrnid = new DataSet("ItemsSet");
                    sqladp.Fill(dsTrnid);
                    foreach (DataRow drItems in dsTrnid.Tables[0].Rows)
                    {
                        textBoxTrainNo.Text = drItems["Train_id"].ToString();
                        textDestination.Text = drItems["To"].ToString();
                        SCid = drItems["schedule_id"].ToString();
                        Dhr = drItems["Dep_Hour"].ToString();
                        Dmin = drItems["Dep_Min"].ToString();
                        Dformat = drItems["DepFormat"].ToString();
                        Ahr = drItems["Arv_Hour"].ToString();
                        Amin = drItems["Arv_Min"].ToString();
                        Aformat = drItems["ArvFormat"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxTotalFare_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTtlSeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seat = int.Parse(comboTtlSeats.Text);
            int fare, TotalFare;
            try
            {
                String queryText = "SELECT Fare,Class_id FROM ClassFareTbl WHERE Class = '"+comboBoxClass.Text+"' AND To_stn = '"+textDestination.Text+"'";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");

                using (SqlCommand cmd = new SqlCommand(queryText, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                    //BindingSource bsItems = new BindingSource();
                    DataSet dsTrnFare = new DataSet("ItemsSet");
                    sqladp.Fill(dsTrnFare);
                    foreach (DataRow drItems in dsTrnFare.Tables[0].Rows)
                    {
                        fare =int.Parse(drItems["Fare"].ToString());
                        Classid = int.Parse(drItems["Class_id"].ToString());
                        TotalFare = seat * fare;
                        textBoxTotalFare.Text = TotalFare.ToString();
                    }
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                String queryTextU = "INSERT INTO PassengerInfo(passenger_id, p_name, p_address, city, phone_no, gender, age, occupation) Values('" + textBoxPassengerID.Text + "','" + textBoxPName.Text + "','" + textBoxFullAddress.Text + "','" + textBoxCity.Text + "','" + textPhn_No.Text + "','" + gender + "','" + textBoxAge.Text + "','" + textBoxOccupation.Text + "')";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");

                using (SqlCommand cmd = new SqlCommand(queryTextU, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

            TrainInfoPanel.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dateTimePickerR.Text = "";
            textDestination.Text = "";
            comboBoxTrainName.Text = "";
            textBoxTrainNo.Text = "";
            comboBoxClass.Text = "";
            comboTtlSeats.Text = "";
            comboBoxBogi.Text = "";
            comboBoxBogi2.Text = "";
            comboBoxSeatNo2.Text = "";
            comboBoxSeatNo.Text = "";
            textBoxTotalFare.Text = "";
        }

        private void comboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            TrainInfoPanel.Visible = false;
            textBoxPassengerID.Text = "";
            textBoxPName.Text = "";
            textBoxFullAddress.Text = "";
            textPhn_No.Text = "";
            textBoxCity.Text = "";
            textBoxAge.Text = "";
            textBoxOccupation.Text = "";
        }

        private void radioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void textDestination_TextChanged(object sender, EventArgs e)
        {
            String dst = textDestination.Text.Trim();
            FillClassComboBox(dst);

        }

        void FillClassComboBox(String dst) {
            try
            {
                String queryTextU = "SELECT Class FROM ClassFareTbl WHERE To_stn = '"+dst+"'";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(queryTextU, con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("Class", typeof(string));
                //dt.Columns.Add("contactname", typeof(string));
                dt.Load(reader);

                comboBoxClass.ValueMember = "Class";
                comboBoxClass.DisplayMember = "Class";
                comboBoxClass.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Pages.CRtickets = new CRviewer(textBoxPassengerID.Text);
            Pages.CRtickets.Show();

        }
    }

}

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
    public partial class SeeAllReservations : Form
    {
        public SeeAllReservations()
        {
            InitializeComponent();
        }

        private void fSeeReservations_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT PNR_no as 'PNR NO', ReservationTbl.passenger_id as 'Passenger ID',p_name as 'Passenger Name', Schedule_Tbl.Train_id as 'Train No',Train_Name as 'Train Name',ReservationTbl.class_id as 'Class ID',Class as 'Class Name',ReservationTbl.schedule_id as 'Schedule ID',Schedule_Tbl.[Date] as 'Deperture Date',[From],[To],number_of_seats as 'Total Seats',tfare as 'Total Fare',seatNo as 'Seat No>', SeatNo2 as '<Seat No',Deperture as 'Deperture Time', Arrival as 'Arrival Time',Made_by,Date_Of_Reservation FROM ReservationTbl,PassengerInfo,Schedule_Tbl,ClassFareTbl WHERE ReservationTbl.passenger_id = PassengerInfo.passenger_id and ReservationTbl.schedule_id = Schedule_Tbl.schedule_id and ReservationTbl.class_id = ClassFareTbl.Class_id  ORDER BY Date";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(queryText, con);

                SqlDataAdapter Sqladap = new SqlDataAdapter();
                Sqladap.SelectCommand = cmd;
                DataTable datatbl = new DataTable();
                Sqladap.Fill(datatbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = datatbl;
                GridViewSeeReservations.DataSource = bSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

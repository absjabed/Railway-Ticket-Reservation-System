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
    public partial class AdminPanel : Form
    {
        private int hr, min, sec;
        String snd;
        public AdminPanel(String User)
        {
            InitializeComponent();
            snd = User;

            try
            {
                String queryText = "SELECT Full_name FROM PersonnelInfo WHERE Username = '" + User + "'";
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
                        lblAdmin.Text = drItems["Full_name"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            hr = DateTime.UtcNow.Hour;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.reservation = new Reservation(snd);
                Pages.reservation.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.abt = new About();
                Pages.abt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            try
            {
                Pages.adminLgin = new AdminLogin();
                Pages.adminLgin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seeAllReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.allReservation = new SeeAllReservations();
                Pages.allReservation.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.profile = new Profile(snd.Trim());
                Pages.profile.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.chngPass = new ChangePassword(snd.Trim());
                Pages.chngPass.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.updateProfile = new UpdateProfile(snd.Trim());
                Pages.updateProfile.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewSysUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.viewUsrs = new ViewUsers();
                Pages.viewUsrs.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.addNwUsr = new AddNewUser();
                Pages.addNwUsr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.deleteUsr = new DeleteUser(snd.Trim());
                Pages.deleteUsr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkTrainSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.chkTrainSch = new CheckTrainSchedules();
                Pages.chkTrainSch.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.addSch = new Add_Update_Delete_Schedule();
                Pages.addSch.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.canclnForm = new CancelationForm();
                Pages.canclnForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pNRQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.pnrQ = new PNRquery();
                Pages.pnrQ.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fareListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.fareList = new FullFareList();
                Pages.fareList.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.addNwTrain = new AddNewTrain();
                Pages.addNwTrain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.remvTrain = new RemoveTrain();
                Pages.remvTrain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchTrainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.srcTrain = new SearchTrain();
                Pages.srcTrain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hr = DateTime.UtcNow.Hour;
            hr = hr + 6;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;

            if (hr > 12)
                hr -=  12;

            if (sec % 2 == 0)
            {
                time.Text = hr + " : " + min + " : " + sec;
            }
            else {
                time.Text = hr + "   " + min + "   " + sec;
            }

        }

        private void ticketSellsBetweenDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pages.ReportBtu = new CRreservationBtu();
            Pages.ReportBtu.Show();
        }

        private void byUserReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pages.byusr = new ByUserReservationForm();
            Pages.byusr.Show();
        }
    }
}

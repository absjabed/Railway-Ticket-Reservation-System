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
    public partial class AddNewTrain : Form
    {
        public AddNewTrain()
        {
            InitializeComponent();
            panelSeats.Visible = false;
        }

        void FillComboBox()
        {
            try
            {
                String queryTextU = "SELECT station_name FROM StationTbl ORDER BY station_name ASC";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(queryTextU, con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("station_name", typeof(string));
                //dt.Columns.Add("contactname", typeof(string));
                dt.Load(reader);

                comboBoxDestination.ValueMember = "station_name";
                comboBoxDestination.DisplayMember = "station_name";
                comboBoxDestination.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textOffDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            textTrainNo.Text = "T";
            textTrainName.Text = "";
            comboBoxTrainType.Text = "";
            textTotalSeats.Text = "";
            comboBoxDestination.Text = "";
            textACbarth.Text = "0";
            textACseat.Text = "0";
            textFCbarth.Text = "0";
            textFCseat.Text = "0";
            textShovonC.Text = "0";
            textShovon.Text = "0";
            textShulov.Text = "0";
            textTotalSeats.Text = "";
            textStationId.Text = "";
            panelSeats.Visible = false;
            label8.Visible = false;
            lblConfirmation.Visible = false;
        }

        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            lblAfter.Visible = true;
            panelSeats.Visible = true;
            label8.Visible = true;

            try
            {
                String queryText = "SELECT station_id FROM StationTbl WHERE station_name = '"+comboBoxDestination.Text+"'";
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
                        textStationId.Text = drItems["station_id"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNewTrain_Load(object sender, EventArgs e)
        {
            FillComboBox();
            label6.Visible = false;
            label8.Visible = false;
            panelSeats.Visible = false;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textShulov_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            try {
                String trainid = textTrainNo.Text.Trim();
                String trainname = textTrainName.Text.Trim();
                String traintype = comboBoxTrainType.Text.Trim();
                String ttlSts = textTotalSeats.Text.Trim();
                String origin = textSourceStn.Text.Trim();
                String dstStnId = textStationId.Text.Trim();
                String destn = comboBoxDestination.Text.Trim();
                String ACb = textACbarth.Text;
                String ACs = textACseat.Text;
                String FCb = textFCbarth.Text;
                String FCs = textFCseat.Text;
                String ShoC = textShovonC.Text;
                String Sho = textShovon.Text;
                String Shu = textShulov.Text;
                int totalSeats = int.Parse(ttlSts);
                int dstStn_id = int.Parse(dstStnId);
                int iACb = int.Parse(ACb);
                int iACs = int.Parse(ACs);
                int iFCb = int.Parse(FCb);
                int iFCs = int.Parse(FCs);
                int iShoC = int.Parse(ShoC);
                int iSho = int.Parse(Sho);
                int iShu = int.Parse(Shu);


                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String quary = "insert into TrainTbl(train_id,train_name,train_type,AC_Barth,AC_Seat,FirstClass_Barth,FirstClass_Seat,Shovon_Chair,Shovon,Shulov,total_seats,origin_stn,Stn_id,dst_stn) values('"+trainid+"','"+trainname+"','"+traintype+"','"+iACb+"','"+iACs+"','"+iFCb+"','"+FCs+"','"+iShoC+"','"+iSho+"','"+iShu+"','"+totalSeats+"','"+origin+"','"+dstStn_id+"','"+destn+"') ";
                using (SqlCommand command = new SqlCommand(quary, con))
                {
                    con.Open();

                    command.ExecuteNonQuery();
                    lblConfirmation.Text = "Train Successfully Added!!!!";
                    lblConfirmation.Visible = true;
                    con.Close();
                }
                


            }catch(Exception ee){
                MessageBox.Show(ee.Message);
                MessageBox.Show(ee.StackTrace);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int Total = 0;
                String ACb = textACbarth.Text;
                String ACs = textACseat.Text;
                String FCb = textFCbarth.Text;
                String FCs = textFCseat.Text;
                String ShoC = textShovonC.Text;
                String Sho = textShovon.Text;
                String Shu = textShulov.Text;
                Total = int.Parse(ACb) + int.Parse(ACs) + int.Parse(FCb) + int.Parse(FCs) + int.Parse(ShoC) + int.Parse(Sho) + int.Parse(Shu);
                textTotalSeats.Text = Total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void textStationId_TextChanged(object sender, EventArgs e)
        {
                   }
    }
}

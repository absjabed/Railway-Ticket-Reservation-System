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
    public partial class RemoveTrain : Form
    {
        public RemoveTrain()
        {
            InitializeComponent();
        }

        void FillComboBox()
        {
            try
            {
                String queryTextU = "SELECT train_name FROM TrainTbl ORDER BY train_name ASC";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(queryTextU, con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("train_name", typeof(string));
                //dt.Columns.Add("contactname", typeof(string));
                dt.Load(reader);

                comboTrainName.ValueMember = "train_name";
                comboTrainName.DisplayMember = "train_name";
                comboTrainName.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        private void textDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTrainNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveTrain_Load(object sender, EventArgs e)
        {
            btnDelateTrain.Enabled = false;
            comboTrainName.Text = "";
            FillComboBox();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboTrainNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT train_id,train_type,total_seats,origin_stn,dst_stn FROM TrainTbl WHERE train_name = '" + comboTrainName.Text + "'";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");

                using (SqlCommand cmd = new SqlCommand(queryText, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                    DataSet dsStnid = new DataSet("ItemsSet");
                    sqladp.Fill(dsStnid);
                    foreach (DataRow drItems in dsStnid.Tables[0].Rows)
                    {
                        lblTno.Text = drItems["train_id"].ToString();
                        lblTname.Text = comboTrainName.Text;
                        lblTtype.Text = drItems["train_type"].ToString();
                        lblTseats.Text = drItems["total_seats"].ToString();
                        lblTOrigin.Text = drItems["origin_stn"].ToString();
                        lblTdestination.Text = drItems["dst_stn"].ToString();
                        btnDelateTrain.Enabled = true;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelateTrain_Click(object sender, EventArgs e)
        {
            try
            {
                String queryText = "DELETE FROM TrainTbl WHERE train_name = '" + comboTrainName.Text + "'";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");

                using (SqlCommand cmd = new SqlCommand(queryText, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblConfirmation.Text = "Train deleted Successfully!!!";
                    lblConfirmation.Visible = true;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnDelateTrain.Enabled = false;
            lblConfirmation.Visible = false;
            lblTno.Text = "Null";
            lblTname.Text = "Null";
            lblTtype.Text = "Null";
            lblTseats.Text = "Null";
            lblTOrigin.Text = "Null";
            lblTdestination.Text = "Null";
            FillComboBox();
        }

        private void lblTrainInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblTrainNo_Click(object sender, EventArgs e)
        {

        }
    }
}

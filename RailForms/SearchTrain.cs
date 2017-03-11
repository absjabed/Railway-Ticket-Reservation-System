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
    public partial class SearchTrain : Form
    {
        public SearchTrain()
        {
            InitializeComponent();
        }

        private void lblSchedule_Click(object sender, EventArgs e)
        {
            lblTno.Text = "Null";
            lblTname.Text = "Null";
            lblTtype.Text = "Null";
            lblAvailableSeats.Text = "Null";
            lblTOrigin.Text = "Null";
            lblTdestination.Text = "Null";
            comboBoxTrainName.Visible = true;
            comboBoxTrainNo.Visible = false;
            FillComboBoxTrainName();
        }

        private void SearchTrain_Load(object sender, EventArgs e)
        {
            comboBoxTrainName.Visible = false;
            comboBoxTrainNo.Visible = false;
        }

        void FillComboBoxTrainName()
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

                comboBoxTrainName.ValueMember = "train_name";
                comboBoxTrainName.DisplayMember = "train_name";
                comboBoxTrainName.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        void FillComboBoxTrainId()
        {
            try
            {
                String queryTextU = "SELECT train_id FROM TrainTbl ORDER BY train_id ASC";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(queryTextU, con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("train_id", typeof(string));
                //dt.Columns.Add("contactname", typeof(string));
                dt.Load(reader);

                comboBoxTrainNo.ValueMember = "train_id";
                comboBoxTrainNo.DisplayMember = "train_id";
                comboBoxTrainNo.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        //private void lblClass_Click(object sender, EventArgs e)
        //{
        //    comboBoxTrainName.Visible = true;
        //    comboBoxTrainNo.Visible = false;
        //}

        private void lblTID_Click(object sender, EventArgs e)
        {
            lblTno.Text = "Null";
            lblTname.Text = "Null";
            lblTtype.Text = "Null";
            lblAvailableSeats.Text = "Null";
            lblTOrigin.Text = "Null";
            lblTdestination.Text = "Null";
            comboBoxTrainName.Visible = false;
            comboBoxTrainNo.Visible = true;
            FillComboBoxTrainId();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTrainName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT train_id,train_type,total_seats,origin_stn,dst_stn FROM TrainTbl WHERE train_name = '" + comboBoxTrainName.Text + "'";
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
                        lblTno.Text = drItems["train_id"].ToString();
                        lblTname.Text = comboBoxTrainName.Text;
                        lblTtype.Text = drItems["train_type"].ToString();
                        lblAvailableSeats.Text = drItems["total_seats"].ToString();
                        lblTOrigin.Text = drItems["origin_stn"].ToString();
                        lblTdestination.Text = drItems["dst_stn"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTrainNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT train_name,train_type,total_seats,origin_stn,dst_stn FROM TrainTbl WHERE train_id = '" + comboBoxTrainNo.Text + "'";
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
                        lblTno.Text = comboBoxTrainNo.Text;
                        lblTname.Text = drItems["train_name"].ToString();
                        lblTtype.Text = drItems["train_type"].ToString();
                        lblAvailableSeats.Text = drItems["total_seats"].ToString();
                        lblTOrigin.Text = drItems["origin_stn"].ToString();
                        lblTdestination.Text = drItems["dst_stn"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

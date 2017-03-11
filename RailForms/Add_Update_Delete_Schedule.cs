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
    public partial class Add_Update_Delete_Schedule : Form
    {
        int seats;
        public Add_Update_Delete_Schedule()
        {
            InitializeComponent();
            txtDhr.Text = "0";
            txtDmin.Text = "0";
            txtOrigin.Text = "Chittagong";

            textDhr.Text = "0";
            textDmin.Text = "0";
            textOrigin.Text = "Chittagong";

            panelAddSchedule.Visible = false;
            panelDeleteSchedule.Visible = false;
            btnAddSchedule.Visible = false;
            btnDeleteSchedule.Visible = false;
            btnUpdate.Visible = false;
            GridviewSchedule.Visible = false;

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=ABSJABED;Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String quary = "INSERT INTO  Schedule_Tbl ( schedule_id, Train_id, Train_Name, Date, Dep_Hour, Dep_Min, DepFormat, [From], [To], Arv_Hour, Arv_Min, ArvFormat,Tseats) VALUES ('" + txtScheduleId.Text + "','" + txtTrainNo.Text + "','" + comboTrainName.Text + "','" + dateTimeScheduleDate.Text + "','" + int.Parse(txtDhr.Text) + "','" + int.Parse(txtDmin.Text) + "','" + txtDformat.Text + "','" + txtOrigin.Text + "','" + comboAddTo.Text + "','" + int.Parse(txtAhr.Text) + "','" + int.Parse(txtAmin.Text) + "','" + txtAformat.Text + "','"+seats+"')";
                using (SqlCommand command = new SqlCommand(quary, con))
                {
                    con.Open();

                    command.ExecuteNonQuery();
                    lblConfirmation.Text = "Schedule Successfully Added!!!!";
                    lblConfirmation.Visible = true;
                    con.Close();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void GridviewSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.GridviewSchedule.Rows[e.RowIndex];

                    //dateTimeSchedule.Text = row.Cells["Date"].Value.ToString();
                    
                    textScheduleId.Text = row.Cells["schedule_id"].Value.ToString();
                    textTrainNo.Text = row.Cells["Train_id"].Value.ToString();
                    textTrainName.Text = row.Cells["Train_Name"].Value.ToString();
                    textScheduleDate.Text = row.Cells["Date"].Value.ToString();
                    textDhr.Text = row.Cells["Dep_Hour"].Value.ToString();
                    textDmin.Text = row.Cells["Dep_Min"].Value.ToString();
                    textDformat.Text = row.Cells["DepFormat"].Value.ToString();
                    textOrigin.Text = row.Cells["From"].Value.ToString();
                    textDeleteTo.Text = row.Cells["To"].Value.ToString();
                    textAhr.Text = row.Cells["Arv_Hour"].Value.ToString();
                    textAmin.Text = row.Cells["Arv_Min"].Value.ToString();
                    textAformat.Text = row.Cells["ArvFormat"].Value.ToString();
                    
                }
            }
            catch (Exception em) {
                MessageBox.Show(em.Message);
                MessageBox.Show(em.StackTrace);
            }
        }

        void FillComboBoxToStation()
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

                comboAddTo.ValueMember = "station_name";
                comboAddTo.DisplayMember = "station_name";
                comboAddTo.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
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


        private void Add_New_Schedule_Load(object sender, EventArgs e)
        {
            FillComboBoxTrainName();
            FillComboBoxToStation();
            try
            {
                String queryText = "SELECT * FROM Schedule_Tbl";
                //SqlConnection con = new SqlConnection("Data Source=ABSJABED;Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(queryText, con);

                SqlDataAdapter Sqladap = new SqlDataAdapter();
                Sqladap.SelectCommand = cmd;
                DataTable datatbl = new DataTable();
                Sqladap.Fill(datatbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = datatbl;
                GridviewSchedule.DataSource = bSource;
                                
            }
            catch (Exception ee)
            {
                MessageBox.Show( ee.StackTrace, ee.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            if (comboBox1.SelectedItem == (object)"Add New Schedule")
            {
                lblConfirmation.Visible = false;
                //Clearing text fields
                txtScheduleId.Text = "";
                txtTrainNo.Text = "";
                comboTrainName.Text = "";
                dateTimeScheduleDate.Text = "";
                txtDhr.Text = "";
                txtDmin.Text = "";
                txtDformat.Text = "";
                txtOrigin.Text = "";
                comboAddTo.Text = "";
                txtAhr.Text = "";
                txtAmin.Text = "";
                txtAformat.Text = "";

                panelAddSchedule.Visible = true;
                panelDeleteSchedule.Visible = false;
                GridviewSchedule.Visible = false;
                btnAddSchedule.Visible = true;
                btnDeleteSchedule.Visible = false;
                btnUpdate.Visible = false;
            }
            else if (comboBox1.SelectedItem == (object)"Update Schedule")
            {
                lblConfirmation.Visible = false;
                try{
                    String queryText = "SELECT * FROM Schedule_Tbl";
                    SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(queryText, con);

                    SqlDataAdapter Sqladap = new SqlDataAdapter();
                    Sqladap.SelectCommand = cmd;
                    DataTable datatbl = new DataTable();
                    Sqladap.Fill(datatbl);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = datatbl;
                    GridviewSchedule.DataSource = bSource;
                }catch(Exception ee){
                    MessageBox.Show(ee.Message);}
                //Clearing text fields
                textScheduleId.Text = "";
                textTrainNo.Text = "";
                textTrainName.Text = "";
                textScheduleDate.Text = "";
                textDhr.Text = "";
                textDmin.Text = "";
                textDformat.Text = "";
                textOrigin.Text = "";
                textDeleteTo.Text = "";
                textAhr.Text = "";
                textAmin.Text = "";
                textAformat.Text = "";

                textScheduleId.ReadOnly = true;
                textTrainNo.ReadOnly = true;
                textTrainName.ReadOnly = true;
                textScheduleDate.ReadOnly = false;
                textDhr.ReadOnly = false;
                textDmin.ReadOnly = false;
                textDformat.ReadOnly = false;
                textOrigin.ReadOnly = true;
                textDeleteTo.ReadOnly = true;
                textAhr.ReadOnly = false;
                textAmin.ReadOnly = false;
                textAformat.ReadOnly = false;

                label35.Text = "UPDATE SCHEDULE";
                panelAddSchedule.Visible = false;
                GridviewSchedule.Visible = true;
                btnAddSchedule.Visible = false;
                btnDeleteSchedule.Visible = false;
                btnUpdate.Visible = true;
                panelDeleteSchedule.Visible = true;

            }
            else if (comboBox1.SelectedItem == (object)"Delete Schedule")
            {
                lblConfirmation.Visible = false;
                try
                {
                    String queryText = "SELECT * FROM Schedule_Tbl";
                    SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(queryText, con);

                    SqlDataAdapter Sqladap = new SqlDataAdapter();
                    Sqladap.SelectCommand = cmd;
                    DataTable datatbl = new DataTable();
                    Sqladap.Fill(datatbl);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = datatbl;
                    GridviewSchedule.DataSource = bSource;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

                //Clearing text fields
                textScheduleId.Text = "";
                textTrainNo.Text = "";
                textTrainName.Text = "";
                textScheduleDate.Text = "";
                textDhr.Text = "";
                textDmin.Text = "";
                textDformat.Text = "";
                textOrigin.Text = "";
                textDeleteTo.Text = "";
                textAhr.Text = "";
                textAmin.Text = "";
                textAformat.Text = "";
                //set text fields read-only
                textScheduleId.ReadOnly = false;
                textTrainNo.ReadOnly = true;
                textTrainName.ReadOnly = true;
                textScheduleDate.ReadOnly = true;
                textDhr.ReadOnly = true;
                textDmin.ReadOnly = true;
                textDformat.ReadOnly = true;
                textOrigin.ReadOnly = true;
                textDeleteTo.ReadOnly = true;
                textAhr.ReadOnly = true;
                textAmin.ReadOnly = true;
                textAformat.ReadOnly = true;

                label35.Text = "DELETE SCHEDULE";
                panelAddSchedule.Visible = false;
                panelDeleteSchedule.Visible = true;
                GridviewSchedule.Visible = true;
                btnAddSchedule.Visible = false;
                btnDeleteSchedule.Visible = true;
                btnUpdate.Visible = false;
            
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String quary = "DELETE FROM Schedule_Tbl WHERE schedule_id = '" + textScheduleId.Text.Trim() + "'";
                using (SqlCommand command = new SqlCommand(quary, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    lblConfirmation.Text = "Schedule Successfully Erased!!!!";
                    lblConfirmation.Visible = true;
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String quary = "INSERT INTO  Schedule_Tbl ( schedule_id, Train_id, Train_Name, Date, Dep_Hour, Dep_Min, DepFormat, [From], [To], Arv_Hour, Arv_Min, ArvFormat) VALUES ('" + textScheduleId.Text + "','" + textTrainNo.Text + "','" + textTrainName.Text + "','" + textScheduleDate.Text + "','" + int.Parse(textDhr.Text) + "','" + int.Parse(textDmin.Text) + "','" + textDformat.Text + "','" + textOrigin.Text + "','" + textDeleteTo.Text + "','" + int.Parse(textAhr.Text) + "','" + int.Parse(textAmin.Text) + "','" + textAformat.Text + "')";
                using (SqlCommand command = new SqlCommand(quary, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    lblConfirmation.Text = "Schedule Updated Successfully!!!!";
                    lblConfirmation.Visible = true;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

            try
            {
                String queryText = "SELECT * FROM Schedule_Tbl";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(queryText, con);

                SqlDataAdapter Sqladap = new SqlDataAdapter();
                Sqladap.SelectCommand = cmd;
                DataTable datatbl = new DataTable();
                Sqladap.Fill(datatbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = datatbl;
                GridviewSchedule.DataSource = bSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTrainName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Delete & Updating panel
            textScheduleId.Text = "";
            textTrainNo.Text = "";
            textTrainName.Text = "";
            textScheduleDate.Text = "";
            textDhr.Text = "0";
            textDmin.Text = "0";
            textDformat.Text = "";
            textOrigin.Text = "Chittagong";
            textDeleteTo.Text = "";
            textAhr.Text = "";
            textAmin.Text = "";
            textAformat.Text = "";
            
            //Add panel
            txtScheduleId.Text = "";
            txtTrainNo.Text = "";
            comboTrainName.Text = "";
            dateTimeScheduleDate.Text = "";
            txtDhr.Text = "0";
            txtDmin.Text = "0";
            txtDformat.Text = "";
            txtOrigin.Text = "Chittagong";
            comboAddTo.Text = "";
            txtAhr.Text = "";
            txtAmin.Text = "";
            txtAformat.Text = "";

            lblConfirmation.Visible = false;

            panelAddSchedule.Visible = false;
            panelDeleteSchedule.Visible = false;
            btnAddSchedule.Visible = false;
            btnDeleteSchedule.Visible = false;
            btnUpdate.Visible = false;
            GridviewSchedule.Visible = false;
        }

        private void comboTrainName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String quary = "DELETE FROM Schedule_Tbl WHERE schedule_id = '" + textScheduleId.Text.Trim() +"'";
                String quary2 = "DELETE FROM ReservationTbl WHERE schedule_id = '"+textScheduleId.Text.Trim()+"'";
                using (SqlCommand command = new SqlCommand(quary, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    lblConfirmation.Text = "Schedule Successfully Erased!!!!";
                    lblConfirmation.Visible = true;
                    con.Close();
                }
                using (SqlCommand command2 = new SqlCommand(quary2, con)) {
                    con.Open();
                    command2.ExecuteNonQuery();
                    con.Close();
                }

                String queryText = "SELECT * FROM Schedule_Tbl";
                SqlCommand cmd = new SqlCommand(queryText, con);

                SqlDataAdapter Sqladap = new SqlDataAdapter();
                Sqladap.SelectCommand = cmd;
                DataTable datatbl = new DataTable();
                Sqladap.Fill(datatbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = datatbl;
                GridviewSchedule.DataSource = bSource;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        

        private void comboTrainName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            try
            {
                String queryText = "SELECT train_id,total_seats FROM TrainTbl WHERE train_name = '" + comboTrainName.Text + "'";
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
                        txtTrainNo.Text = drItems["train_id"].ToString();
                        seats = int.Parse(drItems["total_seats"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAddSchedule_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}

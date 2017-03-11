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
    public partial class DeleteUser : Form
    {
        String own;
        public DeleteUser(String snd)
        {
            InitializeComponent();
            own = snd;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboUserName.Text.Equals(own)) {
                MessageBox.Show("Error!!!\nCurrent user can not be deleted.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                    String quary = "DELETE FROM userinfo WHERE username = '" + comboUserName.Text.Trim() + "'";
                    String quary2 = "DELETE FROM PersonnelInfo WHERE Username = '" + comboUserName.Text.Trim() + "'";
                    using (SqlCommand command = new SqlCommand(quary, con))
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    using (SqlCommand command2 = new SqlCommand(quary2, con))
                    {
                        con.Open();
                        command2.ExecuteNonQuery();
                        lblConfirmation.Text = "User Successfully Erased!!!!";
                        lblConfirmation.Visible = true;
                        con.Close();
                    }
                    checkConfirm.Checked = false;
                    FillComboBox();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FillComboBox()
        {
            try
            {
                String queryTextU = "SELECT username FROM userinfo ORDER BY username ASC";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(queryTextU, con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("username", typeof(string));
                //dt.Columns.Add("contactname", typeof(string));
                dt.Load(reader);

                comboUserName.ValueMember = "username";
                comboUserName.DisplayMember = "username";
                comboUserName.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        private void fDeleteUser_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            FillComboBox();
        }

        private void checkConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConfirm.Checked)
            {
                btnDelete.Enabled = true;
            }
            else {
                btnDelete.Enabled = false;
            }
        }

        private void comboUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

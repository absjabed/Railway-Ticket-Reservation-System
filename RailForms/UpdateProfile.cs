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
    public partial class UpdateProfile : Form
    {
        String usnd;
        public UpdateProfile(String snd)
        {
            InitializeComponent();
            lblConfirmation.Visible = false;
            usnd = snd;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT Full_name, User_Address, phone_no, gender, date_joined, duty_shift, salary FROM PersonnelInfo WHERE Username = '" + usnd.Trim() + "'";
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
                        textBoxFullName.Text = drItems["Full_name"].ToString();
                        textBoxAddress.Text = drItems["User_Address"].ToString();
                        textBoxPhoneNo.Text = drItems["phone_no"].ToString();
                        textBoxGender.Text = drItems["gender"].ToString();
                        textBoxJoinDate.Text = drItems["date_joined"].ToString();
                        textBoxDutyShift.Text = drItems["duty_shift"].ToString();
                        textBoxSalary.Text = drItems["salary"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String query2 = "UPDATE PersonnelInfo SET Full_name='" + textBoxFullName.Text + "',User_Address='" + textBoxAddress.Text + "',phone_no='" + textBoxPhoneNo.Text + "',gender ='" + textBoxGender.Text + "' WHERE Username='" + usnd.Trim() + "'";
                using (SqlCommand cmd = new SqlCommand(query2, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblConfirmation.Text = "Profile Updated!!!!!";
                    lblConfirmation.Visible = true;
                    con.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}

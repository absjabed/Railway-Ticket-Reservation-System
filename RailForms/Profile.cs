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
    public partial class Profile : Form
    {
        String prof;
        public Profile(String snd)
        {
            InitializeComponent();
            prof = snd;       
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           try{
                String queryText = "SELECT userType,Full_name, User_Address, phone_no, gender, date_joined, duty_shift, salary FROM PersonnelInfo WHERE Username = '"+prof.Trim()+"'";
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
                        lblUserType.Text = drItems["userType"].ToString();
                        lblFullName.Text = drItems["Full_name"].ToString();
                        lblAddress.Text = drItems["User_Address"].ToString();
                        lblPhoneNo.Text = drItems["phone_no"].ToString();
                        lblGender.Text = drItems["gender"].ToString();
                        lblDateJoined.Text = drItems["date_joined"].ToString();
                        lblDutyShift.Text = drItems["duty_shift"].ToString();
                        lblSalary.Text = drItems["salary"].ToString();
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

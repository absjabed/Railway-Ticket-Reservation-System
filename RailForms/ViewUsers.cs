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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT userId as 'User ID',userinfo.username as 'Username',Full_name as 'Full name',gender as 'Gender',User_Address as 'Address',phone_no as 'Phone No',date_joined as 'Working Since',userType as 'User Status',duty_shift as 'Duty Shift' FROM userinfo,PersonnelInfo WHERE userId = ESID";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(queryText, con);

                SqlDataAdapter Sqladap = new SqlDataAdapter();
                Sqladap.SelectCommand = cmd;
                DataTable datatbl = new DataTable();
                Sqladap.Fill(datatbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = datatbl;
                GridViewUsers.DataSource = bSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}

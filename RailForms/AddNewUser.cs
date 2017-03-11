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
    public partial class AddNewUser : Form
    {
        int esid;
        String utyp,gender;
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAddNewUser_Load(object sender, EventArgs e)
        {
            textUsrTyp.Text = "";
            panel2.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboUserType.SelectedText == "System_Admin")
            //{
            //    utyp = "_admin";
            //}
            //else if (comboUserType.SelectedText == "System_User")
            //{
            //    utyp = "_user";
            //}
            //else {
            //    return;
            //}
        }

        private void addusr_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String quary = "INSERT INTO userinfo(username,[password]) VALUES ('"+textBoxUserName.Text.Trim()+""+utyp+"','"+textBoxPassword.Text.Trim()+"')";
                using (SqlCommand command = new SqlCommand(quary, con))
                {
                    con.Open();

                    command.ExecuteNonQuery();
                    lblConfirmation.Text = "User Successfully Added!!!!";
                    textBoxUserName.ReadOnly = true;
                    textBoxPassword.ReadOnly = true;
                    lblConfirmation.Visible = true;
                    addusr.Enabled = false;
                    radioBtnUser.Enabled = false;
                    radioBtnAdmin.Enabled = false;
                    panel2.Enabled = true;
                    lblnow.Visible = true;
                    con.Close();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); MessageBox.Show(ex.StackTrace); }
        }

        private void radioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                String queryText = "SELECT userId FROM userinfo WHERE username = '"+textBoxUserName.Text.Trim()+""+utyp+"'";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                

                using (SqlCommand cmd = new SqlCommand(queryText, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                    //BindingSource bsItems = new BindingSource();
                    DataSet dsEsid = new DataSet("ItemsSet");
                    sqladp.Fill(dsEsid);
                    foreach (DataRow drItems in dsEsid.Tables[0].Rows)
                    {
                        esid = int.Parse(drItems["userId"].ToString());
                    }
                    con.Close();
                }
                String query = "INSERT INTO PersonnelInfo(ESID, Username, Full_name, userType, User_Address, phone_no, gender, date_joined, duty_shift, salary) VALUES('" + esid + "','" + textBoxUserName.Text.Trim() + "" + utyp + "','" + textBoxFullName.Text + "','" + textUsrTyp.Text +"','" + textBoxAddress.Text + "','" + textBoxPhoneNo.Text + "','" + gender + "','" + dateTimePicker1.Text + "','" + comboDutyShift.Text + "','" + int.Parse(textBoxSalary.Text) + "')";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    lblnow.Text = "User Info Successfully Added!!!!";
                    lblConfirmation.Visible = false;
                    lblnow.Visible = true;
                    btnAddUser.Enabled = false;
                    panel2.Enabled = true;
                    con.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUsrTyp.Text = "";
            comboDutyShift.Text = "";
            radioBtnAdmin.Enabled = true;
            radioBtnUser.Enabled = true;
            textBoxUserName.Text = "";
            textBoxUserName.ReadOnly = false;
            textBoxPassword.ReadOnly = false;
            textBoxPassword.Text = "";
            textBoxFullName.Text = "";
            textBoxAddress.Text = "";
            textBoxPhoneNo.Text = "";
            gender = "";
            dateTimePicker1.Text = "";
            textBoxSalary.Text = "";
            panel2.Enabled = false;
            lblnow.Visible = false;
            lblConfirmation.Visible = false;
            addusr.Enabled = true;

        }

        private void radioBtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            textUsrTyp.Text = "System_Admin";
            utyp = "_admin";
        }

        private void radioBtnUser_CheckedChanged(object sender, EventArgs e)
        {
            textUsrTyp.Text = "System_User";
            utyp = "_user";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class ChangePassword : Form
    {
        String Csnd;
        public ChangePassword(String snd)
        {
            InitializeComponent();
            lblConfirmation.Visible = false;
            Csnd = snd;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                String usrop="";
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Railway_Reservation_System;Integrated Security=True");
                String query1 = "SELECT password FROM userinfo WHERE Username='" + Csnd + "'";
                String query2 = "UPDATE userinfo SET [password] ='" + textBoxNewPassword.Text + "' WHERE Username='" + Csnd + "' and [password] = '" + textBoxOldPassword.Text + "'";


                using (SqlCommand cmd = new SqlCommand(query1, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                    DataSet dsusrop = new DataSet("ItemsSet");
                    sqladp.Fill(dsusrop);
                    foreach (DataRow drItems in dsusrop.Tables[0].Rows)
                    {
                        usrop = drItems["password"].ToString();
                    }
                    con.Close();
                }

                if (textBoxOldPassword.Text != usrop)
                {
                    MessageBox.Show("Your Old password not matched!!!");
                    textBoxOldPassword.Text = "";
                    textBoxNewPassword.Text = "";
                    textBoxConfirmPassword.Text = "";
                }
                else
                {

                    if (textBoxNewPassword.Text == textBoxConfirmPassword.Text & textBoxOldPassword.Text == usrop)
                    {
                        using (SqlCommand cmd = new SqlCommand(query2, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            lblConfirmation.Text = "Password Changeded!!!!!";
                            lblConfirmation.Visible = true;
                            textBoxOldPassword.Text = "";
                            textBoxNewPassword.Text = "";
                            textBoxConfirmPassword.Text = "";
                            btnOk.Enabled = false;
                            con.Close();
                        }
                    }
                    else if (textBoxOldPassword.Text == usrop & textBoxNewPassword.Text != textBoxConfirmPassword.Text) {
                        MessageBox.Show("Passwords not matched!!!");
                        textBoxOldPassword.Text = "";
                        textBoxNewPassword.Text = "";
                        textBoxConfirmPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirm Password not matched!!!");
                        textBoxOldPassword.Text = "";
                        textBoxNewPassword.Text = "";
                        textBoxConfirmPassword.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

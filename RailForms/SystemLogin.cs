using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailForms
{
    public partial class SystemLogin : Form
    {
        public SystemLogin()
        {
            InitializeComponent();
        }

        private void btnAdminL_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.adminLgin = new AdminLogin();
                Pages.adminLgin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsrL_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.sysUsrLgin = new SystemUserLogin();
                Pages.sysUsrLgin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SystemLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

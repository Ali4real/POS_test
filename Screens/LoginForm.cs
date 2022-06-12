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
using WindowsFormsApp1.General;

namespace WindowsFormsApp1
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicitionSetting.ConnectionString()))
                {

                }
            }
        }

        private bool IsValid()
        {
            if(UserNameTextBox.Text.Trim()== String.Empty)
            {
                MessageBox.Show("user Name is required ","Error");
                return false;
            }
            if (PasswordTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Password is required ", "Error");
                return false;
            }
            return true;
        }
    }
}

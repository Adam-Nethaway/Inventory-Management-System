using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invenotry_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked == false)
            {
                textPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textPassword.UseSystemPasswordChar = false;
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

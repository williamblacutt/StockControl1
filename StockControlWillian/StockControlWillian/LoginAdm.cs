using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlWillian
{
    public partial class LoginAdm : Form
    {
        public string user;
        public string password;
        public LoginAdm()
        {
            InitializeComponent();
            user = "william";
            password = "123";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {            
            if (txtUser.Text == user && txtPassword.Text == password)
            {
                Cadastro C = new Cadastro();
                C.Show();
                this.Hide();
            }
            else
                MessageBox.Show("User or Password incorrect");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == password)
            {
                btnOk.Enabled = true;
            }
        }
    }
}

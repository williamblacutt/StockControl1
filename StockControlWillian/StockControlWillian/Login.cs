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
    public partial class Login : Form        
    
    {
        public string user;
        public string password;
        public Login()
        {
            InitializeComponent();
            user = "william";
            password = "123";
    }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            LoginAdm LA = new LoginAdm();
            LA.Show();
            this.Hide();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == password)
            {
                btnOk.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Helper.Erro());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

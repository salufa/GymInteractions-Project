using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security;

namespace Gym_Interactions
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            passwordTxtBox.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            var name = nameTxtBox.Text;
            var pswd = new SecureString();
            //File.WriteAllText(filename, logfiletextbox.Text);
        }
    }
}

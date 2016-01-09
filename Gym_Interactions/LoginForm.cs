using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Interactions
{

    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (nameLogintxtBox.Text == "test" && passwordLoginTxtBox.Text == "test")
            {
                MessageBox.Show("Welcome Customer");
               
                Reception reception = new Reception(false);
                reception.ShowDialog();
                this.Close();


               

                
                
            }
            else
            {
                if (nameLogintxtBox.Text == "employee" && passwordLoginTxtBox.Text == "password")
                {
                    MessageBox.Show("Welcome Employee");
                    
                    new Reception(true);
                    this.Close();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
        }
    }
}

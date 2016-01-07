using Gym_Interactions.Forms;
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


    public partial class LoginForm : BaseForm
    {
        public static Reception f_instance = new Reception(false);

        public static Reception RInstance { get { return f_instance; } }


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
                reception.Show();
            }
            else
            {
                if (nameLogintxtBox.Text == "employee" && passwordLoginTxtBox.Text == "password")
                {
                    MessageBox.Show("Welcome Employee");

                    new Reception(true);
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

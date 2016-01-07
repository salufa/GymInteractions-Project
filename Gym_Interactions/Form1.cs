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
    public partial class Form1 : Form
    {
        SectorFactory factory = new SectorFactory();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioRegisterNo_CheckedChanged(object sender, EventArgs e)
        {

            btnRegister.Enabled = true;
            radioRegisterNo.Enabled = true;
            btnLogIn.Enabled = false;

        }

        private void radioRegisterYes_CheckedChanged(object sender, EventArgs e)
        {
            btnLogIn.Enabled = true;
            radioRegisterYes.Enabled = true;
            btnRegister.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnPool.FlatStyle = FlatStyle.Flat;

            btnPool.BackColor = Color.Transparent;

            btnPool.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPool.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPool.FlatAppearance.BorderSize = 0;
           





            this.MaximizeBox = false;
            radioRegisterYes.Checked = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
            this.Hide();
        }

        private void btnPool_Click(object sender, EventArgs e)
        {
            this.Hide();
            factory.GoDown();
            Pool Pool = new Pool();
            Pool.ShowDialog();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Interactions.Utilities;

namespace Gym_Interactions
{
    public partial class Reception : Form
    {
        public Pool Pool = new Pool(new PoolSector());
        public Gym gym = new Gym(new GymSector());
        public BarRoom bar = new BarRoom(new BarSector());
        public LockerRoom lockers = new LockerRoom(new LockersSector());
        
        
        public Reception(bool personelflag)
        {
            InitializeComponent();

            Pool Pool = new Pool(new PoolSector());
            if (personelflag)
            {
                Enable_EmployeeButtons();
                
            }
            else
            {
                Enable_CustomerButtons();
            }
            Controls
                    .OfType<ButtonBase>()
                    .ForEach(b => ControlHelpers.MakeTransparent(b));

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
            this.MaximizeBox = false;
            radioRegisterYes.Checked = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
            //this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();

        }

        private void btnPool_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pool.ShowDialog();

        }

        private void btnGym_Click(object sender, EventArgs e)
        {
            this.Hide();
            gym.ShowDialog();
        }

        private void btnLockers_Click(object sender, EventArgs e)
        {
            this.Hide();
            lockers.ShowDialog();

        }

        private void btnBar_CLick(object sender, EventArgs e)
        {
            this.Hide();

            bar.ShowDialog();

        }

        private void Reception_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void Enable_CustomerButtons()
        {
            btnPool.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        public void Enable_EmployeeButtons()
        {

        }
    }
}

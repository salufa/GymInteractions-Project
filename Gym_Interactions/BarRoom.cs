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
    public partial class BarRoom : Form
    {
        public BarRoom(BarSector bar_obj)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void orderWizardBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }
    }
}

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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            int dateTime = Convert.ToInt16(DateTime.Now.ToString("HH"));

            if (dateTime < 6) //Day Time
            {
                drinksListBox.Enabled = false;
                labelNight.Visible = false;

                foodListBox.Enabled = true;
                labelDay.Visible = true;

            }
            else if (dateTime >= 6) //Night Time
            {
                drinksListBox.Enabled = true;
                labelNight.Visible = true;

                foodListBox.Enabled = false;
                labelDay.Visible = false;
            }
              

        }
    }
}

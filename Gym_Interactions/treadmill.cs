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
    public partial class treadmill : Form
    {
       
        public treadmill()
        {
            InitializeComponent();
        }

        private void treadmill_Load(object sender, EventArgs e)
        {
            //ControlHelpers.MakeTransparent(treadmillStart);
        }


        //calculate the mass depending on the gender
        

        public void treadmillStart_Click(object sender, EventArgs e)
        {
            //ControlHelpers.MakeTransparent(treadmillStart);

            //TODO change function depending on the gender, will now use by default the RandomNumberMale

            //MessageBox.Show("Your mass is:", mass.ToString());
            //MessageBox.Show("Yout height is",heightTxtBox.Text.ToString());
            //MessageBox.Show("Yout age is", ageTxtBox.Text.ToString());
            try
            {
                Suggestions(mass:int.Parse(massTxtBox.Text), age:int.Parse(ageTxtBox.Text), healthy:false);

                //pass the values to data grid view
                GetValueFromSuggestionsToDTG();
            }
            catch
            {}
                   
        }



        public void massCalculate_Click(object sender, EventArgs e)
        {
            massTxtBox.Text = RandomMass.ToString();
            int mass = int.Parse(massTxtBox.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var height = heightTxtBox.Text.ToString();
        }

        public void ageBtn_Click(object sender, EventArgs e)
        {
            var age = ageTxtBox.Text.ToString();
        }

        static Random r = new Random();
        int RandomMass = r.Next(60, 140);

        bool healthy = false;

        double time, speed, times_per_week;

        public void Suggestions(int mass, int age, bool healthy)
        {

            string type, food_program;

            if (mass > 100 || (age > 50 || age < 18))
            {
                time = 10;
                speed = 6;
                times_per_week = 3;
                healthy = false;
            }
            else
            {
                time = 15;
                speed = 8.5;
                times_per_week = 5;
                healthy = true;
            }

            if (healthy == true)
            {
                food_program = "HEALTHY PERSON.   Whole wheat bread Oatmeal, Whole wheat pasta,Brown rice,Potatoes,,Lean cuts of beef,Fish,Eggs,Fat free cottage cheese";
                food_programTxtBox.Text = food_program;
            }
            else
            {
                food_program = "UNHEALTHY PERSON.  Most Chinese foods,Steaks,Butter,Hamburgers,Cheeseburgers,Ice cream,Pasta,And anything oily, sugary, fried, or saucy.";
                food_programTxtBox.Text = food_program;
            }
            //return food_program;
        }


        public void GetValueFromSuggestionsToDTG()
        {
            double time_row = time;
            double speed_row = speed;
            double times_per_week_row = times_per_week;

            suggestionTreadmill.Rows.Add(time_row, speed_row, times_per_week_row);

        }
    }

    // xml serialization for form saving?
}

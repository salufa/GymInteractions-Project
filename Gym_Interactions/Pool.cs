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

using System.Drawing.Imaging;

namespace Gym_Interactions
{
    public partial class Pool : Form
    {
        public Pool(PoolSector pool_obj)
        {
            InitializeComponent();
        }

        //detects if people exist inside the swimming pool
        public bool humanInside = false;
        public bool alarm = false;
        int temperature;

        private void Pool_Load(object sender, EventArgs e)
        {
           
            //ControlHelpers.MakeTransparent(swimBtn);
            scrBrightness.Value = 100;
            AdjustImage();
            scrWaterLevel.Value = 0;
            AdjustWaterLevel();

            SensorOff.Checked = true;
            if (SensorOff.Checked == true)
            {
                peopleInsidePoolBtn.Enabled = false;
                AlarmEnabler.Enabled = false; 
            }
        }

        private void swimBtn_Click(object sender, EventArgs e)
        {

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            // player.SoundLocation = @"c:\Users\andrewchron\Documents\Visual Studio 2015\Projects\GymInteractions-Project-master\GymInteractions-Project-master\Gym_Interactions\Resources\Water_Churning.wav";
            // player.Load();
            // player.Play();

            //human is in the pool
            humanInside = true;
            
        }

        private void waterSettings_Click(object sender, EventArgs e)
        {
            PoolSettings PoolSettings = new PoolSettings();
            PoolSettings.ShowDialog();
        }

        private void lightSettings_Click(object sender, EventArgs e)
        {
            PoolSettings PoolSettings = new PoolSettings();
            PoolSettings.ShowDialog();
        }



         // Perform the brightness adjustment and display the result.
        private void AdjustImage()
        {
            // lblBrightness.Text = "Brightness = " + (scrBrightness.Value / 100.0).ToString();
            lblBrightness.Text = (scrBrightness.Value / 100.0).ToString();
            picAdjusted.Image = AdjustBrightness(picOriginal.Image, (float)(scrBrightness.Value / 100.0));
        }

        // Adjust the image's brightness.
        private Bitmap AdjustBrightness(Image image, float brightness)
        {
            // Make the ColorMatrix.
            float b = brightness;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {b, 0, 0, 0, 0},
                    new float[] {0, b, 0, 0, 0},
                    new float[] {0, 0, b, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Draw the image onto the new bitmap while applying the new ColorMatrix.
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width - 1, 0),
                new Point(0, image.Height - 1),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Make the result bitmap.
            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
            }

            // Return the result.
            return bm;
        }

        private void AdjustWaterLevel()
        {
            //lblWaterLevel.Text = "Water Level = " + scrWaterLevel.Value.ToString();
            lblWaterLevel.Text = scrWaterLevel.Value.ToString();
        }

        private void scrBrightness_Scroll(object sender, ScrollEventArgs e)
        {
            AdjustImage();
        }

        private void picAdjusted_Click(object sender, EventArgs e)
        {

        }

        private void scrWaterLevel_Scroll(object sender, ScrollEventArgs e)
        {
            AdjustWaterLevel();
        }

        private void sensorEnabled_CheckedChanged(object sender, EventArgs e)
        {
            //double BrightnessLevel;
            //int WaterLevel;
            ////int temperature;

            //BrightnessLevel = double.Parse(lblBrightness.Text);
            //WaterLevel = int.Parse(lblWaterLevel.Text);
            //int temperature = (int)numericUpDown1.Value;


            //if ((humanInside == true) && (BrightnessLevel <= 0.8) && (WaterLevel < 30) && (alarm == false) && (temperature > 15) && temperature < 35)
            //{
            //    MessageBox.Show("Alarm has been triggerd!");
            //    alarm = true;
            //}
            //else
            //{
            //    MessageBox.Show("Alarm is off because the sensor was disabled!");
            //}

            //sensorDisabled.Enabled = true; 
            //sensorEnabled.Enabled = false;
        }

        private void sensorDisabled_CheckedChanged(object sender, EventArgs e)
        {
            //humanInside = false;
           // alarm = false;
            //sensorDisabled.Enabled = false;
            //sensorEnabled.Enabled = true;
        }

        private void exitPoolBtn_Click(object sender, EventArgs e)
        {
            //customer exits the pool
            humanInside = false;
        }

        private void AlarmEnabler_CheckedChanged(object sender, EventArgs e)
        {
            if (SensorOn.Checked == true)
            {
                if (AlarmEnabler.Checked == true)
                {
                    double BrightnessLevel;
                    int WaterLevel;

                    BrightnessLevel = double.Parse(lblBrightness.Text);
                    WaterLevel = int.Parse(lblWaterLevel.Text);
                    int temperature = (int)numericUpDown1.Value;


                    if ((humanInside == true) && ((BrightnessLevel <= 0.8) || (WaterLevel < 30) || ((temperature < 15 && temperature > 35))))
                    {
                        MessageBox.Show("Alarm has been triggerd!");
                        alarm = true;
                    }
                    else
                    {
                        MessageBox.Show("Alarm is off because the sensor was not triggered or it is turned off!");
                    }

                }
                
            }
        }

        private void peopleInsidePoolBtn_Click(object sender, EventArgs e)
        {
            if (SensorOn.Checked == true)
            {
                if (humanInside == true)
                {
                    MessageBox.Show("There are humans inside the swimming pool");
                }
                else
                {
                    MessageBox.Show("There are no humans in the swimming pool");
                }
            }
        }

        private void SensorOn_CheckedChanged(object sender, EventArgs e)
        {
            peopleInsidePoolBtn.Enabled = true;
            AlarmEnabler.Enabled = true;
        }

        private void SensorOff_CheckedChanged(object sender, EventArgs e)
        {
            peopleInsidePoolBtn.Enabled = false;
            AlarmEnabler.Enabled = false;
        }
    }
}

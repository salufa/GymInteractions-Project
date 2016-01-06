using Gym_Interactions.Utilities;
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
    public partial class Gym : Form
    {
        public GymSector Factory { get; set; }
        private SectorAwesomizer m_awesomizer;

        public Gym(GymSector gym_obj)
        {
            InitializeComponent();
            Factory = gym_obj;
            gym_obj.AssetAvailabilityChanged += gym_obj_AssetAvailabilityChanged;
            m_awesomizer = new SectorAwesomizer(gym_obj);
            m_awesomizer.Start();
        }

        private void Post(Action action)
        {
            if (InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        void gym_obj_AssetAvailabilityChanged(object sender, AssetEventArgs e)
        {
            Post(() =>
            {

            });
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            Factory.Create(4);

        }
        private void btnTreadmill_Click(object sender, EventArgs e)
        {
            Factory.Create(2);
        }
        private void btnMachines_Click(object sender, EventArgs e)
        {
            Factory.Create(1);
        }
        private void btnWeightbench_Click(object sender, EventArgs e)
        {
            Factory.Create(3);
        }

        private void Gym_Load(object sender, EventArgs e)
        {
            ControlHelpers.MakeTransparent(btnTreadMill);
            ControlHelpers.MakeTransparent(btnBike);
            ControlHelpers.MakeTransparent(btnSkata);
        }
    }
}

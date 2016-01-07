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
        
        private SectorAwesomizer m_awesomizer;

        public Gym(GymSector gym_obj)
        {
            InitializeComponent();
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
            AssetFactory.Instance.Create(3);

        }
        private void btnTreadmill_Click(object sender, EventArgs e)
        {
            AssetFactory.Instance.Create(1);
        }
        private void btnMachines_Click(object sender, EventArgs e)
        {
            AssetFactory.Instance.Create(0);
        }
        private void btnWeightbench_Click(object sender, EventArgs e)
        {
            AssetFactory.Instance.Create(2);
        }

        private void Gym_Load(object sender, EventArgs e)
        {
            ControlHelpers.MakeTransparent(btnTreadMill);
            ControlHelpers.MakeTransparent(btnBike);
            ControlHelpers.MakeTransparent(btnSkata);
        }
    }
}

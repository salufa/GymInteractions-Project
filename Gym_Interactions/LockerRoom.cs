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
    public partial class LockerRoom : Form
    {
        public LockerRoom(LockersSector locker_obj)
        {
            InitializeComponent();

        }
        private void Locker_Load(object sender , EventArgs e)
        {
            ControlHelpers.MakeTransparent(btnSauna);
            ControlHelpers.MakeTransparent(btnShower);
        }

        private void btnSauna_Click(object sender, EventArgs e)
        {
            AssetFactory.Instance.Create(4);
        }

        private void btnShower_Click(object sender, EventArgs e)
        {
            AssetFactory.Instance.Create(5);
        }
    }
}

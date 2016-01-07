using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_Interactions
{
    public class AssetEventArgs : EventArgs
    {
        public Guid AssetTypeId { get; set; }
        public bool Availability { get; set; }
    }
}

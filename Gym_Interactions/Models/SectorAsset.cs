using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Interactions.Models
{
    public abstract class SectorAsset
    {
        public virtual bool Available { get; set; }

        public Guid TypeID { get; set; }
    }
}

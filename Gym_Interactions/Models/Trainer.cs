using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Interactions.Models
{

    public class Trainer
    {
        public string Name { get; set; }

        public virtual TrainingProgram GetProgram(int weight)
        {
            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Interactions.Forms
{
    public interface IBackTrackingForm
    {
        void Visit(Form from);
        void Backtrack();
    }
}

using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Gym_Interactions.Utilities
{
    public class ControlHelpers
    {

        public static void MakeTransparent(ButtonBase button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0;


        }
    }
}
   


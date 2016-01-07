using Gym_Interactions.Models;
using Gym_Interactions.Utilities;
using System;


namespace Gym_Interactions
{
    public class BarSector : BaseSector, ISupportSimulation
    {
        
         public void Create(int productID)
        {


        }
        public void SimulateInteraction()
        {
            var randomId = Guid.NewGuid();
            SetAvailability(m_Assets[randomId], false);
        }
        
    }
    
}

using Gym_Interactions.Models;
using Gym_Interactions.Utilities;
using System;

namespace Gym_Interactions
{
    public class LockersSector : BaseSector, ISupportSimulation
    {

        public void Create(int productID)
        {
            AddAsset(Guid.NewGuid(), new Showers());
            AddAsset(Guid.NewGuid(), new Sauna());

        }
        public void SimulateInteraction()
        {
            //var randomId = Guid.NewGuid();
            //SetAvailability(m_Assets[randomId], false);
        }

       
    }
}
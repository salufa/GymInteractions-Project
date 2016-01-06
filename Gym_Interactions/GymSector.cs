using Gym_Interactions.Models;
using Gym_Interactions.Utilities;
using System;
namespace Gym_Interactions
{
    public class GymSector : BaseSector, ISupportSimulation
    {


        public GymSector()
        {
            AddAsset(Guid.NewGuid(), new Machines());
            AddAsset(Guid.NewGuid(), new Treadmill());
            AddAsset(Guid.NewGuid(), new Bicycle());
            AddAsset(Guid.NewGuid(), new WeightBench());
        }

        public void SimulateInteraction()
        {
            //var randomId = Guid.NewGuid();
            //SetAvailability(m_Assets[randomId], false);
        }
    }

}


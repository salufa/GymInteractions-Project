using Gym_Interactions.Models;
using Gym_Interactions.Utilities;
using System;
namespace Gym_Interactions
{
    public class GymSector : BaseSector, ISupportSimulation
    {

        public SectorAsset Create(int productID)
        {
            var product = default(SectorAsset);
            switch (productID)
            {

                case 0:
                    product = new Machines();
                    break;
                case 1:
                    product = new Treadmill();
                    break;
                case 2:
                    product = new WeightBench();
                    break;
                case 3:
                    product = new Bicycle();
                    break;

            }
            return product;

        }

        private class Machines : SectorAsset
        {
            public Machines()
            {

            }
        }

        private class Bicycle : SectorAsset
        {
            void SectorDataProcess()
            {

            }

        }
        private class Treadmill : SectorAsset
        {
            public Treadmill()
            {
            }
        }
        private class WeightBench : SectorAsset
        {
            public WeightBench()
            {
            }
        }




        public void SimulateInteraction()
        {
          //  var randomId = Guid.NewGuid();
          //  SetAvailability(m_Assets[randomId], false);
        }
    }

}


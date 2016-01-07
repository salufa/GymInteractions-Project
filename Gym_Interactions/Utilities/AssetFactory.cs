using Gym_Interactions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Interactions.Utilities
{
    public class AssetFactory
    {

        public static AssetFactory s_instance;

        public static AssetFactory Instance { get { return s_instance; } }

        static AssetFactory()
        {
            s_instance = new AssetFactory();
        }

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
                case 4:
                    product = new Showers();
                    break;
                case 5:
                    product = new Sauna();
                    break;

            }
            return product;

        }
    }
}
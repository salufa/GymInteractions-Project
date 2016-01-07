using Gym_Interactions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Interactions
{
    public interface ISector
    {

        event EventHandler<AssetEventArgs> AssetAvailabilityChanged;
        void GoUp();

        //SectorAsset CreateAsset(int assetId);
    }
}
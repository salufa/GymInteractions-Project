using Gym_Interactions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Interactions.Utilities
{
    public class BaseSector : ISector
    {
        protected Dictionary<Guid, SectorAsset> m_Assets;

        public BaseSector()
        {
            m_Assets = new Dictionary<Guid, SectorAsset>();
        }
        public void AddAsset(Guid id,SectorAsset asset)
        {
            m_Assets.Add(id,asset);
        }

        private void OnAssetChanged(Guid id, bool availability)
        {
            var handler = AssetAvailabilityChanged;
            if (handler != null)
            {
                AssetAvailabilityChanged(this, new AssetEventArgs() { AssetTypeId = id, Availability = availability });
            }
        }

        protected void SetAvailability(SectorAsset asset, bool available)
        {
            if (m_Assets.ContainsKey(asset.TypeID))
            {
                m_Assets[asset.TypeID].Available = available;
                OnAssetChanged(asset.TypeID, available);
            }
        }

        public event EventHandler<AssetEventArgs> AssetAvailabilityChanged;

        public void GoUp()
        {
            throw new NotImplementedException();
        }
    }
}

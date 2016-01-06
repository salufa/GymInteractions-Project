using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Interactions.Models
{
    class MultiUserMachine : SectorAsset
    {
        private readonly int MAX_USERS;
        private int m_currentUsers;

        public MultiUserMachine(int maxUsers)
        {
            MAX_USERS = maxUsers;
        }

        public override bool Available
        {
            get
            {
                return m_currentUsers < MAX_USERS;
            }
            set
            {
                if (m_currentUsers >= MAX_USERS)
                    throw new InvalidOperationException("");
                else
                    m_currentUsers++;
            }
        }
    }
}

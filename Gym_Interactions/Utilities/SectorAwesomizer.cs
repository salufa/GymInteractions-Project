using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Interactions.Utilities
{
    public class SectorAwesomizer
    {
        private System.Threading.Timer m_timer;
        private ISupportSimulation m_sector;

        private object m_state;
        private object TIMER_RUNNING = new object();
        private object TIMER_STOPPED = new object();

        public SectorAwesomizer(ISupportSimulation sector)
        {
            m_sector = sector;
        }

        public void Start()
        {
            m_timer = new System.Threading.Timer((_) =>
            {
                var oldRunning = m_state;
                if (Interlocked.CompareExchange(ref m_state, TIMER_RUNNING, TIMER_RUNNING) == oldRunning)
                {
                    m_sector.SimulateInteraction();
                }
            }, 
            new object(), 
            TimeSpan.Zero, 
            TimeSpan.FromSeconds(15));
        }

        public void Stop()
        {
            m_state = TIMER_STOPPED;
            m_timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}

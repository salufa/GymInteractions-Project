using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Gym_Interactions.Utilities
{
    public class SectorAwesomizerFlow
    {
        private CancellationTokenSource m_cancellationSource;
        private WaitHandle m_autoResetEvent = new AutoResetEvent(false);
        private bool m_Continue = true;

        ITargetBlock<ISector> CreateAwesomenessNetwork()
        {
            var abuseMachines = new TransformBlock<ISector, ISector>(val =>
            {
                if (val != null)
                {
                    return ApplyRandomizedAbuse(val);
                }
                return null;
            });

            var updateSector = new ActionBlock<IEnumerable<ISector>>(sector =>
            {

            },


            new ExecutionDataflowBlockOptions()
            {
                // Specify a task scheduler from the current synchronization context
                // so that the action runs on the UI thread.
                TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext()
            });

            var cancellationRequested = new ActionBlock<object>(_ =>
            {
                m_Continue = false;
            });
            return abuseMachines;
        }

        private ISector ApplyRandomizedAbuse(ISector sector)
        {
            throw new NotImplementedException();
        }
    }
}

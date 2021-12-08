using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopWatches.Model;

namespace StopWatches.ViewModel
{
    public interface IStopWatchHelper
    {
        List<StopWatch> GetStopWatches();
        void AddStopWatch(StopWatch stopWatch);
    }
}

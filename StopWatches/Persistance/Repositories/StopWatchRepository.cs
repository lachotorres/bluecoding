using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopWatches.Repositories;
using StopWatches.Model;

namespace StopWatches.Persistance.Repositories
{
    public class StopWatchRepository: Repository<Model.StopWatch>, IStopWatch
    {
        public StopWatchRepository(dbtestEntities context) : base(context)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using StopWatches.Commands;
using StopWatches.Model;
using StopWatches.Persistance.Repositories;
using StopWatches.Repositories;

namespace StopWatches.ViewModel
{
    public class MainVM
    {
        private readonly IStopWatch _repository;
        public AddStopWatchCommand AddStopWatchCommand { get; set; }
        public ObservableCollection<Model.StopWatch> StopWatches { get; set; }

        public MainVM(IStopWatch repository)
        {
            _repository = repository;
            AddStopWatchCommand = new AddStopWatchCommand(this);
            StopWatches = new ObservableCollection<StopWatch>();
            GetStopWatches(); //get all stopwatches on Load
        }

        public void GetStopWatches()
        {
            StopWatches.Clear();
            var stopWatches = _repository.GetAll();
            foreach (var stopWatch in stopWatches)
            {
                StopWatches.Add(stopWatch);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// RECORD IS NOT GETTING SAVED ON DATABASE CAUSE DIDNT HAD TIME TO IMPLEMENT UNIT OF WORK
        /// </remarks>
        public void AddStopWatch()
        {
            if (StopWatches.Count == 5)
            {
                MessageBox.Show("There are already 5 stop watches in the list");
                return;
            }

            var stopWatch = new Model.StopWatch {Active = true};
            StopWatches.Add(stopWatch);
            _repository.Add(stopWatch);
            //unitOfWork.Commit; //indicated cause didnt had time to implement unitOfwork

        }

        /// <summary>
        /// Persist state for each StopWatch
        /// </summary>
        public void OnExit()
        {
            foreach (var stopWatch in StopWatches)
            {
                stopWatch.LastTimeUpdated = DateTime.Now;
                //unitOfWork.Commit; //indicated cause didnt had time to implement unitOfwork

            }
        }
    }
}

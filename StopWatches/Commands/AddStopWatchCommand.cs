using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StopWatches.ViewModel;

namespace StopWatches.Commands
{
    public class AddStopWatchCommand : ICommand
    {
        private MainVM _mainVM { get; set; }

        public event EventHandler CanExecuteChanged;

        public AddStopWatchCommand(MainVM mainVM)
        {
            _mainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _mainVM.AddStopWatch();
        }
    }
}

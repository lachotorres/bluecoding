﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using StopWatches.Persistance.Repositories;
using StopWatches.Repositories;

namespace StopWatches
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App(){

            DependencyInjector.Register<IStopWatch, StopWatchRepository>();
            MainWindow = DependencyInjector.Retrieve<MainWindow>();
            MainWindow.Show();
        }

        private void App_OnExit(object sender, ExitEventArgs e)
        {
           
        }
    }
}

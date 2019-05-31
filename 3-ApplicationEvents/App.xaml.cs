using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ApplicationEvents
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnApplicationExit(object sender, ExitEventArgs e)
        {
            Console.WriteLine("Exit event received...");

        }

        private void OnApplicationActivated(object sender, EventArgs e)
        {
            Console.WriteLine("Activated event received...");
        }

        private void Application_Startup(object sender, EventArgs e)
        {
            Console.WriteLine("Startup event received...");
        }

        private void OnLoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            int i = 0;
            i += 1;
            Console.WriteLine("LoadCompleted event received...");
        }
    }
}

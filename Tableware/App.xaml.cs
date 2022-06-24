using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tableware.Services;
using Tableware.Windows;

namespace Tableware
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            App app = new App();
            AuthDataStore authDataStore = new AuthDataStore(new AppData.ApplicationContext());
            StartWindow startWindow = new StartWindow();
            app.Run(startWindow);
        }
    }
}

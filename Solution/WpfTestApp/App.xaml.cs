using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Domain;

namespace WpfTestApp {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        public App() {
            ExampleService service = new();
            int result = service.Addition(5, 3);

            System.Diagnostics.Debug.WriteLine("5 + 3 = " + result.ToString());
        }
    }
}

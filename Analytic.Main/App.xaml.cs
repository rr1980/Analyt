using Analytic.Logic;
using Analytic.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Analytic.Main
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            GlobalPageContainer.AddPage(new HomePage());

            GlobalPageContainer.AddPage(new CpuPage());
        }
    }
}

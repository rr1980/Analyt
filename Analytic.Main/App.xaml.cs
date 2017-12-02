using Analytic.Logic;
using Analytic.Logic.Mediator;
using Analytic.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            GlobalPageContainer.AddPage(new HomePage());
            GlobalPageContainer.AddPage(new CpuPage());

            Mediator.Register("Log", Log);
        }

        private void Log(object obj)
        {
            Debug.WriteLine(obj);
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            ExceptionWindow exWin = new ExceptionWindow(e.Exception);
            exWin.ShowDialog();
            e.Handled = true;
        }
    }
}

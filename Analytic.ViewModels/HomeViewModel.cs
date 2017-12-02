using Analytic.Logic;
using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Analytic.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(Page page)
        {

        }

        public AwaitableDelegateCommand GoCpuPageCommand
        {
            get; set;
        }
    }
}

using Analytic.Logic;
using System.Windows.Controls;

namespace Analytic.ViewModels
{
    public class CpuViewModel : ViewModelBase
    {
        public CpuViewModel(Page page)
        {

        }

        public AwaitableDelegateCommand GoHomePageCommand
        {
            get; set;
        }

    }
}

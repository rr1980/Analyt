using Analytic.Logic.Commands;
using Analytic.Services;
using System.Windows.Controls;

namespace Analytic.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly Page _page;
        public AwaitableDelegateCommand GoCpuPageCommand { get; set; }

        public HomeViewModel(Page page)
        {
            _page = page;
            GoCpuPageCommand = new AwaitableDelegateCommand(() => NavigatorService.GoPage(_page, "CpuPage"));
        }
    }
}

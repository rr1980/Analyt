using Analytic.Logic.Commands;
using Analytic.Services;
using System.Windows.Controls;

namespace Analytic.ViewModels
{
    public class CpuViewModel : ViewModelBase
    {
        private readonly Page _page;
        public AwaitableDelegateCommand GoHomePageCommand { get; set; }

        public CpuViewModel(Page page)
        {
            _page = page;
            GoHomePageCommand = new AwaitableDelegateCommand(async () =>
            {
                await CpuViewModelService.TakeTime(3000);
                await NavigatorService.GoPage(_page, "HomePage");
            });
        }
    }
}

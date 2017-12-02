using Analytic.Logic.Commands;
using Analytic.Services;
using System;
using System.Windows.Controls;

namespace Analytic.ViewModels
{
    public class CpuViewModel : ViewModelBase
    {
        private readonly Page _page;
        public AwaitableDelegateCommand GoHomePageCommand { get; set; }

        private string _tBox;
        public string TBox
        {
            get
            {
                return _tBox;
            }
            set
            {
                if (_tBox == value)
                {
                    return;
                }

                _tBox = value;
                OnPropertyChanged();
            }
        }

        public CpuViewModel(Page page)
        {
            _page = page;
            GoHomePageCommand = new AwaitableDelegateCommand(async () =>
            {
                await CpuViewModelService.TakeTime(TBox);
                await NavigatorService.GoPage(_page, "HomePage");
            });
        }
    }
}

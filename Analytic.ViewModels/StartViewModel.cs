using Analytic.Logic.Commands;
using Analytic.Logic.Mediator;
using Analytic.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Analytic.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        private static Page _currentPage;
        public AwaitableDelegateCommand GoHomePageCommand { get; set; } = new AwaitableDelegateCommand(async () => _currentPage = await NavigatorService.GoPage(_currentPage, "HomePage"));
        public AwaitableDelegateCommand GoCpuPageCommand { get; set; } = new AwaitableDelegateCommand(async () => _currentPage = await NavigatorService.GoPage(_currentPage, "CpuPage"));

        public string HistorySelectedPage
        {
            get { return null; }
            set
            {
                var command = new AwaitableDelegateCommand(async () => _currentPage = await NavigatorService.GoPage(_currentPage, value));
                command.Execute(null);
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> History
        {
            get
            {
                return NavigatorService.Histories;
            }
        }

        public StartViewModel(Page startPage)
        {
            _currentPage = startPage;
        }
    }
}

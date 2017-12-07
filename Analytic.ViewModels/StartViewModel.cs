using Analytic.Logic.Commands;
using Analytic.Logic.Mediator;
using Analytic.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Analytic.ViewModels
{
    public class ComboBoxItem
    {
        public string PageName { get; set; }
    }

    public class StartViewModel : ViewModelBase
    {
        private Page _currentPage;
        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                OnPropertyChanged();
                OnPropertyChanged("History");
            }
        }
        public AwaitableDelegateCommand GoHomePageCommand { get; set; }
        public AwaitableDelegateCommand GoCpuPageCommand { get; set; }
        public AwaitableDelegateCommand GoProcessPageCommand { get; set; }

        public string HistorySelectedPage
        {
            set
            {
                var command = new AwaitableDelegateCommand(async () => CurrentPage = await NavigatorService.GoPage(CurrentPage, value));
                command.Execute(null);
            }
        }

        public List<string> History
        {
            get
            {
                return NavigatorService.Histories;
            }
        }

        public StartViewModel(Page startPage)
        {
            _currentPage = startPage;
            GoHomePageCommand = new AwaitableDelegateCommand(async () => CurrentPage = await NavigatorService.GoPage(CurrentPage, "HomePage"));
            GoCpuPageCommand = new AwaitableDelegateCommand(async () => CurrentPage = await NavigatorService.GoPage(CurrentPage, "CpuPage"));
            GoProcessPageCommand = new AwaitableDelegateCommand(async () => CurrentPage = await NavigatorService.GoPage(CurrentPage, "ProcessPage"));
        }
    }
}

using Analytic.Logic;
using Analytic.Logic.Mediator;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Analytic.Services
{
    public static class NavigatorService
    {
        public static ObservableCollection<string> Histories = new ObservableCollection<string>();

        public static Task<Page> GoPage(Page page, string pageName)
        {
            Mediator.Send("Log", "Execute GoPage: "+ pageName);
            var _p = GlobalPageContainer.GetPage(pageName);
            var _navigationService = NavigationService.GetNavigationService(page);
            navigate(_navigationService, _p,  pageName);
            return Task.FromResult(_p);
        }

        private static void navigate(NavigationService navigationService, Page page, string pageName)
        {
            if (Histories.Contains(pageName))
            {
                navigationService.Navigate(page);
                navigationService.RemoveBackEntry();
            }
            else
            {
                navigationService.Navigate(page);
                Histories.Add(pageName);
            }
        }
    }
}

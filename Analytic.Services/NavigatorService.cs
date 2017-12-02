using Analytic.Logic;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Analytic.Services
{
    public static class NavigatorService
    {
        private static List<string> _histories = new List<string>();

        public static Task GoPage(Page page, string pageName)
        {
            var _p = GlobalPageContainer.GetPage(pageName);
            var _navigationService = NavigationService.GetNavigationService(page);
            navigate(_navigationService, _p,  pageName);
            return Task.FromResult(0);
        }

        private static void navigate(NavigationService navigationService, Page page, string pageName)
        {
            if (_histories.Contains(pageName))
            {
                navigationService.Navigate(page);
                navigationService.RemoveBackEntry();
            }
            else
            {
                navigationService.Navigate(page);
                _histories.Add(pageName);
            }
        }
    }
}

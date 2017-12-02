using Analytic.Logic;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Analytic.Services
{
    public static class NavigatorService
    {
        public static Task GoPage(Page Page, string pageName)
        {
            var _p = GlobalPageContainer.GetPage(pageName);
            var _navigationService = NavigationService.GetNavigationService(Page);
            _navigationService.Navigate(_p);
            return Task.FromResult(0);
        }

    }
}

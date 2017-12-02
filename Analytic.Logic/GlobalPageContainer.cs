using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Analytic.Logic
{
    public static class GlobalPageContainer
    {
        public static Dictionary<string, Page> _container = new Dictionary<string, Page>();

        public static void AddPage(Page page)
        {
            var name = page.GetType().Name;
            if (!_container.TryGetValue(name, out var foundPage))
            {
                _container.Add(name, page);
            }
        }

        public static Page GetPage(string name)
        {
            if (_container.TryGetValue(name, out var foundPage))
            {
                return foundPage;
            }
            else
            {
                throw new Exception("Page nicht gefunden: " + name);
            }
        }
    }
}

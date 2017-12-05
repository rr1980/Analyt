using Analytic.Logic;
using Analytic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Analytic.Views
{
    /// <summary>
    /// Interaktionslogik für StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();

            var _p = GlobalPageContainer.GetPage("HomePage");
            this.DataContext = new StartViewModel(_p);
            _mainFrame.NavigationService.Navigate(_p);
        }
    }
}

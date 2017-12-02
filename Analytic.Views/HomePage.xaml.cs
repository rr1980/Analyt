﻿using Analytic.Logic;
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
    /// Interaktionslogik für HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            System.Diagnostics.PresentationTraceSources.DataBindingSource.Switch.Level = System.Diagnostics.SourceLevels.Critical;
            var vm = new HomeViewModel(this);

            vm.GoCpuPageCommand = new AwaitableDelegateCommand(async () =>
            {
                CpuPage page = new CpuPage();
                await Task.Delay(5000);

                this.NavigationService.Navigate(page);
                //return Task.FromResult(0);
            });

            DataContext = vm;
        }
    }
}
﻿using Analytic.Logic;
using Analytic.Logic.Commands;
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
    /// Interaktionslogik für CpuPage.xaml
    /// </summary>
    public partial class CpuPage : Page
    {
        public CpuPage()
        {
            InitializeComponent();
            System.Diagnostics.PresentationTraceSources.DataBindingSource.Switch.Level = System.Diagnostics.SourceLevels.Critical;
            DataContext = new CpuViewModel(this);
        }
    }
}

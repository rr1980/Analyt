using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Analytic.Common;
using Analytic.Logic.Commands;
using Analytic.Models;
using Analytic.Services;

namespace Analytic.ViewModels
{
    public class ProcessViewModel : ViewModelBase
    {
        private List<Process_Search_Model> _process_Search_Model = new List<Process_Search_Model>();
        public List<Process_Search_Model> Process_Search_Model
        {
            get
            {
                return _process_Search_Model;
            }
            set
            {
                _process_Search_Model = value;
                OnPropertyChanged();
            }
        }

        public AwaitableDelegateCommand Search_Process_Command { get; set; }

        public ProcessViewModel()
        {
            Search_Process_Command = new AwaitableDelegateCommand(async () => Process_Search_Model = await ProcessViewModelService.Search_Processes());
        }

    }
}

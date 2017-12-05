using Analytic.Logic;
using System;

namespace Analytic.ViewModels
{
    public class CpuViewModel : ViewModelBase
    {
        private string _tBox;
        public string TBox
        {
            get
            {
                return _tBox;
            }
            set
            {
                if (_tBox == value)
                {
                    return;
                }

                _tBox = value;
                OnPropertyChanged();
            }
        }

        public CpuViewModel()
        {
        }
    }
}

using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpflight.Model
{
    public class WelcomeModel : ObservableObject
    {
        private string _introduction = string.Empty;

        public string Introduction
        {
            get => _introduction;
            set
            {
                _introduction = value;
                RaisePropertyChanged(() => Introduction);
            }
        }
    }
}

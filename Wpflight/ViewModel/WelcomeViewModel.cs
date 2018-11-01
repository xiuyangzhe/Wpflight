using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpflight.Model;

namespace Wpflight.ViewModel
{
    public class WelcomeViewModel : ViewModelBase
    {
        private WelcomeModel welcomModel;

        public WelcomeViewModel()
        {
            welcomModel = new WelcomeModel() { Introduction = "Welcome to Mvvm light" };
        }

        public WelcomeModel WelcomModel { get => welcomModel; set => welcomModel = value; }
    }
}

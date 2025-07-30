using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DataBinding.step_04.Model;
using Demo.DataBinding.step_04.Utils;

namespace Demo.DataBinding.step_04.ViewModel
{
    public class MyWindowVm : NotifyPropertyChanged
    {
        protected City _city;

        public MyWindowVm(City city) {
            _city = city;
            _city.PerimeterProperty.PropertyChanged += (_, _) => OnPropertyChanged(nameof(Perimeter));
        }

        protected float _perimeter;

        public float Perimeter {
            get => _city.PerimeterProperty.Value;
            set {
                _city.PerimeterProperty.Value = value;
                OnPropertyChanged();
            }
        }
    }
}

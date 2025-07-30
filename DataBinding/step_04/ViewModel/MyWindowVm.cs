using Demo.DataBinding.step_04.Model;
using Demo.DataBinding.step_04.Utils;

namespace Demo.DataBinding.step_04.ViewModel
{
    public class MyWindowVm : NotifyPropertyChanged
    {
        protected readonly City _city;
        public MyWindowVm(City city) {
            _city = city;
            Perimeter = new WrapperOfModelProperty<float>(_city.PerimeterProperty);
        }

        public WrapperOfModelProperty<float> Perimeter { get; }
    }
    
    
}

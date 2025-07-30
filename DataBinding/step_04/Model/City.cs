using Demo.DataBinding.step_04.Utils;

namespace Demo.DataBinding.step_04.Model
{
    public class City 
    {
        public readonly ObservableModelProperty<float> PerimeterProperty = new();

        public City() {
            /*Task.Factory.StartNew(() => {
                while (true) {
                    Task.Delay(1000).Wait();
                    PerimeterProperty.Value += 1.1f;
                }
            });*/
        }
    }
}

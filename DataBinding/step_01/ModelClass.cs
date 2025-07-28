using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.DataBinding.step_01
{
    public class ModelClass : INotifyPropertyChanged
    {
        protected string _modelStringProperty;
        public string ModelStringProperty {
            get => _modelStringProperty;
            set {
                _modelStringProperty = value;
                OnPropertyChanged();
            }
        }

        public ModelClass() {
            ModelStringProperty = "Areopag Starting Ept";
            Task.Factory.StartNew(() => {
                                      while (true) {
                                          Task.Delay(2000).Wait();
                                          ModelStringProperty += " is running...";
                                      }
                                  });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
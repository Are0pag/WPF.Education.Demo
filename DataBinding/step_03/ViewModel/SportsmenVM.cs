using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.DataBinding.step_03
{
    public class SportsmenVM : INotifyPropertyChanged
    {
        protected Sportsmen _sportsmen { get; set; }

        public SportsmenVM(Sportsmen sportsmen) {
            _sportsmen = sportsmen;
            _sportsmen.PropertyChanged += (o, e) => OnPropertyChanged(e.PropertyName);
        }

        public string SportsmenID {
            get => _sportsmen.SportsmenID;
            set {
                if (_sportsmen.SportsmenID != value) {
                    _sportsmen.SportsmenID = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Achievements> Achievements {
            get => _sportsmen.Achievements;
            // ....
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
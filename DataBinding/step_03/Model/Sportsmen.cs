using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.DataBinding.step_03
{
    public class Sportsmen :INotifyPropertyChanged
    {
        protected string _sportsmenId;
        public string SportsmenID {
            get => _sportsmenId;
            set {
                _sportsmenId = value;
                OnPropertyChanged();
            }
        }
        
        public ObservableCollection<Achievements> Achievements { get; set; }

        public Sportsmen() {
            Achievements = [
                    new Achievements {EpicName = "DirtyDgo", EpicNumber = 777, Score = 3.4f},
                    new Achievements { EpicName = "Speedster", EpicNumber = 101, Score = 4.5f },
                    new Achievements { EpicName = "Marathon Master", EpicNumber = 202, Score = 5.0f },
                    new Achievements { EpicName = "Team Player", EpicNumber = 303, Score = 4.8f }
                ];

            Task.Factory.StartNew(() => {
                                      while (true) {
                                          Task.Delay(1000).Wait();
                                          SportsmenID += "0";
                                      }
                                  });
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Achievements
    {
        public string EpicName { get; set; }
        public int EpicNumber { get; set; }
        public float Score { get; set; }
    }
}
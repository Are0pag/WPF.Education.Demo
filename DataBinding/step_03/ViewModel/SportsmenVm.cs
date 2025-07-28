using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.DataBinding.step_03
{
    public class SportsmenVm : INotifyPropertyChanged
    {
        protected readonly Sportsmen _sportsmen;

        public SportsmenVm(Sportsmen sportsmen) {
            _sportsmen = sportsmen;
            _sportsmen.PropertyChanged += (_, e) => OnPropertyChanged(e.PropertyName);
            // Подписываемся на изменения коллекции
            _sportsmen.Achievements.CollectionChanged += (_, _) => {
                                                             OnPropertyChanged(nameof(Achievements));
                                                         };
        }

        public string SportsmenId {
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
            set {
                if (_sportsmen.Achievements != value) {
                    // Отписываемся от старой коллекции
                    _sportsmen.Achievements.CollectionChanged -= OnAchievementsCollectionChanged;
                    _sportsmen.Achievements = value;
                
                    // Подписываемся на новую коллекцию
                    _sportsmen.Achievements.CollectionChanged += OnAchievementsCollectionChanged;
                    OnPropertyChanged();
                }
            }
        }
        
        private void OnAchievementsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e) {
            OnPropertyChanged(nameof(Achievements));
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
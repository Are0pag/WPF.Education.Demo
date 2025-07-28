using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
            // Подписываемся на изменения коллекции
            _sportsmen.Achievements.CollectionChanged += (o, e) => {
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

        public ObservableCollection<Achievements> Achievements 
        {
            get => _sportsmen.Achievements;
            set {
                if (_sportsmen.Achievements != value) {
                    // Отписываемся от старой коллекции
                    if (_sportsmen.Achievements != null) {
                        _sportsmen.Achievements.CollectionChanged -= OnAchievementsCollectionChanged;
                    }
                    _sportsmen.Achievements = value;
                
                    // Подписываемся на новую коллекцию
                    if (_sportsmen.Achievements != null) {
                        _sportsmen.Achievements.CollectionChanged += OnAchievementsCollectionChanged;
                    }
                    OnPropertyChanged();
                }
            }
        }
        
        private void OnAchievementsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            OnPropertyChanged(nameof(Achievements));
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
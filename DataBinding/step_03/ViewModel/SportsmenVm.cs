using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.DataBinding.step_03
{
    public class SportsmenVm : INotifyPropertyChanged
    {
        public SportsmenVm(Sportsmen sportsmen) {
            _sportsmen = sportsmen;
            SubscribeOnModelEvent();
            SubscribeOnCollectionChanged();
        }


        #region CollectionVm

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

        private void SubscribeOnCollectionChanged() {
            _sportsmen.Achievements.CollectionChanged += (_, _) => {
                                                             OnPropertyChanged(nameof(Achievements));
                                                         };
        }

        private void OnAchievementsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e) {
            OnPropertyChanged(nameof(Achievements));
        }

        #endregion

        #region PropertyVm

        protected readonly Sportsmen _sportsmen;
        public string SportsmenId {
            get => _sportsmen.SportsmenID;
            set {
                if (_sportsmen.SportsmenID != value) {
                    _sportsmen.SportsmenID = value;
                    OnPropertyChanged();
                }
            }
        }

        private void SubscribeOnModelEvent() {
            _sportsmen.PropertyChanged += (_, e) => OnPropertyChanged(e.PropertyName);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        
    }
}
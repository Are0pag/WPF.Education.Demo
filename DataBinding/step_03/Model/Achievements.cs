using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.DataBinding.step_03
{
    public class Achievements : INotifyPropertyChanged
    {
        private string _epicName;
        private int _epicNumber;
        private float _score;

        public string EpicName
        {
            get => _epicName;
            set
            {
                if (_epicName != value)
                {
                    _epicName = value;
                    OnPropertyChanged();
                }
            }
        }

        public int EpicNumber
        {
            get => _epicNumber;
            set
            {
                if (_epicNumber != value)
                {
                    _epicNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public float Score
        {
            get => _score;
            set
            {
                if (!_score.Equals(value))
                {
                    _score = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
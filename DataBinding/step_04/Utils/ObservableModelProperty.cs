using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.DataBinding.step_04.Utils;

public class ObservableModelProperty<TPropType> : NotifyPropertyChanged 
{
    private TPropType _value;
    public TPropType Value {
        get => _value;
        set {
            _value = value;
            OnPropertyChanged();
        }
    }
}

public abstract class NotifyPropertyChanged : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
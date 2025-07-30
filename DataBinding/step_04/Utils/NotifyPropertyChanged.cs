using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.DataBinding.step_04.Utils;

public abstract class NotifyPropertyChanged : INotifyPropertyChanged 
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        Console.WriteLine($"PropertyChanged: {propertyName}");
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
using Utils.WPF;

namespace Demo;

public class CompositeObject : NotifyPropertyChanged
{
    protected string _otchestvo;
    public string Otchecnvo {
        get => _otchestvo;
        set {
            _otchestvo = value;
            OnPropertyChanged();
        }
    }
    
    public StringParams StringParams { get; set; }
    public ObjectsParams ObjectsParams { get; set; }
}

public class StringParams : NotifyPropertyChanged
{
    protected string _name;
    protected string _fullName;
    public string Name {
        get => _name;
        set {
            _name = value;
            OnPropertyChanged();
        }
    }
    public string FullName {
        get => _fullName;
        set {
            _fullName = value;
            OnPropertyChanged();
        }
    }
}

public class ObjectsParams : NotifyPropertyChanged
{
    public DescriptiveParams Descriptive { get; set; }
}

public class DescriptiveParams : NotifyPropertyChanged
{
    protected string _description;
    protected string _comment;
    public string Description {
        get => _description;
        set {
            _description = value;
            OnPropertyChanged();
        }
    }
    public string Comment {
        get => _comment;
        set {
            _comment = value;
            OnPropertyChanged();
        }
    }
}

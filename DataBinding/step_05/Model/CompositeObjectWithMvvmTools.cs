using Utils.WPF;

namespace Demo;

public class CompositeObjectWithMvvmTools
{
    public ObservableModelProperty<string> Iq { get; set; } = new();
    public ObservableModelProperty<int> Age { get; set; } = new();
    public Health Health { get; set; }

    public CompositeObjectWithMvvmTools(string iq, int age, Health health) {
        Iq.Value = iq;
        Age.Value = age;
        Health = health;
    }
}

public class Health
{
    public ObservableModelProperty<string> HealthStatus { get; set; } = new();
    public ObservableModelProperty<int> Mass { get; set; } = new();

    public Health(string healthStatus, int mass) {
        HealthStatus.Value = healthStatus;
        Mass.Value = mass;
    }
}
using System.Collections.ObjectModel;
using Demo.DataBinding.step_03;

namespace Demo;

public class FullGridWindowVm
{
    public ObservableCollection<CompositeObject> CompositeObjects { get; set; } = new();
    public ObservableCollection<CompositeObjectWithMvvmTools> CompositeObjectsWithMvvmTools { get; set; } = new();

    public FullGridWindowVm() {
        AddCompositeObjectCommand = new RelayCommand(CreateCommand);
    }
    public RelayCommand AddCompositeObjectCommand { get; set; }
    
    
    
    public void CreateCommand(object? value) {
        AddToCompositeObjectsCollection();
        CompositeObjectsWithMvvmTools.Add(new CompositeObjectWithMvvmTools(iq: "тупой", age: 22, new Health(healthStatus: "жирный", 125)));
        CompositeObjectsWithMvvmTools.Add(new CompositeObjectWithMvvmTools(iq: "дебил", age: 34, new Health(healthStatus: "пассажирный", 277)));
        CompositeObjectsWithMvvmTools.Add(new CompositeObjectWithMvvmTools(iq: "genious", age: 4, new Health(healthStatus: "доска", 11)));
    }

    private void AddToCompositeObjectsCollection() {
        CompositeObjects.Add(new CompositeObject() {
            Otchecnvo = "Ivanova",
            StringParams = new StringParams() {Name = "Alice", FullName = "AliceWonderland"},
            ObjectsParams = new ObjectsParams() {
                Descriptive = new DescriptiveParams() {Description = "Alice is good qirl", Comment = "Настоящая соска"}
            }
        });
        CompositeObjects.Add(new CompositeObject() {
            Otchecnvo = "Pomidorov",
            StringParams = new StringParams() {Name = "Bob", FullName = "BobBuilder"},
            ObjectsParams = new ObjectsParams() {
                Descriptive = new DescriptiveParams() {Description = "Professional constructor", Comment = "Мастер на все руки"}
            }
        });
        CompositeObjects.Add(new CompositeObject() {
            Otchecnvo = "Rediskin",
            StringParams = new StringParams() {Name = "Charlie", FullName = "CharlieChocolate"},
            ObjectsParams = new ObjectsParams() {
                Descriptive = new DescriptiveParams() {Description = "Chocolate factory owner", Comment = "Сладкий предприниматель"}
            }
        });
    }
}

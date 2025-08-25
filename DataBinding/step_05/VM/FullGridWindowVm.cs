using System.Collections.ObjectModel;
using Demo.DataBinding.step_03;

namespace Demo;

public class FullGridWindowVm
{
    public ObservableCollection<CompositeObject> CompositeObjects { get; set; } = new ObservableCollection<CompositeObject>();

    public FullGridWindowVm() {
        AddCompositeObjectCommand = new RelayCommand(CreateCommand);
    }
    public RelayCommand AddCompositeObjectCommand { get; set; }
    
    public void CreateCommand(object? value) {
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

using System.Collections.ObjectModel;

namespace Demo.DataBinding.step_02
{
    public class ModelClass
    {
        public ObservableCollection<Person> People { get; set; }

        public ModelClass() {
            People = [
                new Person { Name = "Иван", Age = 30, Email = "ivan@example.com" },
                new Person { Name = "Мария", Age = 25, Email = "maria@example.com" },
                new Person { Name = "Петр", Age = 40, Email = "petr@example.com" }
            ];
        }
    }
}
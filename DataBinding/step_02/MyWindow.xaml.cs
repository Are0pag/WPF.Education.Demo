using System.Windows;

namespace Demo.DataBinding.step_02
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        // Сохраняем ссылку также для других сущностей
        public MyWindow(ModelClass context)
        {
            InitializeComponent();
            DataContext = context;
        }
    }
}

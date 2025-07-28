using System.Windows;

namespace Demo.DataBinding.step_01
{
    /// <summary>
    /// Логика взаимодействия для MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        public MyWindow()
        {
            InitializeComponent();
            // better way is to set this in .xaml
            // DataContext = new ModelClass();
        }
    }
}

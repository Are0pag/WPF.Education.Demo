using System.Windows;

namespace Demo.DataBinding.step_03
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        public MyWindow(SportsmenVM sportsmenVM) {
            InitializeComponent();
            DataContext = sportsmenVM;
        }
    }
}

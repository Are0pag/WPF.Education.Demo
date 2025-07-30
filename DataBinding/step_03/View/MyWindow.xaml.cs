using System.Windows;

namespace Demo.DataBinding.step_03
{
    public partial class MyWindow : Window
    {
        public MyWindow(SportsmenVm sportsmenVM) {
            InitializeComponent();
            DataContext = sportsmenVM;
        }
    }
}

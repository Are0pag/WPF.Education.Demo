using System.Windows;
using Demo.DataBinding.step_04.ViewModel;

namespace Demo.DataBinding.step_04.View
{
    public partial class MyWindow : Window
    {
        public MyWindow(MyWindowVm viewModel) {
            InitializeComponent();
            DataContext = viewModel;            
        }
    }
}

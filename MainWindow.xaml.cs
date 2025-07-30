using System.Windows;
using Current = Demo.DataBinding.step_04;

namespace Demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Current.View.MyWindow(
                                      new Current.ViewModel.MyWindowVm(
                                                                       new Current.Model.City()
                                                                       )
                                      ).Show();
            Close();
        }
    }
}
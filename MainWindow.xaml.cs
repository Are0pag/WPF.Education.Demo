using System.Windows;
using Demo.DataBinding.step_02;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new MyWindow(new ModelClass()).Show();
            Close();
        }
    }
}
using System.Windows;
using Demo.DataBinding.step_03;

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
            new MyWindow(new SportsmenVM(new Sportsmen {SportsmenID = "tuy 20.4445"})).Show();
            Close();
        }
    }
}
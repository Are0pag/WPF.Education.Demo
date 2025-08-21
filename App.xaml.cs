using Demo.DataBinding.step_03;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            new MyWindow(new SportsmenVm(new Sportsmen { SportsmenID = "tuy 20.4445" })).Show();
        }
    }

}

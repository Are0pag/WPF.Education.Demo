using System.Windows;
using Demo.DataBinding.step_05.View;

namespace Demo;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e) {
        base.OnStartup(e);
        new GridOfCompositeObjectsWindow(new FullGridWindowVm()).Show();
    }
}
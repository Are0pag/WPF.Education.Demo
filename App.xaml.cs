using System.Windows;
using Demo.DataBinding.step_05.View;
using Microsoft.Extensions.DependencyInjection;

namespace Demo;

public partial class App : Application
{

    
    protected override void OnStartup(StartupEventArgs e) {
        base.OnStartup(e);
        new GridOfCompositeObjectsWindow(new FullGridWindowVm()).Show();
        
        var services = new ServiceCollection();
        services.AddSingleton<FullGridWindowVm>();
        var serviceProvider = services.BuildServiceProvider();
    }
}
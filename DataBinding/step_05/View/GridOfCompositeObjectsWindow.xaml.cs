using System.Windows;

namespace Demo.DataBinding.step_05.View;

public partial class GridOfCompositeObjectsWindow : Window
{
    public GridOfCompositeObjectsWindow(FullGridWindowVm fullGridWindowVm) {
        InitializeComponent();
        MyDataGrid.Items.Clear();
        DataContext = fullGridWindowVm;
    }
}
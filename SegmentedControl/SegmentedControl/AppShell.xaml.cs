using SegmentedControl.Views;

namespace SegmentedControl;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        AddRegisteringRoute();
    }
    
    private void AddRegisteringRoute()
    {
        Routing.RegisterRoute(nameof(GesturePage), typeof(GesturePage));
        Routing.RegisterRoute(nameof(SegmentedControlPage), typeof(SegmentedControlPage));
        Routing.RegisterRoute(nameof(SwipePage), typeof(SwipePage));
    }
}
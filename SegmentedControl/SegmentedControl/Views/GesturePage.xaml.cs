using SegmentedControl.ViewModels;

namespace SegmentedControl.Views;

public partial class GesturePage : ContentPage
{
    private double _transX;
    private double _transY;
    
    public GesturePage(GesturePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            case GestureStatus.Started:
                break;
            
            case GestureStatus.Running:
                double boundsX = ThisGesturePage.Width;
                double boundsY = ThisGesturePage.Height;
                GestureContainer.TranslationX = Math.Clamp(_transX + e.TotalX, -boundsX, boundsX);
                GestureContainer.TranslationY = Math.Clamp(_transY + e.TotalY, -boundsY, boundsY);
                break;
            
            case GestureStatus.Canceled:
            case GestureStatus.Completed:
                _transX = GestureContainer.TranslationX;
                _transY = GestureContainer.TranslationY;
                break;
            
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
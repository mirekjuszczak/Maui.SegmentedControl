using SegmentedControl.ViewModels;

namespace SegmentedControl.Views;

public partial class GesturePage : ContentPage
{
    private double _transX;
    private double _transY;
    private double _startPosisionX;
    private double _startPositionY;
    
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
                _startPosisionX = e.TotalX;
                _startPositionY = e.TotalY;
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

    private void Button_OnBackToStartClicked(object sender, EventArgs e)
    {
        GestureContainer.TranslationX = _startPosisionX;
        GestureContainer.TranslationY = _startPositionY;
    }
}
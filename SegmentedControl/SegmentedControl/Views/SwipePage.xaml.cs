using SegmentedControl.ViewModels;

namespace SegmentedControl.Views;

public partial class SwipePage : ContentPage
{
    public SwipePage(SwipePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
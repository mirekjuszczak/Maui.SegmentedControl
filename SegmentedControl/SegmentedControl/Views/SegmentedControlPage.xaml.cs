using SegmentedControl.ViewModels;

namespace SegmentedControl.Views;

public partial class SegmentedControlPage : ContentPage
{
    public SegmentedControlPage(SegmentedControlPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
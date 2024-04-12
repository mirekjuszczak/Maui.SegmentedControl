using SegmentedControl.Services;
using SegmentedControl.Views;

namespace SegmentedControl.ViewModels;

public class MainPageViewModel
{
    private readonly INavigationService _navigationService;
    public Command OnGoToGestureCommand { get; }
    public Command OnGoToSegmentedControlCommand { get; }
    public Command OnGoToSwipePageCommand { get; }

    public MainPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;

        OnGoToGestureCommand = new Command(async () => await RunGoToGesture());
        OnGoToSegmentedControlCommand = new Command(async () => await RunGoToSegmentedControl());
        OnGoToSwipePageCommand = new Command(async () => await RunGoToSwipePage());
    }

    private async Task RunGoToGesture() =>
        await _navigationService.NavigateToAsync(nameof(GesturePage));

    private async Task RunGoToSegmentedControl() =>
        await _navigationService.NavigateToAsync(nameof(SegmentedControlPage));

    private async Task RunGoToSwipePage() =>
        await _navigationService.NavigateToAsync(nameof(SwipePage));
}
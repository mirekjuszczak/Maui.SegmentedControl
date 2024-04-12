﻿using SegmentedControl.ViewModels;

namespace SegmentedControl.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    
}
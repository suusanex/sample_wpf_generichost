using System.Windows.Input;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using WPFTemplateStudio.Contracts.Services;

namespace WPFTemplateStudio.ViewModels;

public class ShellViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;
    public RelayCommand GoBackCommand { get; }

    public ICommand LoadedCommand { get; }

    public ICommand UnloadedCommand { get; }


    public ShellViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        GoBackCommand = new RelayCommand(OnGoBack, CanGoBack);
        LoadedCommand = new RelayCommand(OnLoaded);
        UnloadedCommand = new RelayCommand(OnUnloaded);
    }

    private void OnLoaded()
    {
        _navigationService.Navigated += OnNavigated;
    }

    private void OnUnloaded()
    {
        _navigationService.Navigated -= OnNavigated;
    }

    private bool CanGoBack()
        => _navigationService.CanGoBack;

    private void OnGoBack()
        => _navigationService.GoBack();

    private void OnNavigated(object? sender, string? viewModelName)
        => GoBackCommand.NotifyCanExecuteChanged();
}

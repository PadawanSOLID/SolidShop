using System.Collections.ObjectModel;
using System.Configuration;
using CommunityToolkit.Mvvm.ComponentModel;
using SolidShop.WPF.Views;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace SolidShop.WPF.ViewModels
{
    public partial class ShellViewModel : ObservableObject
    {
        public ShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ShellViewModel() { }

        private INavigationService _navigationService;

        [ObservableProperty]
        string title = "Input Title Here";

        [ObservableProperty]
        ObservableCollection<NavigationViewItem> menuItems = [
           new("Home", SymbolRegular.AppGeneric24, typeof(DashboardView))
            ];

        [ObservableProperty]
        ObservableCollection<NavigationViewItem> footItems = [
            new NavigationViewItem("Settings", SymbolRegular.Settings24, typeof(SettingsView))
            ];
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using Wpf.Ui.Abstractions.Controls;

namespace SolidShop.WPF.ViewModels
{
    public partial class SettingsViewModel : ObservableObject, INavigationAware
    {
        public SettingsViewModel()
        {

        }

        public async Task OnNavigatedFromAsync()
        {
        }

        public async Task OnNavigatedToAsync()
        {
        }
    }
}

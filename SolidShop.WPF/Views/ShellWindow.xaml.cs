using System.Windows;
using SolidShop.WPF.ViewModels;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace SolidShop.WPF.Views
{
    public partial class ShellWindow : FluentWindow
    {
        public ShellWindow(ShellViewModel vm, INavigationService navigationService)
        {
            InitializeComponent();
            navigationService.SetNavigationControl(navi);
            DataContext = vm;
        }
    }
}
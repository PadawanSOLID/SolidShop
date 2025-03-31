using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Ui.Abstractions;

namespace SolidShop.WPF.Services
{
    public class NavigationViewPageProvider(IServiceProvider serviceProvider)
        : INavigationViewPageProvider
    {
        /// <inheritdoc />
        public object? GetPage(Type pageType)
        {
            return serviceProvider.GetService(pageType);
        }
    }
}

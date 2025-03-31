using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.Drawing;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using Wpf.Ui.Abstractions.Controls;

namespace SolidShop.WPF.ViewModels
{
    public partial class DashboardViewModel : ObservableObject, INavigationAware
    {
        [ObservableProperty]
        ISeries[] skillSeries;

        [ObservableProperty]
        ISeries[] activitySeries;

        [ObservableProperty]
        PolarAxis[] skillAxis;

        public DashboardViewModel()
        {
#if DEBUG
            ActivitySeries = [
                new LineSeries<double>
                {
                    Values=[1,2,3,4,5,6,7,8,9,10],
                    Name="Activities"
                }
                ];
            SkillSeries = [
                new PolarLineSeries<int>{
                    Values=[5,5,4,3,3],
                    Name="Skills"
                }
                ];
            SkillAxis= [
                 new PolarAxis
                 {
                    LabelsRotation = LiveCharts.TangentAngle,
                    LabelsBackground = LvcColor.Empty,
                    LabelsPaint = new SolidColorPaint(SKColors.White),
                    Labels = ["WPF","C#","Webapi","Vue","React"]
                }];
#endif
        }



        public async Task OnNavigatedFromAsync()
        {
        }

        public async Task OnNavigatedToAsync()
        {
        }
    }
}

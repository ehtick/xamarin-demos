#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Core;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Xamarin.Forms;

namespace SampleBrowser.SfChart
{
	public partial class DoughnutChart : SampleView
	{
		public DoughnutChart()
		{
			InitializeComponent();          

            if (Device.RuntimePlatform == Device.macOS || Device.RuntimePlatform == Device.UWP || Device.RuntimePlatform == Device.WPF)
            {
                Chart.Legend.OverflowMode = ChartLegendOverflowMode.Scroll;
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if ((Device.RuntimePlatform == Device.Android || Device.RuntimePlatform == Device.iOS))
            {
                if (height > 0 && width > 0)
                {
                    if (height > width)
                    {
						doughnutSeries.CenterView = stack;
                        Chart.Legend.OverflowMode = ChartLegendOverflowMode.Wrap;
                        Chart.Legend.DockPosition = LegendPlacement.Bottom; 
                    }
                    else
                    {
                        doughnutSeries.CenterView = null;
                        Chart.Legend.DockPosition = LegendPlacement.Right;
                        Chart.Legend.OverflowMode = ChartLegendOverflowMode.Scroll;
                    }
                }
            }
        }
    }
}

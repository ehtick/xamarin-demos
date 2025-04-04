#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.SfChart.iOS;

#if __UNIFIED__
using Foundation;
using UIKit;
using CoreGraphics;

#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using nint	 = System.Int32;
using nuint	 = System.Int32;
using CGSize = System.Drawing.SizeF;
using CGRect = System.Drawing.RectangleF;
#endif
namespace SampleBrowser
{
	public class StackingColumn100:SampleView
	{
		public StackingColumn100 ()
		{
			SFChart chart 							= new SFChart ();
			chart.Title.Text						= new NSString("Gross Domestic Product Growth");
			chart.ColorModel.Palette = SFChartColorPalette.Natural;

			SFCategoryAxis primaryAxis 				= new SFCategoryAxis ();
			primaryAxis.ShowMajorGridLines          = false;
			primaryAxis.EdgeLabelsDrawingMode       = SFChartAxisEdgeLabelsDrawingMode.Shift;
			primaryAxis.LabelPlacement				= SFChartLabelPlacement.BetweenTicks;
			chart.PrimaryAxis 						= primaryAxis;
			chart.SecondaryAxis					 	= new SFNumericalAxis ();
			chart.SecondaryAxis.Title.Text			= new NSString ("GDP(%) Per Annum");
			chart.SecondaryAxis.Interval = new NSNumber(10);
            chart.SecondaryAxis.Minimum = new NSNumber(0);
            chart.SecondaryAxis.Maximum = new NSNumber(100);
			chart.SecondaryAxis.AxisLineStyle.LineWidth = 0;
            chart.SecondaryAxis.MajorTickStyle.LineSize = 0;
			NSNumberFormatter formatter = new NSNumberFormatter();
            formatter.PositiveSuffix = "%";
            chart.SecondaryAxis.LabelStyle.LabelFormatter = formatter;
			ChartViewModel dataModel				= new ChartViewModel ();

			SFStackingColumn100Series series1 = new SFStackingColumn100Series();
			series1.ItemsSource = dataModel.StackedColumn100Data1;
			series1.XBindingPath = "XValue";
			series1.YBindingPath = "YValue";
			series1.EnableTooltip = true;
			series1.Label = "UK";
			series1.EnableAnimation = true;
			chart.Series.Add(series1);

			SFStackingColumn100Series series2 = new SFStackingColumn100Series();
			series2.ItemsSource = dataModel.StackedColumn100Data2;
			series2.XBindingPath = "XValue";
			series2.YBindingPath = "YValue";
			series2.EnableTooltip = true;
			series2.Label = "Germany";
			series2.EnableAnimation = true;
			chart.Series.Add(series2);

			SFStackingColumn100Series series3 = new SFStackingColumn100Series();
			series3.ItemsSource = dataModel.StackedColumn100Data3;
			series3.XBindingPath = "XValue";
			series3.YBindingPath = "YValue";
			series3.EnableTooltip = true;
			series3.Label = "France";
			series3.EnableAnimation = true;
			chart.Series.Add(series3);

			SFStackingColumn100Series series4 = new SFStackingColumn100Series();
			series4.ItemsSource = dataModel.StackedColumn100Data4;
			series4.XBindingPath = "XValue";
			series4.YBindingPath = "YValue";
			series4.EnableTooltip = true;
			series4.Label = "Italy";
			series4.EnableAnimation = true;
			chart.Series.Add(series4);

			chart.Legend.Visible 					= true;
			chart.Legend.ToggleSeriesVisibility = true;
            chart.Legend.IconWidth = 14;
            chart.Legend.IconHeight = 14;
			chart.Legend.DockPosition 				= SFChartLegendPosition.Bottom;
         
			this.AddSubview(chart);
		}

		public override void LayoutSubviews ()
		{
			foreach (var view in this.Subviews) {
				view.Frame = Bounds;
			}
			base.LayoutSubviews ();
		}
	}

}
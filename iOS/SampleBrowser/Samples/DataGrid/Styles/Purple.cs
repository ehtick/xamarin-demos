#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.SfDataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UIKit;

namespace SampleBrowser
{
    public class Purple:DataGridStyle
    {
        public Purple()
        {
        }
        public override UIColor GetHeaderBackgroundColor()
        {
            return UIColor.FromRGB(131, 83, 139);
        }

        public override UIColor GetHeaderForegroundColor()
        {
            return UIColor.FromRGB(255, 255, 255);
        }

        public override UIColor GetAlternatingRowBackgroundColor()
        {
            return UIColor.FromRGB(237, 231, 246);
        }

        public override UIColor GetSelectionBackgroundColor()
        {
            return UIColor.FromRGB(149, 117, 205);
        }

        public override UIColor GetSelectionForegroundColor()
        {
            return UIColor.FromRGB(255, 255, 255);
        }

        public override UIColor GetCaptionSummaryRowBackgroundColor()
        {
            return UIColor.FromRGB(224, 224, 224);
        }

        public override UIColor GetCaptionSummaryRowForegroundColor()
        {
            return UIColor.FromRGB(51, 51, 51);
        }

        public override UIColor GetBorderColor()
        {
            return UIColor.FromRGB(180, 180, 180);
        }
    }
}
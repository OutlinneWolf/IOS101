﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CoreGraphics;

namespace TipCalculator
{
    public class MyViewController : UIViewController
    {
        public MyViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var totalAmount = new UITextField()
            {
                Frame = new CGRect(20, 28, View.Bounds.Width - 40, 35),
                KeyboardType = UIKeyboardType.DecimalPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter Total Amount",
            };
    
            var calcButton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CGRect(20, 71, View.Bounds.Width - 40, 45),
                BackgroundColor = UIColor.FromRGB(0, 0.5f, 0),
            };
            calcButton.SetTitle("Calculate", UIControlState.Normal);

            var resultLabel = new UILabel()
            {
                Frame = new CGRect(20, 124, View.Bounds.Width - 40, 40),
                TextColor = UIColor.Blue,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(24),
                Text = "Tip is $0.00",
            };

            View.AddSubviews(totalAmount, calcButton, resultLabel);

            this.View.BackgroundColor = UIColor.Yellow;
        }
    }


}
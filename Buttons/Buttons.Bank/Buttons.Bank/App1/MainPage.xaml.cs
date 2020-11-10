using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using Banking;
using Banking.XF;

public class CodeButtonClickPage : BankingFunctions
{
    public CodeButtonClickPage ()
    {
        Title = "Code Button Click";

        Label label = new Label
        {
            Text = "Click the Button below",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.Center
        };

        Button button = new Button
        {
            Text = "Click to Rotate Text!",
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.Center
        };
        button.Clicked += async (sender, args) => await label.Deposit;

        Content = new StackLayout
        {
            Children =
            {
                label,
                button
            }
        };
    }
}
 public CodeButtonClickPage ()
    {
        Title = "Code Button Click";

        Label label = new Label
        {
            Text = "Click the Button below",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.Center
        };

        Button button = new Button
        {
            Text = "Click to Rotate Text!",
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.Center
        };
        button.Clicked += async (sender, args) => await label.Withdraw;

        Content = new StackLayout
        {
            Children =
            {
                label,
                button
            }
        };
    }
}
 public CodeButtonClickPage ()
    {
        Title = "Code Button Click";

        Label label = new Label
        {
            Text = "Click the Button below",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.Center
        };

        Button button = new Button
        {
            Text = "Click to Rotate Text!",
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.Center
        };
        button.Clicked += async (sender, args) => await label.Transactions;

        Content = new StackLayout
        {
            Children =
            {
                label,
                button
            }
        };
    }
}
public class FrameLayout : cardFrame
{
   Frame cardFrame = new Frame
   {
      BorderColor = Color.Blue,
       CornerRadius = 5,
       Padding = 8,
      Content = new StackLayout
   {
      Children =
         {
             new Label
              {
                Text = "Bank of Euan",
                FontSize = Device.GetNamedSize(NamedSize.Medium. typeof(Label)),
                FontAttributes = FontAttributes.Bold
                },
               new BoxView
               {
                Color = Color.Blue,
                HeightRequest = 2,
                HorizontalOptions = LayoutOptions.Fill
                },
}
}
﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sharpnado.Presentation.Forms.CustomViews.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomTabItem : TabItem
    {
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(
            nameof(IconImageSource),
            typeof(string),
            typeof(BottomTabItem));

        public static readonly BindableProperty IconSizeProperty = BindableProperty.Create(
            nameof(IconSize),
            typeof(double),
            typeof(BottomTabItem),
            defaultValue: (double)30);

        public static readonly BindableProperty UnselectedIconColorProperty = BindableProperty.Create(
            nameof(UnselectedIconColor),
            typeof(Color),
            typeof(BottomTabItem));

        public BottomTabItem()
        {
            LabelSize = 12;

            InitializeComponent();
        }

        public string IconImageSource
        {
            get => (string)GetValue(IconImageSourceProperty);
            set => SetValue(IconImageSourceProperty, value);
        }

        public double IconSize
        {
            get => (double)GetValue(IconSizeProperty);
            set => SetValue(IconSizeProperty, value);
        }

        public Color UnselectedIconColor
        {
            get => (Color)GetValue(UnselectedIconColorProperty);
            set => SetValue(UnselectedIconColorProperty, value);
        }
    }
}
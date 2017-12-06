using Windows.UI.Xaml.Controls;
using System;
using System.Numerics;
using Continuity.Extensions;

namespace XamlBrewer.Uwp.FluentButtonFlyoutSample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            TheGrid.EnableFluidVisibilityAnimation(centerPoint: new Vector3(0.0f, 40.0f, 0.0f), showFromScale: 0.2f, hideToScale: 0.2f, showDuration: 400, hideDuration: 400);
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            TheToggle.IsChecked = true;
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            TheToggle.IsChecked = false;
        }
    }
}

using Continuity.Extensions;
using System.Numerics;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.FluentButtonFlyoutSample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            TheGrid.EnableFluidVisibilityAnimation(
                centerPoint: new Vector3(0.0f, 40.0f, 0.0f), 
                showFromScale: 0.2f, 
                hideToScale: 0.2f, 
                showDuration: 400, 
                hideDuration: 400);
        }

        private void OpenButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            TheToggle.IsChecked = true;
        }

        private void CloseButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            TheToggle.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ThePopup.IsLightDismissEnabled = true;
            TheToggle.IsChecked = false;
        }

        private void CheckBox_Unchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ThePopup.IsLightDismissEnabled = false;
        }
    }
}

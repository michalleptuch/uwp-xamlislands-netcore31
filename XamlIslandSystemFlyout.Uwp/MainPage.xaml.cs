using Windows.UI.Xaml.Controls;

namespace XamlIslandSystemFlyout.Uwp
{
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      InitializeComponent();

      SharedShadow.Receivers.Add(ShadowGrid);
    }
  }
}
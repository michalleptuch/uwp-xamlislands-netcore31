using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamlIslandsCore31.Uwp
{
  public sealed partial class XamlUserControl : UserControl
  {
    public event Action CloseAppRequested;

    public XamlUserControl()
    {
      InitializeComponent();
    }

    private void CloseApp(object sender, RoutedEventArgs e)
    {
      CloseAppRequested?.Invoke();
    }
  }
}
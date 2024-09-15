using System;
using System.Windows;

using XamlIslandsCore31.Uwp;

namespace XamlIslandsCore31.Wpf
{
  public partial class MainWindow : Window
  {
    private readonly XamlUserControl _xamlUserControl;

    public MainWindow()
    {
      InitializeComponent();

      _xamlUserControl = new XamlUserControl();
      _xamlUserControl.CloseAppRequested += App.Current.Shutdown;
    }

    private void OnSourceInitialized(object sender, EventArgs e)
    {
      ((Windows.UI.Xaml.Window.Current as object) as IWindowPrivate).TransparentBackground = true;
      XamlHost.Child = _xamlUserControl;
    }
  }
}
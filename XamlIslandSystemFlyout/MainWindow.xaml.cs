using System;
using System.Windows;

namespace XamlIslandSystemFlyout
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void OnChildChanged(object sender, EventArgs e)
    {
      var xamlWindow = (Windows.UI.Xaml.Window.Current as object) as IWindowPrivate;
      xamlWindow.TransparentBackground = true;
    }
  }
}
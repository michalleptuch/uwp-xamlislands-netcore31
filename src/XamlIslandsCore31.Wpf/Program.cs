using System;

namespace XamlIslandsCore31.Wpf
{
  internal class Program
  {
    [STAThread]
    public static void Main()
    {
      using (var xamlApp = new Uwp.App())
      {
        var app = new App();
        app.InitializeComponent();
        app.Run();
      }
    }
  }
}
using System;

namespace XamlIslandSystemFlyout
{
  internal class Program
  {
    [STAThread]
    public static void Main()
    {
      var xamlApp = new Uwp.App();

      using (xamlApp)
      {
        new App().Run();
      }
    }
  }
}
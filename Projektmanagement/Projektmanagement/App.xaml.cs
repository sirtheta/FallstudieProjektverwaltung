using System.Windows;
using Projektmanagement.ViewModels;

namespace Projektmanagement
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      HomeViewModel _HomeViewModel = HomeViewModel.GetInstance;

      MainWindow = new MainWindow() {
        DataContext = new MainViewModel(_HomeViewModel)
      };

      MainWindow.Show();

      base.OnStartup(e);
    }
  }
}

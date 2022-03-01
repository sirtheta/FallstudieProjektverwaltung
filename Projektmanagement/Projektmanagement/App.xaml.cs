using Projektmanagement.Commands;
using Projektmanagement.Services;
using Projektmanagement.Stores;
using Projektmanagement.ViewModels;
using System.Windows;

namespace Projektmanagement
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private readonly NavigationStore _navigationStore;
    private readonly ModalNavigationStore _modalNavigationStore;

    public App()
    {
      _navigationStore = new NavigationStore();
      _modalNavigationStore = new ModalNavigationStore();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
      INavigationService navigationService = CreateMainViewNavigationService();
      navigationService.Navigate();

      MainWindow = new MainWindow() {
        DataContext = new MainViewModel(_navigationStore, _modalNavigationStore)
      };
      MainWindow.Show();

      base.OnStartup(e);
    }

    private INavigationService CreateMainViewNavigationService()
    {
      return new NavigationService<HomeViewModel>(_navigationStore, CreateHomeViewModel);
    }

    private HomeViewModel CreateHomeViewModel()
    {
      return new HomeViewModel();
    }
  }
}

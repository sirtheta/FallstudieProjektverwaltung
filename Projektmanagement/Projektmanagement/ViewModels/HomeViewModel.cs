namespace Projektmanagement.ViewModels
{
  internal class HomeViewModel : BaseViewModel
  {

    private static HomeViewModel? instance = null;
    private static readonly object padlock = new();

    protected HomeViewModel()
    {
    }

    public static HomeViewModel GetInstance {
      get {
        lock (padlock) {
          if (instance == null) {
            instance = new HomeViewModel();
          }
          return instance;
        }
      }
    }
  }
}

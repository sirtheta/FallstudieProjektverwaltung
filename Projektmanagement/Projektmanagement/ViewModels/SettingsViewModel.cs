using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektmanagement.ViewModels
{
  internal class SettingsViewModel : BaseViewModel
  {
    #region Singleton
    // returns thread safe singleton
    private static SettingsViewModel? instance = null;
    private readonly static object padlock = new();

    protected SettingsViewModel()
    {
    }

    public static SettingsViewModel GetInstance {
      get {
        lock (padlock) {
          if (instance == null) {
            instance = new SettingsViewModel();
          }
          return instance;
        }
      }
    }
    #endregion
  }
}

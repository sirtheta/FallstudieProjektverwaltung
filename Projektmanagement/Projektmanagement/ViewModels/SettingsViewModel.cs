using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektmanagement.ViewModels
{
  internal class SettingsViewModel : BaseViewModel
  {
    private static SettingsViewModel? instance = null;
    private static readonly object padlock = new();

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
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektmanagement.ViewModels
{
  internal class PhaseViewModel : BaseViewModel
  {
    #region Singleton
    private static PhaseViewModel? instance = null;
    private readonly static object padlock = new();

    /// <summary>
    /// returns instance of class PhaseViewModel
    /// </summary>
    public static PhaseViewModel GetInstance {
      get {
        lock (padlock) {
          if (instance == null) {
            instance = new PhaseViewModel();
          }
          return instance;
        }
      }
    }
    #endregion
  }
}

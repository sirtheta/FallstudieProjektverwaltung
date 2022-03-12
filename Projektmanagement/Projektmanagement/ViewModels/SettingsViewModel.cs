using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Projektmanagement.Commands;

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

    private Visibility visibilityNewModell = Visibility.Hidden;
    private Visibility visibilityNewEmployee = Visibility.Hidden;

    public Visibility VisibilityNewProcessModel {
      get {
        return visibilityNewModell;
      }

      set {
        visibilityNewModell = value;
        OnPropertyChanged();
      }
    }

    public Visibility VisibilityNewEmployee {
      get {
        return visibilityNewEmployee;
      }

      set {
        visibilityNewEmployee = value;
        OnPropertyChanged();
      }
    }

    public ICommand BtnNewProcessModel {
      get {
        return new RelayCommand<object>(ExecuteBtnNewProcessModel);
      }
    }


    public ICommand BtnNewEmployee {
      get {
        return new RelayCommand<object>(ExecuteBtnNewEmployee);
      }
    }

    private void ExecuteBtnNewProcessModel(object Parameter)
    {
      VisibilityNewEmployee = Visibility.Hidden;
      VisibilityNewProcessModel = Visibility.Visible;
    }

    private void ExecuteBtnNewEmployee(object Parameter)
    {
      VisibilityNewProcessModel = Visibility.Hidden;
      VisibilityNewEmployee = Visibility.Visible;
    }
  }
}

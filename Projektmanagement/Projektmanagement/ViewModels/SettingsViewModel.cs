using System.Windows;
using System.Windows.Input;
using Projektmanagement.Commands;

namespace Projektmanagement.ViewModels
{
  internal class SettingsViewModel : BaseViewModel
  {
    #region Singleton
    private static SettingsViewModel? instance = null;
    private readonly static object padlock = new();

    protected SettingsViewModel()
    {
      VisibilityNewEmployeeView = Visibility.Visible;
      VisibilityNewProcessModelView = Visibility.Hidden;
    }

    private Visibility _visibilityNewModelView;
    private Visibility _visibilityNewEmployeeView;

    /// <summary>
    /// returns instance of class SettingsViewModel
    /// </summary>
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


    public Visibility VisibilityNewProcessModelView {
      get {
        return _visibilityNewModelView;
      }

      set {
        _visibilityNewModelView = value;
        OnPropertyChanged();
      }
    }

    public Visibility VisibilityNewEmployeeView {
      get {
        return _visibilityNewEmployeeView;
      }

      set {
        _visibilityNewEmployeeView = value;
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
      VisibilityNewEmployeeView = Visibility.Hidden;
      VisibilityNewProcessModelView = Visibility.Visible;
    }

    private void ExecuteBtnNewEmployee(object Parameter)
    {
      VisibilityNewProcessModelView = Visibility.Hidden;
      VisibilityNewEmployeeView = Visibility.Visible;
    }
  }
}

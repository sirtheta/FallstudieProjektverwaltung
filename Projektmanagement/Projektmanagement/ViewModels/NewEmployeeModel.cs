using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Notifications.Wpf.Core;
using Projektmanagement.Commands;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal class NewEmployeeModel : BaseViewModel
  {

    #region Singleton
    private static NewEmployeeModel? instance = null;
    private readonly static object padlock    = new();

    protected NewEmployeeModel()
    {
      BtnSave = new RelayCommand<object>(SaveNewEmployee);
    }

    /// <summary>
    /// returns instance of class NewEmployeeModel
    /// </summary>
    public static NewEmployeeModel GetInstance {
      get {
        lock (padlock) {
          if (instance == null) {
            instance = new NewEmployeeModel();
          }
          return instance;
        }
      }
    }
    #endregion

    private string _fullName = string.Empty;
    private string _email    = string.Empty;
    private double _hourlyRate;

    public string FullName {
      get {
        return _fullName;
      }

      set {
        _fullName = value;
        OnPropertyChanged();
      }
    }

    public string Email {
      get {
        return _email;
      }

      set {
        _email = value;
        OnPropertyChanged();
      }
    }

    public double HourlyRate {
      get {
        return _hourlyRate;
      }

      set {
        _hourlyRate = value;
        OnPropertyChanged();
      }
    }

    public ICommand BtnSave {
      get;
      private set;
    }
    /// <summary>
    /// get value from role combobox
    /// </summary>
    private EmployeeRole _selectedEmployeeRole;
    public EmployeeRole SelectedEmployeeRole {
      get {
        return _selectedEmployeeRole;
      }
      set {
        _selectedEmployeeRole = value;
        OnPropertyChanged();
      }
    }
    /// <summary>
    /// retrieve data from enum to bind to Combobox
    /// </summary>
    public static IEnumerable<EmployeeRole> EmployeeRoleValue {
      get {
        return Enum.GetValues(typeof(EmployeeRole))
            .Cast<EmployeeRole>();
      }
    }
    /// <summary>
    /// saves the employee to a list.
    /// checks if fields ar empty.
    /// shows notification success or warning
    /// </summary>
    /// <param name="obj"></param>
    private void SaveNewEmployee(object obj)
    {
      if (FullName != String.Empty && Email != String.Empty && HourlyRate > 0) {
        HomeViewModel.GetInstance.Employees.Add(new Employee(FullName, Email, HourlyRate, SelectedEmployeeRole));
        ClearInputFields();
        ShowNotification("Success", "Employee Saved!", NotificationType.Success);
      }
      else {
        ShowNotification("Warning", "Could not save data!", NotificationType.Warning);
      }
    }
    /// <summary>
    /// if save is successfull, reset the inputfields
    /// </summary>
    private void ClearInputFields()
    {
      FullName = string.Empty;
      Email = string.Empty;
      HourlyRate = 0;
    }
  }
}

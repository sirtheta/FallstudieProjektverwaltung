using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Notifications.Wpf.Core;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal abstract class BaseViewModel : DependencyObject, INotifyPropertyChanged
  {
    private List<ProcessModel> _processModels = new();
    private List<Employee> _employees = new();
    private List<Project> _projects = new();

    internal List<ProcessModel> ProcessModels {
      get {
        return _processModels;
      }

      set {
        _processModels = value;
      }
    }

    internal List<Employee> Employees {
      get {
        return _employees;
      }

      set {
        _employees = value;
      }
    }

    internal List<Project> Projects {
      get {
        return _projects;
      }

      set {
        _projects = value;
      }
    }

    internal void ShowNotification(string titel, string message, NotificationType type)
    {
      var notificationManager = new NotificationManager();
      notificationManager.ShowAsync(new NotificationContent { Title = titel, Message = message, Type = type },
              areaName: "WindowArea", expirationTime: new TimeSpan(0, 0, 2));
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

  }
}

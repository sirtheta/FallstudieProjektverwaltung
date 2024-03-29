﻿using System;
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

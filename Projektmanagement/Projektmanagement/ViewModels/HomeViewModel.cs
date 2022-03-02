﻿using System.Windows.Input;
using Projektmanagement.Commands;

namespace Projektmanagement.ViewModels
{
  internal class HomeViewModel : BaseViewModel
  {
    #region Singleton
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
    #endregion

    private string _labelText = "HomeView";
    private string _textBoxText;


    public string LabelText {
      get {
        return _labelText;
      }

      set {
        _labelText = value; 
        OnPropertyChanged();
      }
    }

    public string TextBoxText {
      get {
        return _textBoxText;
      }
      set {
        _textBoxText = value;
        OnPropertyChanged();
      }
    }

    public ICommand BtnTestCommand {
      get {
        return new RelayCommand<object>(ExecuteBtnTestCommand);
      }
    }

    private void ExecuteBtnTestCommand(object Parameter)
    {
      TextBoxText = _textBoxText;
      LabelText = _textBoxText;

      TextBoxText = "";
    }
  }
}

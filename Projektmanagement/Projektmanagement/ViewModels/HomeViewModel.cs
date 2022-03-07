using System.Windows.Input;
using System.Collections.Generic;
using System.ComponentModel;
using Projektmanagement.Commands;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal class HomeViewModel : BaseViewModel,INotifyPropertyChanged
  {
    #region Singleton
    // returns thread safe singleton
    private static HomeViewModel? instance = null;
    private static readonly object padlock = new();

    protected HomeViewModel()
    {
      LabelText = "Home View";

      //generating sample projects for testing
      projects = new List<Project>();
      for(int i = 0; i < 5; i++) 
      {
        Projects.Add(new Project($"Test Projekt {i+1}"));
      }


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

    private string _labelText = "";
    private string _textBoxText = "";

    private List<Project> projects;


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

    public List<Project> Projects {
      get {
        return projects;
      }

      set {
        projects = value;
        OnPropertyChanged();
      }
    }

    private void ExecuteBtnTestCommand(object Parameter)
    {
      LabelText = TextBoxText;

      TextBoxText = "";
    }

  }
}

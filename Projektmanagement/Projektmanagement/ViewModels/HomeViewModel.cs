using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Projektmanagement.Commands;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal class HomeViewModel : BaseViewModel
  {
    #region Singleton
    private static HomeViewModel? instance = null;
    private static readonly object padlock = new();

    protected HomeViewModel()
    {
      //generating sample projects for testing
      Projects = new ObservableCollection<Project>();
      ProcessModel testPM = new ProcessModel("Test", new List<string> { "Initialize", "Planning", "Execution", "End" });
      for (int i = 0; i < 20; i++) {

        Projects.Add(new Project($"Test Projekt {i + 1}", "Info about Project", new Employee("Sascha Dubois", "sa@du.ch", 95, EmployeeRole.Projectmanager), testPM,  true));
      }
    }

    /// <summary>
    /// returns instance of class HomeViewModel
    /// </summary>
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

    private List<ProcessModel> _processModels = new();
    private List<Employee> _employees = new();
    private ObservableCollection<Project> _projects = new();

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

    internal ObservableCollection<Project> Projects {
      get {
        return _projects;
      }

      set {
        _projects = value;
      }
    }

    public ICommand AddProjectButtonCommand {
      get {
        return new RelayCommand<object>(OnAddProjectButtonClicked);
      }
    }

    private void OnAddProjectButtonClicked(object obj)
    {
      if (MainViewModel.GetInstance != null) {
        MainViewModel.GetInstance.SelectedViewModel = new AddProjectViewModel(this);
      }
    }
  }
}

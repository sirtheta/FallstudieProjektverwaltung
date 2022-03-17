using System.Collections.Generic;
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
      Projects = new List<Project>();
      ProcessModel testPM = new ProcessModel("Test", new List<string> { "Initialize", "Planning", "Execution", "End" });
      for (int i = 0; i < 20; i++) {

        Projects.Add(new Project($"Test Projekt {i + 1}",testPM));
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

    private string _labelText = string.Empty;
    private string _textBoxText = string.Empty;
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
  }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Notifications.Wpf.Core;
using Projektmanagement.Commands;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal class AddProjectViewModel : BaseViewModel
  {
    private string _projectName = string.Empty;
    private ObservableCollection<ProcessModel> _processModels;
    private ProcessModel? _selectedProcessModel;
    private string _projectDescription = string.Empty;
    private ObservableCollection<Employee> _employees;
    private Employee? _selectedEmployee;
    private readonly HomeViewModel _homeViewModel;

    /// <summary>
    /// shows a view to add a new projcet to the project list
    /// </summary>
    /// <param name="homeViewModel"></param>
    public AddProjectViewModel(HomeViewModel homeViewModel)
    {
      _homeViewModel = homeViewModel;
      _employees = new ObservableCollection<Employee>(_homeViewModel.Employees);
      _processModels = new ObservableCollection<ProcessModel>(_homeViewModel.ProcessModels);
      BtnSave = new RelayCommand<object>(OnSaveButtonClicked);
      GenerateDemoValues();
    }

    private void GenerateDemoValues()
    {
      ProcessModels.Add(new ProcessModel("HERMES", new List<string>() { "Initialisierung", "Konzept", "Realisierung", "Einführung" }));
      Employees.Add(new Employee("Max Mustermann", "max@mustermann.de", 85, EmployeeRole.Projectmanager));
    }

    public string ProjectName {
      get {
        return _projectName;
      }

      set {
        _projectName = value;
        OnPropertyChanged();
      }
    }

    public string ProjectDescription {
      get {
        return _projectDescription;
      }

      set {
        _projectDescription = value;
        OnPropertyChanged();
      }
    }

    public ObservableCollection<ProcessModel> ProcessModels {
      get {
        return _processModels;
      }

      set {
        _processModels = value;
      }
    }

    public ObservableCollection<Employee> Employees {
      get {
        return _employees;
      }

      set {
        _employees = value;
      }
    }

    public ProcessModel? SelectedProcessModel {
      get {
        return _selectedProcessModel;
      }

      set {
        _selectedProcessModel = value;
        OnPropertyChanged();
      }
    }

    public Employee? SelectedEmployee {
      get {
        return _selectedEmployee;
      }

      set {
        _selectedEmployee = value;
        OnPropertyChanged();
      }
    }

    public ICommand BtnSave {
      get;
      private set;
    }

    private void OnSaveButtonClicked(object obj)
    {
      if (ProjectName != null &&
        SelectedProcessModel != null &&
        SelectedEmployee != null) {
        _homeViewModel.Projects.Insert(0, new Project(ProjectName, ProjectDescription, SelectedEmployee, SelectedProcessModel));
        ShowNotification("Success", "Project added successfull", NotificationType.Success);
      }
      else {
        ShowNotification("Error", "Check your input!", NotificationType.Error);
      }
    }
  }
}

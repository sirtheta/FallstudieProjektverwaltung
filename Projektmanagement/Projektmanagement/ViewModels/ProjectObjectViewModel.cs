using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Projektmanagement.Commands;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal class ProjectObjectViewModel : BaseViewModel
  {
    private Project _project;

    public ProjectObjectViewModel(Project project)
    {
      _project = project;
    }

    public string ProjectName {
      get {
        return _project.ProjectName;
      }
    }

    public string ProjectInfo {
      get {
        return _project.ProjectDescription;
      }
    }

    public string ProjectLeader {
      get {
        return _project.ProjectLeader.Name;
      }
    }

    public int Progress {
      get {
        return _project.Progress;
      }
      set {
        _project.Progress = value;
      }
    }


    public ICommand ProjectObjectDoubleClickComand {
      get {
        return new RelayCommand<object>(ProjectObjectDoubleClick);
      }
    }

    private void ProjectObjectDoubleClick(object obj)
    {
      if (MainViewModel.GetInstance != null) {
        MainViewModel.GetInstance.SelectedViewModel = new PhaseViewModel(_project);
      }
    }
  }
}

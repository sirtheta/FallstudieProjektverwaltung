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
  internal class ProjectObjectViewModel:BaseViewModel
  {
    private Project _project;
    private int _progress;

    public ProjectObjectViewModel(Project project)
    {
      _project = project;
      Random rnd = new Random();
      _progress = rnd.Next(50);
    }

    public string ProjectName {
      get {
        return _project.ProjectName;
      }

    }

    public int Progress {
      get {
        return _progress;
      }

      set {
        _progress = value;
      }
    }

    public ICommand ProjectObjectDoubleClickComand{
      get {
        return new RelayCommand<object>(ProjectObjectDoubleClick);
      }
    }

    private void ProjectObjectDoubleClick(Object Parameter)
    {

      MainViewModel.GetInstance.SelectedViewModel = new PhaseViewModel(_project);
    }
  }
}

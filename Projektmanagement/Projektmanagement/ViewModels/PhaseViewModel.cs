using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal class PhaseViewModel : BaseViewModel
  {
    public PhaseViewModel(Project _project)
    {
      Project = _project;
      GetPhaseCount();
      ProjectName = Project.ProjectName;
    }

    private ObservableCollection<Phase> _phaseCollection = new();
    public ObservableCollection<Phase> PhaseCollection {
      get {
        return _phaseCollection;
      }

      set {
        _phaseCollection = value;
      }
    }

    public Project Project {
      get;
    }

    private string _projectName = string.Empty;

    public string ProjectName {
      get {
        return _projectName;
      }
      set {
        _projectName = value;
        OnPropertyChanged();
      }
    }

    private void GetPhaseCount()
    {
      foreach (var item in Project.Phases) {
        PhaseCollection.Add(item);
      }
    }
  }
}

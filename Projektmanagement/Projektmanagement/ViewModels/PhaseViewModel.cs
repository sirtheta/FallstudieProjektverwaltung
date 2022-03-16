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
    }

    ObservableCollection<Phase> _phaseCollection = new();
    internal ObservableCollection<Phase> PhaseCollection {
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

    private void GetPhaseCount()
    {
      foreach (var item in Project.Phases) {
        PhaseCollection.Add(item);
      }      
    }
  }
}

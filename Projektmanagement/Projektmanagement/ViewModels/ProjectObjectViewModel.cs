using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal class ProjectObjectViewModel
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
  }
}

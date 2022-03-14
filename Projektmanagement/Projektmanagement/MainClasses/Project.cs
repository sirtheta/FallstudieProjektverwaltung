using System.Collections.Generic;
namespace Projektmanagement.MainClasses
{
  internal class Project
  {
    private string _projectName;
    private ProcessModel _pm;


    public Project(string projectName)
    {
      _projectName = projectName;
    }
    public Project(string projectName, ProcessModel pm)
    {
      _projectName = projectName;
      _pm = pm;

    }

    public List<Phase> MyPhasen()
    {
      if (_pm.PhaseNames.Count == 0) {
        return new List<Phase>();

      }

      List<Phase> phases = new List<Phase>();

      for (int i = 0; i < _pm.PhaseNames.Count; i++) {
        phases.Add(new Phase(_pm.PhaseNames[i]));


      }
      return phases;
    }


    public string ProjectName => _projectName;
  }
}

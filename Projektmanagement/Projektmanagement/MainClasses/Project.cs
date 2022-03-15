using System.Collections.Generic;
namespace Projektmanagement.MainClasses
{
  internal class Project
  {
    private string _projectName;
    private ProcessModel _pm;
    private List<Phase> _phases;


    public Project(string projectName)
    {
      _projectName = projectName;
      _phases = new List<Phase>();
      _pm = new ProcessModel("Not Asigned", new List<string>());
    }
    public Project(string projectName, ProcessModel pm)
    {
      _projectName = projectName;
      _pm = pm;
      _phases = GeneratePhases();
    }

    private List<Phase> GeneratePhases()
    {
      if (_pm.PhaseNames.Count == 0) {
        return new List<Phase>();

      }

      List<Phase> tmpPhases = new List<Phase>();

      for (int i = 0; i < _pm.PhaseNames.Count; i++) {
        tmpPhases.Add(new Phase(_pm.PhaseNames[i]));


      }
      return tmpPhases;
    }


    public string ProjectName => _projectName;

    internal List<Phase> Phases {
      get {
        return _phases;
      }

    }
  }
}

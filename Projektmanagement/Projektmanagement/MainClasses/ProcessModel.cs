using System.Collections.Generic;

namespace Projektmanagement.MainClasses
{/// <summary>
/// 03.03.2022 Sascha Dubois
/// Represents a process model based on wich phases in a project will get generated
/// </summary>
  internal class ProcessModel
  {
    public ProcessModel(string processModelName, List<string> phaseNames)
    {
      ProcessModelName = processModelName;
      PhaseNames = phaseNames;
    }

    public string ProcessModelName {
      get;
    }
    public List<string> PhaseNames {
      get;
    }
  }
}

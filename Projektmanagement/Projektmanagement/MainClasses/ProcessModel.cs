using System.Collections.Generic;
using System.Linq;

namespace Projektmanagement.MainClasses
{/// <summary>
/// 03.03.2022 Sascha Dubois
/// Represents a process model based on wich phases in a project will get generated
/// </summary>
  internal class ProcessModel
  {
    private string[] phaseNames;

    public ProcessModel(string[] phaseNames)
    {
      this.phaseNames = phaseNames;
    }

    public string[] PhaseNames => phaseNames;
  }
}

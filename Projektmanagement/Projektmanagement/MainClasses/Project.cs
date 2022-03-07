using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektmanagement.MainClasses
{
  internal class Project
  {
    //I ha das mau zum teschte gmacht... bitte gliich no vervouständige aber bitte dr name vom "Name"-getter biiphaute :)
    private string name;

    public Project(string name)
    {
      this.name = name;
    }

    public string Name => name;
  }
}

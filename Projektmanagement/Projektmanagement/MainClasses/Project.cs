namespace Projektmanagement.MainClasses
{
  internal class Project
  {
    //I ha das mau zum teschte gmacht... bitte gliich no vervouständige aber bitte dr name vom "ProjectName"-getter biiphaute :)
    private string projectName;

    public Project(string projectName)
    {
      this.projectName = projectName;
    }

    public string ProjectName => projectName;
  }
}

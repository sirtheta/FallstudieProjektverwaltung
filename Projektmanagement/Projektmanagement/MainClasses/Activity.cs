using System.Collections.Generic;

namespace Projektmanagement.MainClasses
{/// <summary>
/// 03.03.2022 Sascha Dubois
/// Represents an activity
/// </summary>
  internal class Activity
  {
    private string name;
    private string description;
    private Employee? assingedEmployee;
    private List<string> comments;
    private ActivityState state;
    private float progress;
    private List<Worktime> worktimePlanned;
    private List<Worktime> worktimeActual;
    private List<CostPoint> costPointsPlanned;
    private List<CostPoint> costPointsActual;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name">Name of activity</param>
    /// <param name="description">description of activity</param>
    /// <param name="assingedEmployee">employee wich is responsible for this activity (can be null)</param>
    /// <param name="worktimePlanned">planned worktime</param>
    /// <param name="costPointsPlanned">plannet costs aside of worktime</param>
    public Activity(string name, string description, Employee? assingedEmployee,List<Worktime> worktimePlanned, List<CostPoint> costPointsPlanned)
    {
      this.name = name;
      this.description = description;
      this.assingedEmployee = assingedEmployee;     
      this.worktimePlanned = worktimePlanned; 
      this.costPointsPlanned = costPointsPlanned;
      

      this.comments = new List<string>();
      this.state = ActivityState.Created;
      this.progress = 0;
      this.worktimeActual = new List<Worktime>();
      this.costPointsActual = new List<CostPoint>();
    }

    #region GET/SET
    public string Name {
      get {
        return name;
      }

      set {
        name = value;
      }
    }

    public string Description {
      get {
        return description;
      }

      set {
        description = value;
      }
    }

    public List<string> Comments => comments;

    public float Progress {
      get {
        return progress;
      }

      set {
        progress = value;
      }
    }

    internal Employee? AssingedEmployee {
      get {
        return assingedEmployee;
      }

      set {
        assingedEmployee = value;
      }
    }

    internal ActivityState State {
      get {
        return state;
      }

      set {
        state = value;
      }
    }

    internal List<Worktime> WorktimePlanned => worktimePlanned;

    internal List<Worktime> WorktimeActual => worktimeActual;

    internal List<CostPoint> CostPointsPlanned => costPointsPlanned;

    internal List<CostPoint> CostPointsActual => costPointsActual;
    #endregion


    /// <summary>
    /// Adds a worktime-object to the worktimeActual list
    /// </summary>
    /// <param name="timeToAdd"></param>
    public void AddWorktime(Worktime timeToAdd)
    {
      worktimeActual.Add(timeToAdd);
    }

    /// <summary>
    /// Removes a specific worktime-object from the worktimeActual list
    /// NOTE: use objectreference from WorktimeActual!
    /// </summary>
    /// <param name="timeToRemove"></param>
    public void RemoveWorktime(Worktime timeToRemove)
    {
      try 
      {
        worktimeActual.Remove(timeToRemove);
      }
      catch 
      {

      }
      
    }

    /// <summary>
    /// Adds a costPoint-object to the costPointActual list
    /// </summary>
    /// <param name="costPointToAdd"></param>
    public void AddCostPoint(CostPoint costPointToAdd)
    {
      costPointsActual.Add(costPointToAdd);
    }

    /// <summary>
    /// Removes a specific costpoint-object from the costPointsActual list
    /// NOTE: use objectreference from CostPointsActual!
    /// </summary>
    /// <param name="costPointToRemove"></param>
    public void RemoveCostPoint(CostPoint costPointToRemove)
    {

      try {
        costPointsActual.Remove(costPointToRemove);
      }
      catch { }

    }

  }

  internal enum ActivityState
  {
    Created,
    Planned,
    InProgress,
    Finished
  }
}

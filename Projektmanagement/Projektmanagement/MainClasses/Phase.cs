using System;

namespace Projektmanagement.MainClasses
{
  internal class Phase
  {
    public Phase(string phasename)
    {
      PhaseName = phasename;
      Random rnd = new Random();
      RndLength = rnd.Next(50,200);
    }

    public string PhaseName { get; set; }

   
    private int _rndLength;
    private int _progress;



    public int RndLength {
      get {
        return _rndLength;
      }

      set {
        _rndLength = value;
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
    public string ProgressString 
    {
      get {
        return $"{Progress}%";
      }
      set {
      }
    }
  }
}

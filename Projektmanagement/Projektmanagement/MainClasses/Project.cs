﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Projektmanagement.MainClasses
{
  internal class Project
  {
    private string _projectName;
    private string _projectDescription;
    private Employee _projectLeader;
    private ProcessModel _pm;
    private List<Phase> _phases;
    private int _progress = 0;


    public Project(string projectName, string projectDescription, Employee projectLeader, ProcessModel pm, bool randomProgress = false)
    {
      _projectName = projectName;
      _projectDescription = projectDescription;
      _projectLeader = projectLeader;
      _pm = pm;
      _phases = GeneratePhases();
      if (randomProgress) {
        Random rnd = new Random();
        Progress = rnd.Next(100);
        CalculatePhaseProgress();
      }
    }

    private void CalculatePhaseProgress()
    {
      double totalLength = _phases.Sum(x => x.RndLength);
      int progressLength = (int)Math.Round(totalLength / 100 * Progress);

      for (int i = 0; i < _phases.Count; i++) 
      { 
        if(progressLength >= _phases[i].RndLength) 
        {
          _phases[i].Progress = 100;
          progressLength -= _phases[i].RndLength;
        }
        else 
        {
          _phases[i].Progress = (int)Math.Round(100 / (double)_phases[i].RndLength * progressLength);
          progressLength = 0;
        }      
      }      
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


    public string ProjectName {
      get {
        return _projectName;
      }
    }

    internal List<Phase> Phases {
      get {
        return _phases;
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

    public string ProjectDescription {
      get {
        return _projectDescription;
      }
      set {
        _projectDescription = value;
      }
    }

    internal Employee ProjectLeader {
      get {
        return _projectLeader;
      }

      set {
        _projectLeader = value;
      }
    }
  }
}

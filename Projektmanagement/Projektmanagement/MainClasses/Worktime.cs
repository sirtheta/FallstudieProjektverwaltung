using System;

namespace Projektmanagement.MainClasses
{
  internal class Worktime
  {

    private Employee employee;
    private DateTime time;
    private DateTime date;
    private double cost;


    public Employee Employee {
      get {
        return employee;
      }
      set {
        employee = value;
      }

    }
    public DateTime Time {
      get {
        return Time;
      }
    }

    public double Cost {
      get {
        return cost;
      }

      set {
        cost = value;
      }
    }
  }
}

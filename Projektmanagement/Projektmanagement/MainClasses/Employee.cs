
namespace Projektmanagement.MainClasses
{/// <summary>
/// 03.03.2022 Sascha Dubois
/// Represents an employee
/// HourlyRate is used to calculate the cost
/// Role is used for access-control
/// </summary>
  internal class Employee
  {
    private string _name;
    private string _eMail;
    private double _hourlyRate;
    private EmployeeRole _role;
    private int _id;

    /// <summary>
    /// Represents an employee
    /// HourlyRate is used to calculate the cost
    /// Role is used for access-control
    /// </summary>
    /// <param name="name">name of employee</param>
    /// <param name="eMail">E-Mail adress of employee</param>
    /// <param name="hourlyRate">cost per hour of employee</param>
    /// <param name="role">role of employee</param>
    public Employee(string name, string eMail, double hourlyRate, EmployeeRole role)
    {
      _name = name;
      _eMail = eMail;
      _hourlyRate = hourlyRate;
      _role = role;
    }

    public Employee(int id, string name, string eMail, double hourlyRate, EmployeeRole role)
    {
      _id  = id;
      _name = name;
      _eMail = eMail;
      _hourlyRate = hourlyRate;
      _role = role;
    }

    #region GET/SET
    public string Name {
      get {
        return _name;
      }

      set {
        _name = value;
      }
    }

    public string EMail {
      get {
        return _eMail;
      }

      set {
        _eMail = value;
      }
    }

    public double HourlyRate {
      get {
        return _hourlyRate;
      }

      set {
        _hourlyRate = value;
      }
    }

    public int Id {
      get {
        return _id;
      }

      set {
        _id = value;
      }
    }

    internal EmployeeRole Role {
      get {
        return _role;
      }

      set {
        _role = value;
      }
    }

    #endregion
  }

  internal enum EmployeeRole
  {
    Projectmanager,
    Projectworker
    //not complete...
  }

}

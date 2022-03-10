
namespace Projektmanagement.MainClasses
{/// <summary>
/// 03.03.2022 Sascha Dubois
/// Represents an employee
/// HourlyRate is used to calculate the cost
/// Role is used for access-control
/// </summary>
  internal class Employee
  {
    private string name;
    private string eMail;
    private double hourlyRate;
    private EmployeeRole role;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name">name of employee</param>
    /// <param name="eMail">E-Mail adress of employee</param>
    /// <param name="hourlyRate">cost per hour of employee</param>
    /// <param name="role">role of employee</param>
    public Employee(string name, string eMail, double hourlyRate, EmployeeRole role)
    {
      this.name = name;
      this.eMail = eMail;
      this.hourlyRate = hourlyRate;
      this.role = role;
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

    public string EMail {
      get {
        return eMail;
      }

      set {
        eMail = value;
      }
    }

    public double HourlyRate {
      get {
        return hourlyRate;
      }

      set {
        hourlyRate = value;
      }
    }

    internal EmployeeRole Role {
      get {
        return role;
      }

      set {
        role = value;
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

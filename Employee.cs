using System;

public class Employee
{
  public string FirstName{get; set;}
  public string LastName{get; set;}
  public string Id{get; set;}
  public string EmploymentStatus{get; set;}
  private string address, phonenumber, title, employmentstatus;
  int age;
  public int Age{
    get {return age;}
    set {
      if (value < 18)
        age = 18;
      else
        age = value;
    }
  }
  double yearlysalary;
  public double YearlySalary 
  {
    get {return yearlysalary; }
    set {
      if (value < 1000)
        yearlysalary = 1000;
      else 
        yearlysalary = value;
    }
  }
  public Employee()
  {
    FirstName = "Unknown";
    LastName = "Unknown";
    Id = "Unknown";
    Age = 0;
    EmploymentStatus = "active";
  }
  public Employee(string Firstname, string Lastname, string iid, int aage)
  {
    FirstName = Firstname;
    LastName = Lastname;
    Id = iid;
    Age = aage;
    EmploymentStatus = "Active";
  }
  public void Intro()
  {
    Console.WriteLine("First Name: " + FirstName);
    Console.WriteLine("Last Name: " + LastName);
    Console.WriteLine("ID: " + Id);
    Console.WriteLine("Age: " + Age);
    Console.WriteLine("Employment Status: " + EmploymentStatus);
  }
  public void IncreaseSalary(double percentage)
  {
    if (percentage > 0)
    {
      YearlySalary += (YearlySalary * (percentage / 100));
      Console.WriteLine("Yearly Salary Updated To: " + YearlySalary);
    }
    else
    {
      Console.WriteLine("Invalid Input: Yearly Salary Not Updated");
    }
  }
  public void RemoveEmployee()
  {
    if (EmploymentStatus == "Active")
    {
      EmploymentStatus = "Inactive";
      Console.WriteLine("Employee Removed");
    }
    else
    {
      Console.WriteLine("Employee Already Inactive");
    }
  }
}
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


public class Employee : IEmployee
{
    public int Id { get; set;}
    public string Name { get; set; }
    
    public void AddEmployee(Employee employee)
    {
        Console.WriteLine("Adding employee");
    }

    public void RemoveEmployee(Employee employee)
    {
        Console.WriteLine("Removing employee");
    }

    public void CalculateSalary(Employee employee)
    {
        Console.WriteLine("Calculating salary");
    }

    public void AssignAsset(Employee employee)
    {
        Console.WriteLine("Assigning asset");
    }
}


public class Salary
{
    public double BasicSalary { get; set; }
    public double WorkedHours { get; set; }
    
    public virtual double CalculateSalary()
    {
        return BasicSalary * WorkedHours;
    }
}

public class NewSalary : Salary
{
    IEmployee emp = new Employee();
    public override double CalculateSalary()
    {
        //emp.AssignAsset();
        return base.CalculateSalary() * 1.2;
    }
}

public interface  IEmployeeCRUD
{
    void AddEmployee(Employee employee);
    void RemoveEmployee(Employee employee);
}


public interface IEmployee : IEmployeeCRUD
{
    void CalculateSalary(Employee employee);
    void AssignAsset(Employee employee);
}

public class NewEmployee : IEmployeeCRUD
{
    public void AddEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public void RemoveEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }
}


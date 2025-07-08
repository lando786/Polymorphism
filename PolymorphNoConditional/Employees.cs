namespace PolymorphNoConditional;

public enum EmployeeTypeEnum { Manager, Employee, Intern }

public abstract class Employee
{
    public decimal BaseSalary { get; set; }
    public string Name { get; set; }
}

public interface IBonusCalculable
{
    public double CalculateBonus();
}

public class ManagerType : Employee, IBonusCalculable
{
    public ManagerType(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }
    public double CalculateBonus()
    {
        return 1000;
    }
}

public class EmployeeType : Employee, IBonusCalculable
{
    public EmployeeType(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;       
    }
    public double CalculateBonus()
    {
        return 500;
    }
}

public class InternType : Employee
{
    public InternType(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }
   
}
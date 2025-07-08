namespace PolymorphNoConditional;

public static class EmployeeFactory
{
    public static Employee CreateEmployee(EmployeeTypeEnum type,string name, decimal baseSalary)
    {
        return type switch
        {
            EmployeeTypeEnum.Manager => new ManagerType(name, baseSalary),
            EmployeeTypeEnum.Intern => new InternType(name, baseSalary),
            EmployeeTypeEnum.Employee => new EmployeeType(name, baseSalary),
            _ => throw new ArgumentException("Invalid Employee Type")
        };
    }
    
}
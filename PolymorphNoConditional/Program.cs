// See https://aka.ms/new-console-template for more information

using PolymorphNoConditional;

Console.WriteLine("Hello, World!");

var employees = new List<Employee>()
{
   EmployeeFactory.CreateEmployee(EmployeeTypeEnum.Manager, "John", 1000),
   EmployeeFactory.CreateEmployee(EmployeeTypeEnum.Intern, "Jane", 500),
   EmployeeFactory.CreateEmployee(EmployeeTypeEnum.Employee, "Bob", 1000)  
};


foreach (var e in employees.Where(e => e is IBonusCalculable))
{
    var calculable = (IBonusCalculable)e;
    Console.WriteLine($"{e.Name} has a salary of {e.BaseSalary}, with bonus his salary is {(double)e.BaseSalary + calculable.CalculateBonus()}");
}
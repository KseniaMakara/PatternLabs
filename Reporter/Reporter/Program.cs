using Reporter;

List<Employee> employees = new()
{
    new Employee { Name = "Langa", Salary = 100 },
    new Employee { Name = "Levi", Salary = 50 },
    new Employee { Name = "Kaneki", Salary = 200 },
    new Employee { Name = "Hisoka", Salary = 100 }
};

var builder = new EmployeeReportBuilder(employees);

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);

Console.ReadKey();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public class EmployeeReportBuilder: IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;

        private readonly IEnumerable<Employee> _employees;

        protected Employee emp = new Employee();
        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }

        
        public IEmployeeReportBuilder SetName(string name)
        {
            this.emp.Name = name;
            return this; 

        }

        public IEmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body =
                string.Join(Environment.NewLine,
                    _employees.Select(e =>
                    $" <!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n  " +
                    $" {_employeeReport.Header} \r\n                \"HEADER: {DateTime.Now};\r\n"+
                    $"  <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n  " +
                    $"  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n</head>\r\n<body>\r\n  " +
                    $"  <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n</body>\r\n <footer>\r\n   " +
                    $" {_employeeReport.Footer}\r\n   $\"\\FOOTER $\"\\Made by Ksenia Makara\"; \r\n</footer></html> $"));

            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            //_employeeReport.Footer =
            //    "\n----------------------------------------------------------------------------------------------------\n";

            //_employeeReport.Footer +=
            //    $"\nTOTAL EMPLOYEES: {_employees.Count()}, " +
            //    $"TOTAL SALARY: {_employees.Sum(e => e.Salary)}" +
            //    $"\nMade by Ksenia Makara";

            return this;
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;

            _employeeReport = new();

            return employeeReport;
        }
    }
}

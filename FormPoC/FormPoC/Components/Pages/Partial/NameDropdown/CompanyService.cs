using formtest.Models;
using System.Collections.Generic;
using System.Linq;

namespace formtest.Services
{
    public class CompanyService
    {
        private List<Company> _companies = new List<Company>
        {
            new Company { Id = 1, Name = "Företag 1" },
            new Company { Id = 2, Name = "Företag 2" }
        };

        private List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Oscar", LastName = "Karlsson", Role = "Utvecklare", CompanyId = 1 },
            new Employee { Id = 2, FirstName = "Anna", LastName = "Svensson", Role = "Designer", CompanyId = 1 },
            new Employee { Id = 3, FirstName = "Erik", LastName = "Johansson", Role = "Projektledare", CompanyId = 2 },
            new Employee { Id = 4, FirstName = "Maria", LastName = "Nilsson", Role = "QA Ingenjör", CompanyId = 2 }
        };

        public event Action CompaniesChanged;
        public event Action EmployeesChanged;

        public List<Company> GetCompanies()
        {
            Console.WriteLine($"Antal företag: {_companies.Count}");
            return _companies;
        }

        public List<Employee> GetEmployees()
        {
            Console.WriteLine($"Antal anställda: {_employees.Count}");
            return _employees;
        }

        public void AddCompany(Company company)
        {
            _companies.Add(company);
            CompaniesChanged?.Invoke();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
            EmployeesChanged?.Invoke();
        }

    }
}

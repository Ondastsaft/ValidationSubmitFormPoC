﻿namespace FormPoC.Components.Pages.Partial.NameDropdown
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int CompanyId { get; set; }
    }

}

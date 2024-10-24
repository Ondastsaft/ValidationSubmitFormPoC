﻿using FormPoC.Components.Pages.Partial.ButtonsFolder;
using FormPoC.Components.Pages.Partial.Checkbox;
using FormPoC.Components.Pages.Partial.DropDown;
using FormPoC.Components.Pages.Partial.ParameterWithValueInputfield;
using FormPoC.Components.Pages.Partial.RadioButtonGroup;
using FormPoC.Components.Pages.Partial.VerifyAndAttachFile;
using FormPoC.Model;

namespace FormPoC.DAL;

public static class Tab2Dal
{
    public static List<Company> Companies = new()
    {
        new Company { Id = 1, Name = "Företag 1" },
        new Company { Id = 2, Name = "Företag 2" }
    };

    public static List<Employee> Employees = new()
    {
        new Employee
        {
            Id = 1, FirstName = "Oscar", LastName = "Karlsson", Role = "Utvecklare", CompanyId = 1,
            StreetAdress = "Storgatan 12", City = "Stockholm", PostalCode = "111 22"
        },
        new Employee
        {
            Id = 2, FirstName = "Anna", LastName = "Svensson", Role = "Designer", CompanyId = 1,
            StreetAdress = "Sveavägen 45", City = "Stockholm", PostalCode = "113 52"
        },
        new Employee
        {
            Id = 3, FirstName = "Erik", LastName = "Johansson", Role = "Projektledare", CompanyId = 2,
            StreetAdress = "Västra Hamngatan 7", City = "Göteborg", PostalCode = "411 17"
        },
        new Employee
        {
            Id = 4, FirstName = "Maria", LastName = "Nilsson", Role = "QA Ingenjör", CompanyId = 2,
            StreetAdress = "Lilla Bommen 4", City = "Göteborg", PostalCode = "411 04"
        }
    };

    public static async Task<DropDownFromListController> GetEmployeeDropdownControllerAsync()
    {
        return new DropDownFromListController(new List<DropDownItemDTO>(), "Visa anställda", "Välj en anställd")
            { SelectedItem = new DropDownItemDTO() };
    }

    public static async Task<DropDownFromListController> GetCompanyDropdownControllerAsync()
    {
        var companies = await GetCompaniesAsDropDownItemDTOs();
        return new DropDownFromListController(companies, "Visa företag", "Välj ett företag")
            { SelectedItem = new DropDownItemDTO(), IsDisabled = false };
    }

    public static async Task<SetValueForParameterController> GetSetWeightController()
    {
        return new SetValueForParameterController("Vikt");
    }

    public static async Task<SetValueForParameterController> GetSetHeightController()
    {
        return new SetValueForParameterController("Höjd");
    }

    public static async Task<CheckBoxController> GetShowDistanceController()
    {
        return new CheckBoxController("Visa avstånd") { IsDisabled = false };
    }

    public static async Task<CheckBoxController> GetShowWeightController()
    {
        return new CheckBoxController("Visa vikt") { IsDisabled = false };
    }

    public static async Task<CheckBoxController> GetShowAltitudeController()
    {
        return new CheckBoxController("Visa höjd") { IsDisabled = false };
    }

    public static async Task<RadioButtonGroupController<Tab2DistanceRadioOptions>>
        GetSelectDistanceRadioButtonController()
    {
        var dictionary = new Dictionary<Tab2DistanceRadioOptions, string>
        {
            { Tab2DistanceRadioOptions.short_distance, "< 100km" },
            { Tab2DistanceRadioOptions.medium_distance, "> 100km" },
            { Tab2DistanceRadioOptions.long_distance, "> 10 000km" }
        };
        return new RadioButtonGroupController<Tab2DistanceRadioOptions>(dictionary);
    }

    public static async Task<VerifyAndAttachFileController> GetVerifyAndAttachFileDistanceController()
    {
        return new VerifyAndAttachFileController("Bekräfta avstånd", "Bifoga fil");
    }

    public static async Task<VerifyAndAttachFileController> GetVerifyAndAttachHeightController()
    {
        return new VerifyAndAttachFileController("Bekräfta höjd", "Bifoga fil");
    }

    public static async Task<GenericButtonController> GetSaveButtonController()
    {
        return new GenericButtonController("Spara", true);
    }

    public static async Task<GenericButtonController> GetSubmitButtonController()
    {
        return new GenericButtonController("Skicka", true);
    }

    public static async Task<List<DropDownItemDTO>> GetCompaniesAsDropDownItemDTOs()
    {
        var companiesDTOs = new List<DropDownItemDTO>();
        foreach (var company in Companies)
            companiesDTOs.Add(new DropDownItemDTO { Id = company.Id, Name = company.Name });
        return companiesDTOs;
    }

    public static async Task<List<DropDownItemDTO>> GetEmployeesAsDropDownListDTO()
    {
        var employeesDTOs = new List<DropDownItemDTO>();
        foreach (var employee in Employees)
            employeesDTOs.Add(new DropDownItemDTO
                { Id = employee.Id, Name = employee.FirstName + " " + employee.LastName });
        return employeesDTOs;
    }

    public static async Task<List<DropDownItemDTO>> GetEmployeesFromCompanyId(int companyId)
    {
        var employeeList = Employees.Where(e => e.CompanyId == companyId).ToList();
        var employeeDTOList = new List<DropDownItemDTO>();
        foreach (var employee in employeeList)
            employeeDTOList.Add(new DropDownItemDTO
                { Id = employee.Id, Name = employee.FirstName + " " + employee.LastName });

        return employeeDTOList;
    }
}
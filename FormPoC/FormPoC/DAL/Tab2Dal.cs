using FormPoC.Components.Pages.Partial.Checkbox;
using FormPoC.Components.Pages.Partial.DropDown;
using FormPoC.Components.Pages.Partial.ParameterWithValueInputfield;
using FormPoC.Components.Pages.Partial.RadioButtonGroup;
using FormPoC.Components.Pages.Partial.VerifyAndAttachFile;
using FormPoC.Model;

namespace FormPoC.DAL
{
    public static class Tab2Dal
    {
        public static List<Company> Companies = new List<Company>
        {
            new Company { Id = 1, Name = "Företag 1" },
            new Company { Id = 2, Name = "Företag 2" }
        };

        public static List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Oscar", LastName = "Karlsson", Role = "Utvecklare", CompanyId = 1 },
            new Employee { Id = 2, FirstName = "Anna", LastName = "Svensson", Role = "Designer", CompanyId = 1 },
            new Employee { Id = 3, FirstName = "Erik", LastName = "Johansson", Role = "Projektledare", CompanyId = 2 },
            new Employee { Id = 4, FirstName = "Maria", LastName = "Nilsson", Role = "QA Ingenjör", CompanyId = 2 }
        };
        public static async Task<DropDownFromListController> GetEmployeeDropdownControllerAsync()
        {
            var companies = await GetCompaniesAsDropDownItemDTOs();
            return new DropDownFromListController(new List<DropDownItemDTO>(), "Visa anställda", "Välj en anställd"){};
        }
        public static async Task<DropDownFromListController> GetCompanyDropdownControllerAsync( )
        {
            return new DropDownFromListController(new List<DropDownItemDTO>(), "Visa anställda", "Välj en anställd");
        }

        public static async Task<SetValueForParameterController> GetSetWeightController()
        {
            return new SetValueForParameterController("Vikt", "0");
        }
        public static async Task<SetValueForParameterController> GetSetHeightController()
        {
            return new SetValueForParameterController("Höjd", "0");
        }
        public static async Task<CheckBoxController> GetShowDistanceController()
        {
            return new CheckBoxController("Visa avstånd");
        }
        public static async Task<CheckBoxController> GetShowWeightController()
        {
            return new CheckBoxController("Visa vikt");
        }        
        public static async Task<CheckBoxController> GetShowAltitudeController()
        {
            return new CheckBoxController("Visa höjd");
        }
        public static async Task<RadioButtonGroupController<Tab2DistanceRadioOptions>> GetSelectDistanceController()
        {
            var dictionary = new Dictionary<Tab2DistanceRadioOptions, string>()
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

        public static async Task<List<DropDownItemDTO>> GetCompaniesAsDropDownItemDTOs()
        {
            var companiesDTOs = new List<DropDownItemDTO>();
            foreach (var company in Companies)
            {
                companiesDTOs.Add(new DropDownItemDTO { Id = company.Id, Name = company.Name });
            }
            return companiesDTOs;
        }
        public static async Task<List<DropDownItemDTO>> GetEmployeesAsDropDownListDTO()
        {
            var employeesDTOs = new List<DropDownItemDTO>();
            foreach (var employee in Employees)
            {
                employeesDTOs.Add(new DropDownItemDTO { Id = employee.Id, Name = (employee.FirstName + " " + employee.LastName)});
            }
            return employeesDTOs;
        }
    }
}

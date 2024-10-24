using FormPoC.Model;
using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.ReadOnlyFieldForEmployee
{

    public class EmployeeController
    {
        public Employee SelectedEmployee { get; set; } = new Employee();
        public bool IsDisabled { get; set; } = true;
        //Todo fixa variabler för labels
        public async Task SetSelectedEmployee(Employee employee)
        {
            SelectedEmployee = employee ?? new Employee();
            await OnEmployeeSelected.InvokeAsync(true);
        }
        public EventCallback<bool> OnEmployeeSelected { get; set; }
    }
}

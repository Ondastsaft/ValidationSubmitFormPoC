using FormPoC.Model;
using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.ReadOnlyFieldForEmployee;

public class EmployeeController
{
    public Employee SelectedEmployee { get; set; } = new();
    public bool IsDisabled { get; set; } = true;

    public EventCallback<bool> OnEmployeeSelected { get; set; }

    //Todo fixa variabler för labels
    public async Task SetSelectedEmployee(Employee employee)
    {
        SelectedEmployee = employee ?? new Employee();
        await OnEmployeeSelected.InvokeAsync(true);
    }
}
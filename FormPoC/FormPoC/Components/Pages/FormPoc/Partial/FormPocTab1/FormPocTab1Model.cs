using FormPoC.Model;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace FormPoC.Components.Pages.FormPoc.Partial.FormPocTab1
{
    public class FormPocTab1Model
    {
        public Employee SelectedEmployee { get; private set; } = new();

        public void SetEmployee(int organizationId, int employeeId)
        {

        }

    }
}

using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.ParameterWithValueInputfield;

public class SetValueForParameterController(string parameterName)
{
    public EventCallback<bool> OnValueSet;
    private string parameterValue;
    public string ParameterName { get; set; } = parameterName;

    public string ParameterValue
    {
        get => parameterValue;
        set
        {
            parameterValue = value;
            OnValueSet.InvokeAsync();
        }
    }

    public bool IsDisabled { get; set; } = true;
}
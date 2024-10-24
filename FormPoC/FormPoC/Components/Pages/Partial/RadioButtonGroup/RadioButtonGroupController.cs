using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.RadioButtonGroup;

public class RadioButtonGroupController<TEnum> where TEnum : Enum
{
    private TEnum _selectedValue;
    public EventCallback<bool> ValueHasChanged;

    public RadioButtonGroupController(Dictionary<TEnum, string> radioOptions)
    {
        if (CheckDictionary(radioOptions))
            RadioOptions = radioOptions;
        else
            throw new ArgumentException("All options not represented in dictionary");
    }

    public Dictionary<TEnum, string> RadioOptions { get; set; } = new();
    public bool IsDisabled { get; set; } = true;

    public TEnum SelectedValue
    {
        get => _selectedValue;
        set
        {
            if (!_selectedValue.Equals(value))
            {
                _selectedValue = value;
                ValueHasChanged.InvokeAsync();
            }
        }
    }

    private bool CheckDictionary(Dictionary<TEnum, string> radioOptions)
    {
        var enumValues = Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
        foreach (var value in enumValues)
            if (!radioOptions.ContainsKey(value))
                return false;
        return true;
    }
}
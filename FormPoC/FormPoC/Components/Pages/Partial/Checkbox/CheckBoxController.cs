using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.Checkbox;

public class CheckBoxController(string label)
{
    public int Id { get; set; }
    public string Label { get; set; } = label;
    public bool IsDisabled { get; set; } = true;
    private bool isChecked { get; set; }

    public bool IsChecked
    {
        get => isChecked;
        set
        {
            isChecked = value;
            IsCheckedChanged.InvokeAsync(value);
        }
    }

    public EventCallback<bool> IsCheckedChanged { get; set; }
}
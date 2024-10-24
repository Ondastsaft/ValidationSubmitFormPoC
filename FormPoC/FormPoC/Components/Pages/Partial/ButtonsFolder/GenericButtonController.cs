using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.ButtonsFolder;

public class GenericButtonController
{
    public GenericButtonController(string buttonText, bool isDisabled)
    {
        ButtonText = buttonText;
        IsDisabled = isDisabled;
    }

    public string ButtonText { get; set; }
    public bool IsDisabled { get; set; }
    public EventCallback<bool> IsClicked { get; set; }
}
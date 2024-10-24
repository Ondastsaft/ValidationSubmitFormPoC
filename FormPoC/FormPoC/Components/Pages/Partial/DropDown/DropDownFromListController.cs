using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.DropDown;

public class DropDownFromListController(List<DropDownItemDTO> dropDownList, string dropDownLabel, string optionTitle)
{
    public EventCallback<bool> OnDropDownSelect;
    private DropDownItemDTO selectedItem;
    public List<DropDownItemDTO> DropDownList { get; set; } = dropDownList;

    public DropDownItemDTO SelectedItem
    {
        get => selectedItem;
        set
        {
            if (selectedItem == null || !selectedItem.Equals(value))
            {
                selectedItem = value ?? new DropDownItemDTO();
                OnDropDownSelect.InvokeAsync(true);
            }
        }
    }

    public bool IsDisabled { get; set; } = true;
    public string DropDownLabel { get; set; } = dropDownLabel;
    public string OptionLabel { get; set; } = optionTitle;
}
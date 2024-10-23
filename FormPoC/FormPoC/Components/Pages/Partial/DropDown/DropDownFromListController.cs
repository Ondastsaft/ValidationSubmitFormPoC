using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.DropDown
{
    public class DropDownFromListController(List<DropDownItemDTO> dropDownList, bool isDisabled, string dropDownLabel, string optionTitle)
    {
        public List<DropDownItemDTO> DropDownList { get; set; } = dropDownList;
        private DropDownItemDTO selectedItem;
        public DropDownItemDTO SelectedItem
        {
            get => selectedItem;
            set
            {
                if (!selectedItem.Equals(value))
                {
                    selectedItem = value;
                    OnDropDownSelect.InvokeAsync(true);
                }
            }
        } 
        public bool IsDisabled { get; set; } = isDisabled;
        public string DropDownLabel { get; set; } = dropDownLabel;
        public string OptionLabel { get; set; } = optionTitle;
        public EventCallback<bool> OnDropDownSelect;
    }
}

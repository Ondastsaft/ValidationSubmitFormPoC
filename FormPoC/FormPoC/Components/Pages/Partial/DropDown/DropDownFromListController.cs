namespace FormPoC.Components.Pages.Partial.DropDown
{
    public class DropDownFromListController(List<object> dropDownList, object selectedItem, bool isDisabled, string dropDownLabel)
    {
        public List<object> DropDownList { get; set; } = dropDownList;
        public object SelectedItem { get; set; } = selectedItem;
        public bool IsDisabled { get; set; } = isDisabled;
        public string DropDownLabel { get; set; } = dropDownLabel;
    }
}

using FormPoC.Components.Pages.Partial.RadioButtonGroup;
using FormPoC.DAL;

namespace FormPoC.Components.Pages.Partial.Tab2
{
    public class Tab2Controller
    {
        public bool IsDisabled { get; set; }  = true;
        public Tab2ComponentControllers ComponentControllers { get; set; }

        public async Task HandleShowAltitudeChecked()
        {
            ComponentControllers.SetAltitudeController.IsDisabled = !ComponentControllers.ShowAltitudeController.IsChecked;
        }

        public async Task HandleShowWeightChecked()
        {
            ComponentControllers.SetWeightController.IsDisabled = !ComponentControllers.ShowWeightController.IsChecked;
        }

        public async Task HandleShowDistanceChecked()
        {
            ComponentControllers.SelectDistanceRadioButtonGroupController.IsDisabled = !ComponentControllers.ShowDistanceController.IsChecked;
        }

        public async Task HandleSelectDistanceParameterSet()
        {
            switch (ComponentControllers.SelectDistanceRadioButtonGroupController.SelectedValue)
            {
                case Tab2DistanceRadioOptions.long_distance:
                    ComponentControllers.VerifyAndAttachFileDistanceController.IsDisabled = false;
                    break;

                case Tab2DistanceRadioOptions.medium_distance:
                    case Tab2DistanceRadioOptions.short_distance:
                    ComponentControllers.VerifyAndAttachFileDistanceController.IsDisabled = true;
                    break;

                default:
                    ComponentControllers.VerifyAndAttachFileDistanceController.IsDisabled = true;
                    break;

            }
        }

        public async Task HandleSetHeightInput()
        {
            int value = int.TryParse(ComponentControllers.SetAltitudeController.ParameterValue, out var result) 
                ? result 
                : 0;
            if (value > 1000)
            {
                ComponentControllers.VerifyAndAttachFileHeightController.IsDisabled = false;
            }
            else
            {
                ComponentControllers.VerifyAndAttachFileHeightController.IsDisabled = true;
            }
        }

        public async Task HandleCompanySelected()
        {
            ComponentControllers.EmployeeDropDownController.DropDownList = await Tab2Dal.GetEmployeesFromCompanyId(ComponentControllers.CompanyDropDownController.SelectedItem.Id);
            ComponentControllers.EmployeeDropDownController.IsDisabled = false;
            ComponentControllers.SaveButtonController.IsDisabled = false;
        }
    }
}

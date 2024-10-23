
using FormPoC.Components.Pages.Partial.Checkbox;
using FormPoC.Components.Pages.Partial.DropDown;
using FormPoC.Components.Pages.Partial.ParameterWithValueInputfield;
using FormPoC.Components.Pages.Partial.RadioButtonGroup;
using FormPoC.Components.Pages.Partial.VerifyAndAttachFile;
using FormPoC.DAL;

namespace FormPoC.Components.Pages.Partial.Tab2
{
    public class Tab2ComponentControllers
    {
        //ToDO Add DisplayEmployeeController
        public DropDownFromListController EmployeeDropDownController { get; set; }
        public DropDownFromListController CompanyDropDownController { get; set; }
        public SetValueForParameterController SetWeightController { get; set; }
        public SetValueForParameterController SetHeightController { get; set; }
        public CheckBoxController ShowDistanceController { get; set; }
        public CheckBoxController ShowWeightController { get; set; }
        public CheckBoxController ShowAltitudeController { get; set; }
        public RadioButtonGroupController<Tab2DistanceRadioOptions> SelectDistanceController { get; set; }
        public VerifyAndAttachFileController VerifyAndAttachFileDistanceController { get; set; }
        //ToDo add input field for Verify and attach file distance component
        public VerifyAndAttachFileController VerifyAndAttachFileHeightController { get; set; }
        //Todo Add save button
        //Todo add submit button

        public async Task InitializeControllersAsync()
        {
            EmployeeDropDownController = await Tab2Dal.GetEmployeeDropdownControllerAsync();
            CompanyDropDownController = await Tab2Dal.GetCompanyDropdownControllerAsync();
            SetWeightController = await Tab2Dal.GetSetWeightController();
            SetHeightController = await Tab2Dal.GetSetHeightController();
            ShowDistanceController = await Tab2Dal.GetShowDistanceController();
            ShowWeightController = await Tab2Dal.GetShowWeightController();
            ShowAltitudeController = await Tab2Dal.GetShowAltitudeController();
            SelectDistanceController = await Tab2Dal.GetSelectDistanceController();
            VerifyAndAttachFileDistanceController = await Tab2Dal.GetVerifyAndAttachFileDistanceController();
            VerifyAndAttachFileHeightController = await Tab2Dal.GetVerifyAndAttachHeightController();
            //SelectDistanceController.ValueHasChanged = await HandleSelectDistanceParameterSet();
        }

        private async Task HandleSelectDistanceParameterSet()
        {
            switch (SelectDistanceController.SelectedValue)
            {
                case Tab2DistanceRadioOptions.long_distance:
                    VerifyAndAttachFileDistanceController.IsDisabled = false;
                    break;

                default:
                    VerifyAndAttachFileDistanceController.IsDisabled = true;
                    VerifyAndAttachFileHeightController.IsDisabled = false;
                    break;
            }
        }
    }
}


//        public Tab3Model GetTab3Model()
//        {
//            return new Tab3Model
//            {
//                WeightValueModel = new SetValueForParameterModel
//                {
//                    WeightValueInputModel = new WeightValueInputModel
//                    {
//                        ParameterNameForValue = new ParameterNameModel { Name = "Weight" },
//                        ParametersValue = "Enter weight"
//                    }
//                },
//                DistanceValueModel = new SetValueForParameterModel
//                {
//                    WeightValueInputModel = new WeightValueInputModel
//                    {
//                        ParameterNameForValue = new ParameterNameModel { Name = "Distance" },
//                        ParametersValue = "Enter distance"
//                    }
//                }
//            };
//        }

//public RadioButtonGroupModel<Tab7DistanceRadioOptions> Tab7DistanceRadioButtonGroupModel { get; set; }

//public Tab7Model()
//{
//    var radioButtonDictionary = DAL.Tab7DistanceRadioGroupDAL.GetDistanceRadioOptions();
//    Tab7DistanceRadioButtonGroupModel = new RadioButtonGroupModel<Tab7DistanceRadioOptions>(radioButtonDictionary)
//    {
//        SelectedValue = Tab7DistanceRadioOptions.short_distance
//    };
//}
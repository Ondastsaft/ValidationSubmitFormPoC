using FormPoC.Components.Pages.Partial.ButtonsFolder;
using FormPoC.Components.Pages.Partial.Checkbox;
using FormPoC.Components.Pages.Partial.DropDown;
using FormPoC.Components.Pages.Partial.ParameterWithValueInputfield;
using FormPoC.Components.Pages.Partial.RadioButtonGroup;
using FormPoC.Components.Pages.Partial.ReadOnlyFieldForEmployee;
using FormPoC.Components.Pages.Partial.VerifyAndAttachFile;
using FormPoC.DAL;

namespace FormPoC.Components.Pages.Partial.Tab2;

public class Tab2ComponentControllers
{
    //ToDO Add DisplayEmployeeController
    public EmployeeController EmployeeController { get; set; }
    public DropDownFromListController EmployeeDropDownController { get; set; }
    public DropDownFromListController CompanyDropDownController { get; set; }
    public SetValueForParameterController SetWeightController { get; set; }
    public SetValueForParameterController SetAltitudeController { get; set; }
    public CheckBoxController ShowDistanceController { get; set; }
    public CheckBoxController ShowWeightController { get; set; }
    public CheckBoxController ShowAltitudeController { get; set; }
    public RadioButtonGroupController<Tab2DistanceRadioOptions> SelectDistanceRadioButtonGroupController { get; set; }

    public VerifyAndAttachFileController VerifyAndAttachFileDistanceController { get; set; }

    //ToDo add input field for Verify and attach file distance component
    public VerifyAndAttachFileController VerifyAndAttachFileHeightController { get; set; }

    //Todo Add save button
    public GenericButtonController SaveButtonController { get; set; }

    //Todo add submit button
    public GenericButtonController SubmitButtonController { get; set; }

    public async Task InitializeControllersAsync()
    {
        EmployeeDropDownController = await Tab2Dal.GetEmployeeDropdownControllerAsync();
        CompanyDropDownController = await Tab2Dal.GetCompanyDropdownControllerAsync();
        SetWeightController = await Tab2Dal.GetSetWeightController();
        SetAltitudeController = await Tab2Dal.GetSetHeightController();
        ShowDistanceController = await Tab2Dal.GetShowDistanceController();
        ShowWeightController = await Tab2Dal.GetShowWeightController();
        ShowAltitudeController = await Tab2Dal.GetShowAltitudeController();
        SelectDistanceRadioButtonGroupController = await Tab2Dal.GetSelectDistanceRadioButtonController();
        VerifyAndAttachFileDistanceController = await Tab2Dal.GetVerifyAndAttachFileDistanceController();
        VerifyAndAttachFileHeightController = await Tab2Dal.GetVerifyAndAttachHeightController();
        SaveButtonController = await Tab2Dal.GetSaveButtonController();
        SubmitButtonController = await Tab2Dal.GetSubmitButtonController();
        EmployeeController = new EmployeeController();
        //SelectDistanceController.ValueHasChanged = await HandleSelectDistanceParameterSet();
    }
}
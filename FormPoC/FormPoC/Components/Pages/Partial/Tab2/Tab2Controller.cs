using FormPoC.Components.Pages.Partial.DropDown;

namespace FormPoC.Components.Pages.Partial.Tab2
{
    public class Tab2Controller
    {
        public DropDownFromListController NameDropDownController { get; set; }
        public DropDownFromListController CompanyDropDownController { get; set; }
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
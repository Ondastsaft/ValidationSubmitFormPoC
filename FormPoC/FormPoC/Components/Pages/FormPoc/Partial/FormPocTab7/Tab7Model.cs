using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormPageLibrary.Enum;
using FormPoC.Components.Pages.Partial.RadioButtonGroup;

namespace FormPoC.Components.Pages.FormPoc.Partial.FormPocTab7
{
    public class Tab7Model
    {
        public RadioButtonGroupModel<Tab7DistanceRadioOptions> Tab7DistanceRadioButtonGroupModel { get; set; }

        public Tab7Model()
        {
            var radioButtonDictionary = DAL.Tab7DistanceRadioGroupDAL.GetDistanceRadioOptions();
            Tab7DistanceRadioButtonGroupModel = new RadioButtonGroupModel<Tab7DistanceRadioOptions>(radioButtonDictionary)
            {
                SelectedValue = Tab7DistanceRadioOptions.short_distance
            };
        }
    }
}
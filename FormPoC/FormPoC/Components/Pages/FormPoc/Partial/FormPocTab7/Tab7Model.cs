using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoC.Components.Pages.FormPoc.Partial.FormPocTab7
{
    public class Tab7Model
    {
        public enum Tab7DistanceRadioOptions
        {
            short_distance,
            medium_distance,
            long_distance
        }
        public RadioButtonGroupModel<Tab7DistanceRadioOptions> Tab7DistanceRadioButtonGroupModel { get; set; } = new RadioButtonGroupModel<Tab7DistanceRadioOptions>
        {
            SelectedValue = Tab7DistanceRadioOptions.short_distance
        };
    }
}
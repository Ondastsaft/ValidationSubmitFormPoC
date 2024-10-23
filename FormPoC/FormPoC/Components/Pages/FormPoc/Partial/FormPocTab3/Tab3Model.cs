using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormPageLibrary;
using FormPoC.Components.Pages.Partial.ParameterWithValueInputfield;

namespace FormPoC.Components.Pages.FormPoc.Partial.FormPocTab3
{
    public class Tab3Model
    {
        public SetValueForParameterModel WeightValueModel { get; set; } = new()
        {
            WeightValueInputModel = new()
            {
                ParametersValue = new IntValue(),
                ParameterNameForValue = new() { Name = "Weight" }
            }
        };
    }
}
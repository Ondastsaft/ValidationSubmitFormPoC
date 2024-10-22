using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPageLibrary.ComponentModels
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoC.Components.Pages.Partial.ParameterWithValueInputfield
{
    public class SetValueForParameterController(string parameterName, string parameterValue)
    {
        public string ParameterName { get; set; } = parameterName;
        public string ParameterValue { get; set; } = parameterValue;
    }
}
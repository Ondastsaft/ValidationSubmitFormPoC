using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.ParameterWithValueInputfield
{
    public class SetValueForParameterController(string parameterName)
    {
        public string ParameterName { get; set; } = parameterName;
        public string ParameterValue
        {
            get => parameterValue;
            set
            {
                parameterValue = value;
                OnValueSet.InvokeAsync();
            }
        } 
        private string parameterValue;
        public bool IsDisabled { get; set; }  = true;
        public EventCallback<bool> OnValueSet;
    }
}
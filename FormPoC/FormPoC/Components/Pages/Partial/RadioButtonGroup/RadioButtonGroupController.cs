using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace FormPoC.Components.Pages.Partial.RadioButtonGroup
{
    public class RadioButtonGroupController<TEnum> where TEnum : Enum
    {
        public Dictionary<TEnum, string> RadioOptions { get; set; } = new Dictionary<TEnum, string>();
        public EventCallback ValueHasChanged;
        private TEnum _selectedValue;
        public TEnum SelectedValue
        {
            get => _selectedValue;
            set
            {
                if (!_selectedValue.Equals(value))
                {
                    ValueHasChanged.InvokeAsync();
                }
            }
        }

        public RadioButtonGroupController(Dictionary<TEnum, string> radioOptions)
        {
            if (CheckDictionary(radioOptions))
            {
                RadioOptions = radioOptions;
            }
            else
            {
                throw new ArgumentException("All options not represented in dictionary");
            }
        }

        private bool CheckDictionary(Dictionary<TEnum, string> radioOptions)
        {
            var enumValues = Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
            foreach (var value in enumValues)
            {
                if (!radioOptions.ContainsKey(value))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

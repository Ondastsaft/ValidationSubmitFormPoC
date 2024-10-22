using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoC.Components.Pages.FormPoc.Partial.FormPocTab7
{
    public class RadioButtonGroupModel<TEnum> where TEnum : Enum
    {
        private TEnum _selectedValue;
        public TEnum SelectedValue
        {
            get => _selectedValue;
            set
            {
                if (!_selectedValue.Equals(value))
                {
                    _selectedValue = value;
                    ValueHasChanged?.Invoke();
                }
            }
        }
        public List<TEnum> radioOptions { get; set; } = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
        public event Action ValueHasChanged;
    }
}

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoC.Components.Pages.Partial.Checkbox
{
    public class CheckBoxController (string label)
    {
        public int Id { get; set; }
        public string Label { get; set; } = label;
        private bool isChecked { get; set; }
        public bool IsChecked
        {
            get => isChecked;
            set
            {
                isChecked = value;
                IsCheckedChanged.InvokeAsync(value);
            }
        }
        public EventCallback<bool> IsCheckedChanged { get; set; }
    }
}

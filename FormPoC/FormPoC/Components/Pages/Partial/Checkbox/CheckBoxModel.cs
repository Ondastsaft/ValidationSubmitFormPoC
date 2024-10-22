using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPageLibrary.ComponentModels
{
    public class CheckBoxModel
    {
        public int Id { get; set; }
        public string Label { get; set; }
        private bool isChecked { get; set; }
        public bool IsChecked { get => isChecked;
            set
            {
                isChecked = value;
                IsCheckedChanged.InvokeAsync(value);
            }
        }
        public EventCallback<bool> IsCheckedChanged { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoC.Components.Pages.Partial.ParameterWithValueInputfield
{
    public class IntValue : ParameterValue

    {
        private int _value;
        public override object Value
        {
            get => _value;
            set => _value = (int)value;
        }
    }
}

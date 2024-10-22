using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPageLibrary.ComponentModels
{
    public class Tab7Model
    {
        public enum radioOptions { short_distance, medium_distance, long_distance }

        public RadioButtonGroupModel Tab7RadioGroup { get; set; } = new()
        {
            radioOptions = ["short distance", "medium distance", "long distance"]
        };
    }
}

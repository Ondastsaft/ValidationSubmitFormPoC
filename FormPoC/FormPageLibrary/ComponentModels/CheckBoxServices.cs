using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPageLibrary.ComponentModels
{
    public class CheckBoxServices
    {
        public List<CheckBoxModel> CheckBoxes()
        {
            return new List<CheckBoxModel>
            {
                 new CheckBoxModel {Id = 1,Label = "Visa vikt", IsChecked = false },
                new CheckBoxModel { Id = 2, Label = "Visa avstånd", IsChecked = false },
                new CheckBoxModel {Id = 3, Label = "Visa höjd", IsChecked = false }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPageLibrary.ComponentModels
{
    public class CheckBoxServices
    {
        private readonly Dictionary<string, bool> _checkboxVisibilityMap = new();
        public void UpdateVisibility(string checkboxLabel, bool isChecked)
        {
            if (_checkboxVisibilityMap.ContainsKey(checkboxLabel))
            {
                _checkboxVisibilityMap[checkboxLabel] = isChecked;
            }
            else
            {
                _checkboxVisibilityMap.Add(checkboxLabel, isChecked);
            }
        }

        public bool IsInputVisible(string checkboxLabel)
        {
            return _checkboxVisibilityMap.TryGetValue(checkboxLabel, out var isVisible) && isVisible;
        }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPageLibrary.ComponentModels
{
    public static class CheckBoxServices
    {
        private static readonly Dictionary<string, bool> _checkboxValueMap = new();
        public static void UpdateValue(string checkboxLabel, bool isChecked)
        {
            if (_checkboxValueMap.ContainsKey(checkboxLabel))
            {
                _checkboxValueMap[checkboxLabel] = isChecked;
            }
            else
            {
                _checkboxValueMap.Add(checkboxLabel, isChecked);
            }
        }

        public static bool IsInputVisible(string checkboxLabel)
        {
            return _checkboxValueMap.TryGetValue(checkboxLabel, out var isVisible) && isVisible;
        }
        public static  List<CheckBoxModel> GetWeightDistanceCheckBoxes()
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

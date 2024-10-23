using FormPoC.Components.Pages.Partial.RadioButtonGroup;

namespace FormPoC.DAL
{
    public static class Tab7DistanceRadioGroupDAL
    {
        private static Dictionary<Tab2DistanceRadioOptions, string> swedishDistanceRadioOptions = new ()
        {
            { Tab2DistanceRadioOptions.short_distance, "< 100km" },
            { Tab2DistanceRadioOptions.medium_distance, "> 100km" },
            { Tab2DistanceRadioOptions.long_distance, "> 10 000km" }
        };
        public static Dictionary<Tab2DistanceRadioOptions, string> GetDistanceRadioOptions()
        {
            return swedishDistanceRadioOptions;
        }
    }
}

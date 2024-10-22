using FormPageLibrary.Enum;

namespace FormPoC.DAL
{
    public static class Tab7DistanceRadioGroupDAL
    {
        private static Dictionary<Tab7DistanceRadioOptions, string> swedishDistanceRadioOptions = new ()
        {
            { Tab7DistanceRadioOptions.short_distance, "< 100km" },
            { Tab7DistanceRadioOptions.medium_distance, "> 100km" },
            { Tab7DistanceRadioOptions.long_distance, "> 10 000km" }
        };
        public static Dictionary<Tab7DistanceRadioOptions, string> GetDistanceRadioOptions()
        {
            return swedishDistanceRadioOptions;
        }
    }
}

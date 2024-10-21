using FormPoC.Model;

namespace FormPoC.Components.Pages.FormPoc.Partial.FormPocTab1
{
    public class FormPocTab1State
    {
        public bool CompanySelected;
        public bool EmployeeSelected;
        public bool ShowWeight;
        public bool ShowAltitude;
        public bool ShowDistance;
        public DistanceRadioInput DistanceRadioInput;
        public bool DistanceConfirmed;
        public bool AltitudeConfirmed;

        public event Func<Action> OnCompanySelected;
        public event Action OnEmployeeSelected;
        public event Action ShowWeightChanged;
        public event Action ShowAltitudeChanged;
        public event Action ShowDistanceChanged;
        public event Action SelectedDistanceChanged;
        public event Action DistanceAltitudeCoonfirmationChanged;


    }
}

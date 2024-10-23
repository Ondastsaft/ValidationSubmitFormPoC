namespace FormPoC.Components.Pages.Partial.Tab2
{
    public class Tab2Controller
    {
        public bool IsDisabled { get; set; }  = true;
        public Tab2ComponentControllers ComponentControllers { get; set; }

        public async Task HandleShowWeightChecked()
        {
            ComponentControllers.SetWeightController.IsDisabled = false;
        }
    }
}

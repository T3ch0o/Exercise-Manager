namespace Exercise.Manager.ViewModels
{
    using Interfaces;

    public class DashboardViewModel : ViewModelBase, IDashboardViewModel
    {
        public string Title { get; } = "Dashboard";
    }
}

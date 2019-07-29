namespace Exercise.Manager.ViewModels
{
    using Caliburn.Micro;
    using Exercise.Manager.ViewModels.Interfaces;

    public class MainViewModel : Conductor<IViewModelBase>.Collection.OneActive, IMainViewModel
    {
        public MainViewModel(IDashboardViewModel dashboard,
            IExercisesViewModel exercises)
        {
            Items.Add(dashboard);
            Items.Add(exercises);
        }
    }
}
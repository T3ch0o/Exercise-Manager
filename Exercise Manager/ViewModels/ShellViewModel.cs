namespace Exercise.Manager.ViewModels
{
    using Caliburn.Micro;

    using Exercise.Manager.ViewModels.Interfaces;

    public sealed class ShellViewModel : Conductor<IMainViewModel>, IShellViewModel
    {
        public ShellViewModel(IMainViewModel mainViewModel)
        {
            DisplayName = "EM";

            ActivateItem(mainViewModel);
        }
    }
}
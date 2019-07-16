namespace Exercise.Manager
{
    using Exercise.Manager.ViewModels.Interfaces;
    using Exercise.Manager.ViewModels;

    using Wingman.Bootstrapper;
    using Wingman.Container;

    public class AppBootstrapper : BootstrapperBase<IShellViewModel>
    {
        protected override void RegisterViewModels(IDependencyRegistrar dependencyRegistrar)
        {
            dependencyRegistrar.Singleton<IShellViewModel, ShellViewModel>();
            dependencyRegistrar.Singleton<IMainViewModel, MainViewModel>();
        }
    }
}
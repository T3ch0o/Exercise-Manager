namespace Exercise.Manager.ViewModels
{
    using Interfaces;

    public class ExercisesViewModel : ViewModelBase, IExercisesViewModel
    {
        public string Title { get; } = "Exercises";
    }
}

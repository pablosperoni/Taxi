using Prism.Navigation;

namespace Taxi.Prism.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Calificador de Taxis";
        }
    }
}

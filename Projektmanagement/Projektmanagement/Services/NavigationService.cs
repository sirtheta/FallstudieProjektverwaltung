using Projektmanagement.Stores;
using Projektmanagement.ViewModels;

namespace Projektmanagement.Services
{
    public class NavigationService<TViewModel> : INavigationService where TViewModel : BaseViewModel
  {
        private readonly INavigationStore _navigationStore;
        private readonly CreateViewModel<TViewModel> _createViewModel;

        public NavigationService(INavigationStore navigationStore, CreateViewModel<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}

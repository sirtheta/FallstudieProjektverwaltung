﻿using Projektmanagement.Stores;
using Projektmanagement.ViewModels;

namespace Projektmanagement.Services
{
    public class ParameterNavigationService<TParameter, TViewModel>
        where TViewModel : BaseViewModel
  {
        private readonly NavigationStore _navigationStore;
        private readonly CreateViewModel<TParameter, TViewModel> _createViewModel;

        public ParameterNavigationService(NavigationStore navigationStore, CreateViewModel<TParameter, TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate(TParameter parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel(parameter);
        }
    }
}

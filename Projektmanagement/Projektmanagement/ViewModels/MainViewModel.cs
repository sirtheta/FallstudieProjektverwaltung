using System.Windows.Input;
using Projektmanagement.Commands;

namespace Projektmanagement.ViewModels
{
  internal class MainViewModel : BaseViewModel
  {


    private BaseViewModel _selectedViewModel;

    public MainViewModel(BaseViewModel viewModel)
    {
      _selectedViewModel = viewModel;
    }

    public BaseViewModel SelectedViewModel {
      get {
        return _selectedViewModel;
      }
      set {
        _selectedViewModel = value;
        OnPropertyChanged(nameof(SelectedViewModel));
      }
    }

    public ICommand HomeButtonCommand {
      get {
        return new UpdateViewCommand<object>(OnHomeButtonClicked);
      }
    }
    public ICommand SettingsButtonCommand {
      get {
        return new UpdateViewCommand<object>(OnSettingsButtonClicked);
      }
    }


    private void OnHomeButtonClicked(object Parameter)
    {
      SelectedViewModel = HomeViewModel.GetInstance;
    }

    private void OnSettingsButtonClicked(object Parameter)
    {
      SelectedViewModel = SettingsViewModel.GetInstance;
    }
  }
}

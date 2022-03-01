using System.Windows.Input;
using Projektmanagement.Commands;

namespace Projektmanagement.ViewModels
{
  internal class MainViewModel : BaseViewModel
  {

    private BaseViewModel? _selectedViewModel;

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


    private void OnHomeButtonClicked(object Parameter)
    {
      SelectedViewModel = new HomeViewModel();
    }
  }
}

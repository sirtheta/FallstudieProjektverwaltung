using Projektmanagement.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projektmanagement.ViewModels
{
  internal class MainViewModel : BaseViewModel
  {

    private BaseViewModel? _selectedViewModel;

    public BaseViewModel SelectedViewModel
    {
      get { return _selectedViewModel; }
      set
      {
        _selectedViewModel = value;
        OnPropertyChanged(nameof(SelectedViewModel));
      }
    }

    public ICommand UpdateViewCommand { get => new UpdateViewCommand<object>(OnHomeButtonClicked);}
    

    private void OnHomeButtonClicked(object Parameter) 
    {
      SelectedViewModel = new HomeViewModel();
    }
  }
}

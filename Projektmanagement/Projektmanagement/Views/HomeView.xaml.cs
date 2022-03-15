using System.Windows.Controls;
using Projektmanagement.ViewModels;

namespace Projektmanagement.Views
{
  /// <summary>
  /// Interaktionslogik für HomeView.xaml
  /// </summary>
  public partial class HomeView : UserControl
  {
    HomeViewModel vm;
    public HomeView()
    {
      InitializeComponent();
      vm = HomeViewModel.GetInstance;
      InitializeStackpanel();
    }


    private void InitializeStackpanel()
    {
      for (int i = 0; i < vm.Projects.Count; i++) 
      {
        ProjectObjectView newView = new ProjectObjectView();
        ProjectObjectViewModel newViewModel = new ProjectObjectViewModel(vm.Projects[i]);
        newView.Content = newViewModel;
        
        ProjectStackpanel.Children.Add(newView);
      }
      InitializeComponent();
    }

    
  }
}

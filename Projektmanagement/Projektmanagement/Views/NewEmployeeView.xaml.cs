using System.Windows.Controls;
using Projektmanagement.ViewModels;

namespace Projektmanagement.Views
{
  /// <summary>
  /// Interaction logic for NewModell.xaml
  /// </summary>
  public partial class NewEmployeeView : UserControl
  {
    public NewEmployeeView()
    {
      InitializeComponent();
      DataContext = NewEmployeeModel.GetInstance;
    }
  }
}

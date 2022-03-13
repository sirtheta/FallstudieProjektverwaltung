using System.Windows.Controls;
using Projektmanagement.ViewModels;

namespace Projektmanagement.Views
{
  /// <summary>
  /// Interaction logic for NewModell.xaml
  /// </summary>
  public partial class NewProcessModelView : UserControl
  {
    public NewProcessModelView()
    {
      InitializeComponent();
      DataContext = NewProcessModel.GetInstance;
    }
  }
}

using System.Windows;
using Projektmanagement.ViewModels;

namespace Projektmanagement
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      DataContext = new MainViewModel();
    }
  }
}

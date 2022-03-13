using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Projektmanagement.Views
{
  /// <summary>
  /// Interaction logic for ProjectObjectView.xaml
  /// </summary>
  public partial class ProjectObjectView : UserControl
  {
    public ProjectObjectView()
    {
      InitializeComponent();
      //ProjectLabelText = "Not Set";
    }

    public ProjectObjectView(string labelText)
    {
      InitializeComponent();
      this.SetValue(ProjectLabelTextProperty, labelText);
    }

    public static readonly DependencyProperty ProjectLabelTextProperty =
            DependencyProperty.Register("ProjectLabelText",
                typeof(string),
                typeof(ProjectObjectView));


    [Bindable(true)]
    public string ProjectLabelText {
      get {
        return (string)this.GetValue(ProjectLabelTextProperty);
      }

      set {
        this.SetValue(ProjectLabelTextProperty, value);
      }
    }
  }
}

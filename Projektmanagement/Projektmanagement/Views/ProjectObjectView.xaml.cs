using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
      get 
      {
        return (string)this.GetValue(ProjectLabelTextProperty);
      }

      set 
      {
        this.SetValue(ProjectLabelTextProperty, value);
      }
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektmanagement.Items
{
  internal class MyTextBox
  {
    private string _text;
    public string Text {
      get {
        return _text;
      }
      set {
        _text = value;
      }
    }
  }
}

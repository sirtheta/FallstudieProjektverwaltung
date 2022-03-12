using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Projektmanagement.Commands;
using Projektmanagement.MainClasses;

namespace Projektmanagement.ViewModels
{
  internal class NewProcessModel : BaseViewModel
  {

    #region Singleton
    // returns thread safe singleton
    private static NewProcessModel? instance = null;
    private readonly static object padlock = new();

    protected NewProcessModel()
    {
      BtnAddNew = new RelayCommand<object>(AddTextBox);
      BtnSave = new RelayCommand<object>(SaveProcessModels);
    }

    public static NewProcessModel GetInstance {
      get {
        lock (padlock) {
          if (instance == null) {
            instance = new NewProcessModel();
          }
          return instance;
        }
      }
    }
    #endregion

    ObservableCollection<string> _itemCollection = new();
    public ObservableCollection<string> ItemCollection {
      get {
        return _itemCollection;
      }
      set { _itemCollection = value;
        OnPropertyChanged();
      }
    }
    public ICommand BtnAddNew {
      get;
      private set;
    }

    public ICommand BtnSave {
      get;
      private set;
    }

    private string _phaseTextboxInput = "";
    public string PhaseTextboxInput {
      get {
        return _phaseTextboxInput;
      }

      set {
        _phaseTextboxInput = value;
        OnPropertyChanged();
      }
    }

    private void AddTextBox(object parameter)
    {
      ItemCollection.Add("");
    }


    private void SaveProcessModels(object parameter)
    {
      List<ProcessModel> processModels = new();

      foreach (var item in ItemCollection) {
        processModels.Add(new ProcessModel(item));
      }
    }
  }
}

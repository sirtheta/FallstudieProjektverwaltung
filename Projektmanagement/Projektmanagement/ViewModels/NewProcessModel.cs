using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Notifications.Wpf.Core;
using Projektmanagement.Commands;
using Projektmanagement.Items;
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
      BtnAddOne = new RelayCommand<object>(AddTextBox);
      BtnRemoveOne = new RelayCommand<object>(RemoveTextBox);
      BtnSave = new RelayCommand<object>(SaveProcessModels);
      AddTextBox();
    }

    /// <summary>
    /// returns instance of class NewProcessModel
    /// </summary>
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

    ObservableCollection<MyTextBox> _textBoxcollection = new();
    public ObservableCollection<MyTextBox> TextBoxCollection {
      get {
        return _textBoxcollection;
      }
      set {
        _textBoxcollection = value;
      }
    }

    public ICommand BtnAddOne {
      get;
      private set;
    }

    public ICommand BtnRemoveOne {
      get;
      private set;
    }

    public ICommand BtnSave {
      get;
      private set;
    }

    private void AddTextBox(object? parameter = null)
    {
      TextBoxCollection.Add(new MyTextBox());
    }
    private void RemoveTextBox(object obj)
    {
      if (TextBoxCollection.Count > 1) {
        TextBoxCollection.RemoveAt(TextBoxCollection.Count - 1);
      }
    }

    /// <summary>
    /// Save processModel input from textbox to processmodel.
    /// if no text is added, phase will not be added to the list
    /// </summary>
    /// <param name="parameter"></param>
    private void SaveProcessModels(object parameter)
    {
      List<ProcessModel> processModels = new();
      foreach (var item in TextBoxCollection) {
        if (item.Text != null) {
          processModels.Add(new ProcessModel(item.Text));
        }
        else {
          break;
        }
      }
      ShowNotification("Success", "Process Model Saved!", NotificationType.Success);
    }
  }
}

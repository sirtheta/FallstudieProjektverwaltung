using Projektmanagement.ViewModels;

namespace Projektmanagement.Stores
{
    public interface INavigationStore
    {
        BaseViewModel CurrentViewModel { set; }
    }
}
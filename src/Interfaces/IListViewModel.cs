using System.Collections.ObjectModel;

namespace ScholarTrack.Interfaces
{
    public interface IListViewModel<T>
    {
        ObservableCollection<T>? Items { get; set; }
    }
}
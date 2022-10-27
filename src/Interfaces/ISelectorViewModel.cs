using System.Collections.ObjectModel;

namespace ScholarTrack.Interfaces
{
    public interface ISelectorViewModel<T>
    {
        ObservableCollection<T>? Items { get; set; }
    }
}
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using ScholarTrack.Interfaces;
using ScholarTrack.Models;

namespace ScholarTrack.ViewModels
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class GradeListViewModel : ViewModelBase, IListViewModel<Grade>
    {
        public ObservableCollection<Grade>? Items { get; set; }
    }
}
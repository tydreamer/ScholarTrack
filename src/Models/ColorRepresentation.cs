using Avalonia.Media;
using ReactiveUI;

namespace ScholarTrack.Models
{
    public class ColorRepresentation : ReactiveObject
    {
        private bool _selected;

        public ColorRepresentation(Color color)
            => ElementColor = color;
        
        internal Color ElementColor { get; }
        internal bool Selected
        {
            get => _selected;
            set => this.RaiseAndSetIfChanged(ref _selected, value);
        }
    }
}
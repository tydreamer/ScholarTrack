using Avalonia.Controls;

namespace ScholarTrack.Models
{
    public abstract class ElementBase
    {
        private UserControl? _buttonContentTemplate;

        protected internal UserControl? ButtonControlTemplate
        {
            get => _buttonContentTemplate;
            set => _buttonContentTemplate = value;
        }
    }
}
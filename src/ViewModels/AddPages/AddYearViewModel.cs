using Avalonia.Media;
using ScholarTrack.ViewModels.BaseClasses;

namespace ScholarTrack.ViewModels.AddPages
{
    public class AddYearViewModel : AddViewModelBase
    {
        public AddYearViewModel() => BorderBrushes = new SolidColorBrush[] { new(IncompleteColor) };

        protected override bool DataComplete => !string.IsNullOrEmpty(ElementName);
    }
}
using Avalonia.Media;
using ScholarTrack.ViewModels.BaseClasses;

namespace ScholarTrack.ViewModels.AddPages
{
    public class AddSubjectViewModel : AddViewModelBase
    {
        public AddSubjectViewModel() => BorderBrushes = new SolidColorBrush[] { new(IncompleteColor), new(IncompleteColor) };

        protected override bool DataComplete => !string.IsNullOrEmpty(ElementName) 
                                                && !float.IsNaN(ElementWeighting);
    }
}
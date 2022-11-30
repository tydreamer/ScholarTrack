using ScholarTrack.ViewModels.BaseClasses;

namespace ScholarTrack.ViewModels.AddPages
{
    public class AddYearViewModel : AddViewModelBase
    {
        protected override bool DataComplete => !string.IsNullOrEmpty(ElementName);
    }
}
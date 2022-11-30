using ScholarTrack.ViewModels.BaseClasses;

namespace ScholarTrack.ViewModels.AddPages
{
    public class AddSubjectViewModel : AddViewModelBase
    {
        protected override bool DataComplete => !string.IsNullOrEmpty(ElementName) 
                                                && !float.IsNaN(ElementWeighting);
    }
}
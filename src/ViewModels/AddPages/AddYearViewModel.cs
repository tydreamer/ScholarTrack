using System.Linq;
using Avalonia.Media;
using ScholarTrack.Enums;
using ScholarTrack.ExtensionCollection;
using ScholarTrack.Interfaces;
using ScholarTrack.Models;
using ScholarTrack.Models.Elements;
using ScholarTrack.ViewModels.BaseClasses;
using ScholarTrack.ViewModels.Lists;

namespace ScholarTrack.ViewModels.AddPages
{
    public class AddYearViewModel : AddViewModelBase, IAddViewModel<SchoolYear>
    {
        public AddYearViewModel()
        {
            BorderBrushes = new SolidColorBrush[] { new(IncompleteColor) };
            EditPageText(AddPageAction.Create, "School Year");
        }

        protected override bool DataComplete => !string.IsNullOrEmpty(ElementName) && !string.IsNullOrWhiteSpace(ElementName) 
                                                && DataChanged();

        private SchoolYear? EditedYear { get; set; }

        public void EditElement(SchoolYear year)
        {
            EditedYear = year;
            EditPageText(AddPageAction.Edit, "School Year", year.Name);
            ElementName = year.Name;
            
            var colorRepresentation = ElementColorsCollection.FirstOrDefault(x => x.ElementColor.Equals(year.ElementColor));
            if(colorRepresentation is not null)
                ChangeColor(colorRepresentation);
        }
        
        protected internal override void EraseData()
        {
            base.EraseData();
            EditedYear = null;
        }
        
        private void CreateElement()
        {
            if(ElementName is null)
                return;
            
            var colorHex = SelectedColor.ElementColor.ToHexString();
            if (EditedYear is null)
            {
                var viewModel = YearListViewModel.Instance;
                var year = new SchoolYear(ElementName, colorHex);
                
                DataManager.SchoolYears.Add(year);
                viewModel?.Items?.Add(year);
            }
            else
                EditedYear.Edit(ElementName, colorHex);

            UpdateVisualOnChange();
            EditedYear = null;
        }

        private bool DataChanged()
        {
            if (EditedYear is null)
                return true;

            return ElementName is not null && (!ElementName.Trim().Equals(EditedYear.Name.Trim()) 
                                               || !SelectedColor.ElementColor.Equals(EditedYear.ElementColor));
        }
    }
}
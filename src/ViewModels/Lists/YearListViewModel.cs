using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ScholarTrack.Enums;
using ScholarTrack.Interfaces;
using ScholarTrack.Models;
using ScholarTrack.Models.Elements;
using ScholarTrack.Models.Settings;
using ScholarTrack.ViewModels.AddPages;
using ScholarTrack.ViewModels.BaseClasses;
using ScholarTrack.Views.AddPages;
using ReactiveUI;

namespace ScholarTrack.ViewModels.Lists
{
    public class YearListViewModel : ListViewModelBase, IListViewModel<SchoolYear>
    {
        private ObservableCollection<SchoolYear>? _items;
        
        public YearListViewModel(IEnumerable<SchoolYear> years)
        {
            Instance = this;
            AddPageType = typeof(AddYearWindow);
            AddViewModelType = typeof(AddYearViewModel);
            ElementType = typeof(SchoolYear);
            
            bool isGrid = SettingsManager.Settings?.YearButtonStyle == SelectedButtonStyle.Grid;
            ChangeButtonView(isGrid);
            
            var mainInstance = MainWindowViewModel.Instance;
            Items = new ObservableCollection<SchoolYear>(years);
            Items.CollectionChanged += (sender, args) =>
            {
                this.RaisePropertyChanged(nameof(EmptyCollection));
                mainInstance?.UpdateAverage();
            };
            InitializeTopbarElements();
        }

        public ObservableCollection<SchoolYear>? Items
        {
            get => _items;
            set
            {
                this.RaiseAndSetIfChanged(ref _items, value);
                this.RaisePropertyChanged(nameof(EmptyCollection));
            }
        }
        
        public bool EmptyCollection => Items?.Count == 0;
        
        internal static YearListViewModel? Instance { get; private set; }

        public void Duplicate(IElement element) 
            => DuplicateElement<SchoolYear>(element);

        protected internal override void ChangeTopbar()
        {
            base.ChangeTopbar();
            foreach (var control in TopbarTexts!)
                control.IsVisible = false;
        }

        private void RemoveElement(SchoolYear year)
        {
            Action action = () =>
            {
                DataManager.SchoolYears.Remove(year);
                Items?.Remove(year);
                UpdateVisualOnChange();
            };
            base.RemoveElement(year, Enums.ElementType.SchoolYear, action);
        }
    }
}
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using ScholarTrack.Interfaces;
using ScholarTrack.Models;
using ScholarTrack.Models.Elements;
using ScholarTrack.ViewModels;
using ScholarTrack.ViewModels.BaseClasses;
using ScholarTrack.ViewModels.Lists;

namespace ScholarTrack.Views
{
    public class MainWindow : Window
    {
        private MainWindowViewModel? _mainWindowModel;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            Instance = this;
        }

        internal static MainWindow? Instance { get; private set; }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnYearPressed(object? sender, PointerPressedEventArgs e)
        {
            SwitchPage<YearListViewModel, SchoolYear>(DataManager.SchoolYears);
            MainWindowViewModel.CurrentYear = null;
        }
        
        private void OnSubjectPressed(object? sender, PointerPressedEventArgs e)
        {
            SwitchPage<SubjectListViewModel, Subject>(MainWindowViewModel.CurrentYear!.Subjects);
            MainWindowViewModel.CurrentSubject = null;
        }

        private void SwitchPage<TViewModel, TElement>(IEnumerable<TElement> elements)
            where TViewModel : ListViewModelBase, IListViewModel<TElement> 
            where TElement : class, IElement, IGradable
        {
            _mainWindowModel ??= this.DataContext as MainWindowViewModel;
            if (_mainWindowModel!.Content is TViewModel)
                return;
            _mainWindowModel!.SwitchPage<TViewModel, TElement>(elements);
        }
    }
}
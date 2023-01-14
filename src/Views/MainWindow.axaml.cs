using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using ScholarTrack.Models;
using ScholarTrack.Models.Elements;
using ScholarTrack.ViewModels;
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
            _mainWindowModel ??= this.DataContext as MainWindowViewModel;
            _mainWindowModel!.SwitchPage<YearListViewModel, SchoolYear>(DataManager.SchoolYears);
            MainWindowViewModel.CurrentYear = null;
        }
        
        private void OnSubjectPressed(object? sender, PointerPressedEventArgs e)
        {
            _mainWindowModel ??= this.DataContext as MainWindowViewModel;
            _mainWindowModel!.SwitchPage<SubjectListViewModel, Subject>(MainWindowViewModel.CurrentYear!.Subjects);
            MainWindowViewModel.CurrentSubject = null;
        }
    }
}
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ScholarTrack.ViewModels.AddPages;

namespace ScholarTrack.Views
{
    public class AddGradeWindow : Window
    {
        public AddGradeWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void DisplayDateChanged(object? sender, SelectionChangedEventArgs args)
        {
            if(DataContext is AddGradeViewModel viewModel)
                viewModel.DateChanged(sender, args);
        }
    }
}
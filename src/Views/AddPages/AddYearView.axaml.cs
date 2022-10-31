using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ScholarTrack.Views
{
    public class AddYearView : UserControl
    {
        public AddYearView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
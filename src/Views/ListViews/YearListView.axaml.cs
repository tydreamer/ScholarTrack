using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ScholarTrack.Views
{
    public class YearListView : UserControl
    {
        public YearListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
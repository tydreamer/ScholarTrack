using Avalonia.Markup.Xaml;
using ScholarTrack.Models;

namespace ScholarTrack.Views.Lists
{
    public class YearListView : DragControl
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
using Avalonia.Markup.Xaml;
using ScholarTrack.Models;

namespace ScholarTrack.Views.Lists
{
    public class GradeListView : DragControl
    {
        public GradeListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
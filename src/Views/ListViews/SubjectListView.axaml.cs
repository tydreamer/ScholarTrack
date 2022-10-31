using Avalonia.Markup.Xaml;
using ScholarTrack.Models;

namespace ScholarTrack.Views
{
    public class SubjectListView : DragControl
    {
        public SubjectListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
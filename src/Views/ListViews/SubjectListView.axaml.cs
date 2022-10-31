using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ScholarTrack.Views
{
    public class SubjectListView : UserControl
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
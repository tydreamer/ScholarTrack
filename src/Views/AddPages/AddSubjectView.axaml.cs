using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ScholarTrack.Views
{
    public class AddSubjectView : UserControl
    {
        public AddSubjectView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ScholarTrack.Views.TargetGrade
{
    public class AverageGradeView : UserControl
    {
        public AverageGradeView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
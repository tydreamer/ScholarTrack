using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ScholarTrack.Views.Dialogs
{
    public class ConfirmationDialogView : UserControl
    {
        public ConfirmationDialogView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
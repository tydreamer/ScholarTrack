using ReactiveUI;

namespace ScholarTrack.ViewModels
{
    public class AddGradeViewModel : ViewModelBase
    {
        private bool _calendarOpen;
        
        public AddGradeViewModel() { }

        private bool CalendarOpen
        {
            get => _calendarOpen; 
            set => this.RaiseAndSetIfChanged(ref _calendarOpen, value); // Important to force the UI to update
        }

        private void ToggleCalendar() => CalendarOpen = !CalendarOpen;
    }
}
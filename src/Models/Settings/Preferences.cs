using ScholarTrack.Enums;

namespace ScholarTrack.Models.Settings
{
    public class Preferences
    {
        public SelectedButtonStyle YearButtonStyle { get; set; } = SelectedButtonStyle.Grid;
        public SelectedButtonStyle SubjectButtonStyle { get; set; } = SelectedButtonStyle.Grid;
        public SelectedButtonStyle GradeButtonStyle { get; set; } = SelectedButtonStyle.Grid;
    }
}
using System;
using ScholarTrack.Views.Lists.ElementButtonControls.Grid;

namespace ScholarTrack.Models.Settings
{
    public class Preferences
    {
        public Type? YearButtonStyle { get; set; } = typeof(GridYearButton);
        public Type? SubjectButtonStyle { get; set; } = typeof(GridSubjectButton);
        public Type? GradeButtonStyle { get; set; } = typeof(GridGradeButton);
    }
}
using System.Collections.Generic;
using ScholarTrack.Models.Elements;

namespace ScholarTrack.Interfaces
{
    public interface ITargetGrade
    {
        IEnumerable<Grade>? Grades { get; set; }
    }
}
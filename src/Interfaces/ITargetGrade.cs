using System.Collections.Generic;
using ScholarTrack.Models;

namespace ScholarTrack.Interfaces
{
    public interface ITargetGrade
    {
        IEnumerable<Grade> Grades { get; set; }
    }
}
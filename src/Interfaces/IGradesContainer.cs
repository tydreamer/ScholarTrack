using System.Collections.Generic;
using ScholarTrack.Models.Elements;

namespace ScholarTrack.Interfaces;

public interface IGradesContainer
{
    List<Grade> Grades { get; }
}
using System.Collections.Generic;
using ScholarTrack.Models.Elements;

namespace ScholarTrack.Interfaces;

public interface IGradesContainer
{
    IGradesContainer? ParentContainer { get; }
    List<Grade> Grades { get; }
}
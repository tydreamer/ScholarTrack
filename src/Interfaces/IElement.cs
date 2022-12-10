using System.Collections.Generic;

namespace ScholarTrack.Interfaces
{
    public interface IElement
    {
        string Name { get; }
        IEnumerable<T>? Duplicate<T>() where T : IElement;
    }
}
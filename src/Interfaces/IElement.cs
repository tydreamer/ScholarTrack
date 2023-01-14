using System.Collections.Generic;
using ScholarTrack.Views.Lists.ElementButtonControls;

namespace ScholarTrack.Interfaces
{
    public interface IElement
    {
        string Name { get; }
        ButtonStyleBase? ButtonStyle { get; set; }

        T? Duplicate<T>() where T : class, IElement;
    }
}
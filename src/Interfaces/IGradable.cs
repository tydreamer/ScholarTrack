namespace ScholarTrack.Interfaces
{
    public interface IGradable : ISimpleGradable
    {
        float Weighting { get; }
        bool Counts { get; }
    }
}
using System.Text.Json.Serialization;
using ScholarTrack.UtilityCollection;

namespace ScholarTrack.Models
{
    public class SchoolYear
    {
        public SchoolYear(string name, Subject[] subjects)
        {
            this.Name = name;
            this.Subjects = subjects;
        }
        
        [JsonInclude]
        public string Name { get; init; }
        
        [JsonInclude]
        public Subject[] Subjects { get; init; }
        
        internal float Average => Utilities.GetAverage(Subjects, true);
    }
}
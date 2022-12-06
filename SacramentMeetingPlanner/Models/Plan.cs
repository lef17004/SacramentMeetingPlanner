namespace SacramentMeetingPlanner.Models
{
    public class Plan
    {
        public int id { get; set; }
        public string president { get; set; }
        public string conducting { get; set; }
        public string invocation { get; set; }
        public string sacramentHymnNumber { get; set; }
        public string sacramentHymnName { get; set; }
        public string special { get; set; }
        public string closingHymnNumber { get; set; }
        public string closingHymnName { get; set; }
        public string benediction { get; set; }
        public string dismissalSongNumber { get; set; }
        public string dismissalSongName { get; set; }
    }
}

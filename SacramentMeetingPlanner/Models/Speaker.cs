namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public DateOnly Date { get; set; }
        public int planId { get; set; }
    }
}

namespace Models
{
    public class Smartwatch
    {
        public Guid Id { get; set; }
        public string Position { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public int HeartRate { get; set; }
        public Guid SessionId { get; set; }
        public Guid UserId { get; set; }
    }
}

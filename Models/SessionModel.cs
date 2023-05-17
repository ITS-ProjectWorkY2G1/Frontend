namespace Models
{
    public class SessionModel
    {
        public Guid SessionId { get; set; }
        public TimeSpan SessionTime { get; set; }
        public int AvgHeartRate { get; set; }
        public int SessionDistance { get; set; }
        public short PoolLaps { get; set; }
        public short PoolLength { get; set; }
        public bool ShowDetails { get; set; }
    }
}
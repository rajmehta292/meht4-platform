namespace Common
{
    public class Node
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } // e.g., "Online", "Offline", "Trading"
        public List<string> AssignedTickers { get; set; } = new List<string>();
        public DateTime LastHeartbeat { get; set; }
    }
}
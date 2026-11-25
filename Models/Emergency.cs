namespace Emergency_R_S.Models
{
    public class Emergency
    {
        public int Id { get; set; }
        public string Description { get; set; } 
        public string Location { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime Createdat { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User User { get; set; }
        public int?TeamId { get; set; }
        public Team? Team { get; set; }

    }
}

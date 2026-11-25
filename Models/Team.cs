namespace Emergency_R_S.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public bool IsAvailable { get; set; }
        public ICollection<Emergency> Emergencies { get; set; }
    }
}

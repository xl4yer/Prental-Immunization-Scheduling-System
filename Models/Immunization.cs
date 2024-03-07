namespace Bhcirs.Models
{
    public class immunization
    {
        public string immunizationID { get; set; } = "";
        public string childID { get; set; } = "";
        public DateTime? date { get; set; } = DateTime.Now;
        public string vaccine { get; set; } = "";
        public string fullname { get; set; } = "";
        public string status { get; set; } = "";
    }
}

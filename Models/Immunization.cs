using System.ComponentModel.DataAnnotations;

namespace Bhcirs.Models
{
    public class immunization
    {
        public string immunizationID { get; set; } = "";
        [Required]
        public string childID { get; set; } = "";
        public DateTime? date { get; set; } = DateTime.Now;
        [Required]
        public string vaccine { get; set; } = "";
        public string fullname { get; set; } = "";
        public string status { get; set; } = "";
        public string contact { get; set; } = "";
    }
}

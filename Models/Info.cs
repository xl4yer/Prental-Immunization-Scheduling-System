using System.ComponentModel.DataAnnotations;

namespace Bhcirs.Models
{
    public class info
    {
        public string infoID { get; set; } = "";
        [Required]
        public string fname { get; set; } = "";
        public string mname { get; set; } = "";
        [Required]
        public string lname { get; set; } = "";
        public DateTime? bdate { get; set; } = DateTime.Now;
        [Required]
        public string contact { get; set; } = "";
        [Required]
        public string address { get; set; } = "";
        public string hname { get; set; } = "";
        public string occupation { get; set; } = "";
        public string fullname { get; set; } = "";
        public string age { get; set; } = "";
    }
}
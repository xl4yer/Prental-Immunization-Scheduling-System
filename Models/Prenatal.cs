namespace Bhcirs.Models
{
	public class prenatal
	{
        public string prenatalID { get; set; } = "";
		public string infoID { get; set; } = "";
		public DateTime? date { get; set; } = DateTime.Now;
		public string vaccine { get; set; } = "";
        public string fullname { get; set; } = "";
        public string status { get; set; } = "";

    }
}

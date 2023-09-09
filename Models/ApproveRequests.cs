namespace HRMangementApi.Models
{
	public class ApproveRequests
	{
		public int Id { get; set; }

		public virtual Manager Manager { get; set; }

		public Status Status { get; set; }

		public DateTime ApprovalDate { get; set; }

		public IEnumerable<TimeOffRequest> TimeOffRequest { get; set; }
		public string Reason { get; set; }
	}
}

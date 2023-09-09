using System.ComponentModel.DataAnnotations;

namespace HRMangementApi.Models
{
	public class TimeOffRequest
	{
		public int Id { get; set; }

		public string Reason { get; set; }

		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }

		[DataType(DataType.Date)]
		public DateTime EndDate { get; set; }

		[DataType(DataType.Date)]
		public DateTime RequestDate { get; set; }

		public Status Status { get; set; }


		public IEnumerable<File> Attachments { get; set; }

		public  virtual TimeOffCategory Category { get; set; }

		public virtual ApproveRequests ApproveRequest { get; set; }

	}


	public enum Status
	{
		Approved,
		Pending,
		Rejected,
	}
}

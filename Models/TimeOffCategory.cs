namespace HRMangementApi.Models
{
	public class TimeOffCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }

		public IEnumerable<TimeOffRequest> Requests { get; set; }

		public virtual TimeOffPolicy TimeOffPolicy { get; set; }

	}
}

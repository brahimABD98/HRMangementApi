namespace HRMangementApi.Models
{
	public class TimeOffPolicy
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int Amount { get; set; }

		public int Period { get; set; }
		public IEnumerable<TimeOffCategory> Categories { get; set; }


	}
}

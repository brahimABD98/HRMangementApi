namespace HRMangementApi.Models
{
	public class Manager:Employee
	{
		
		public IEnumerable<Employee> Employees { get; set; }
	}
}

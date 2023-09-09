namespace HRMangementApi.Models
{
	public class Employee
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }

		public string JobTitle { get; set; }

		public string Departement { get; set; }

		public DateTime BirthDate { get; set; }
		public DateTime HireDate { get; set; }


		//relations
		public virtual LeaveBalance LeaveBalance { get; set; }

		public virtual Manager Manager { get; set; }
        public int ManagerId { get; set; }

    }
}

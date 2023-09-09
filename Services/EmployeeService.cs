using HRMangementApi.Data;
using HRMangementApi.Interfaces;
using HRMangementApi.Models;

namespace HRMangementApi.Repositories
{
	public class EmployeeService : Service<Employee>, IEmployeeService
	{
		public EmployeeService(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

	}
}

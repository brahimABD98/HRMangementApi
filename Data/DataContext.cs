using HRMangementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMangementApi.Data
{

	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<ApproveRequests> ApproveRequests { get; set; }

		public DbSet<LeaveBalance> leaveBalances { get; set; }

		public DbSet<Manager> Managers { get; set; }

		public DbSet<TimeOffCategory> TimeOffCategories { get; set; }

		public DbSet<TimeOffPolicy> TimeOffPolicies { get; set; }

		public DbSet<TimeOffRequest> TimeOffRequests { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)

		{
			modelBuilder.Entity<Manager>()
				.HasMany(m => m.Employees)
				.WithOne(e => e.Manager)
				.HasForeignKey(e => e.ManagerId)
				.IsRequired(false);

			base.OnModelCreating(modelBuilder);
		}
	}
}

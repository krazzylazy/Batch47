using Microsoft.EntityFrameworkCore;

namespace Batch47.Models
{
	public class ApplicationDbContext : DbContext
	{
		// Entity Framework => ORM (Object Relatioal Mapping)

		// Constructor (ctor)
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			
		}

		public DbSet<Category> Categories { get; set; }
	}
}

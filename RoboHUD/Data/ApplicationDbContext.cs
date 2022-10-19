using Microsoft.EntityFrameworkCore;
using RoboHUD.Models;

namespace RoboHUD.Data;
public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	public DbSet<Category> Categories { get; set; }


}


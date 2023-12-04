using ApiPlantas.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPlantas.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{ 

		}

		public DbSet<Usuario> Usuarios{ get; set; }
	}
}

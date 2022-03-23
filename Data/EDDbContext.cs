using System;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
	public class EDDbContext : DbContext
	{
		public EDDbContext(DbContextOptions<EDDbContext> options) : base(options)
		{

		}

		public DbSet<User> Users { get; set; } = null!;
		public DbSet<Student> Students { get; set; } = null!;
	}
}


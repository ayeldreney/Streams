using Microsoft.EntityFrameworkCore;
using Streams.Entites;
using System.Numerics;

namespace Streams.Data.Context
{
	public class StreamContext:DbContext
	{


		public DbSet<User> Users { get; set; }


		public StreamContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{


		}

	}
}

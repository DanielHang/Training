namespace GalacticDvdRentals.Data.Model
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=ContextModel")
		{
		}

		public virtual DbSet<Address> Addresses { get; set; }
		public virtual DbSet<Charge> Charges { get; set; }
		public virtual DbSet<Client> Clients { get; set; }
		public virtual DbSet<DvdItem> DVDItems { get; set; }
		public virtual DbSet<Movie> Movies { get; set; }
		public virtual DbSet<Rental> Rentals { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Charge>()
				.Property(e => e.chargeType)
				.IsFixedLength();

			modelBuilder.Entity<Charge>()
				.Property(e => e.amount)
				.HasPrecision(5, 2);

			modelBuilder.Entity<Client>()
				.HasMany(e => e.Charges)
				.WithRequired(e => e.Client)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Client>()
				.HasMany(e => e.Rentals)
				.WithRequired(e => e.Client)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<DvdItem>()
				.Property(e => e.serial)
				.IsUnicode(false);

			modelBuilder.Entity<DvdItem>()
				.HasMany(e => e.Rentals)
				.WithRequired(e => e.DVDItem)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Movie>()
				.HasMany(e => e.DVDItems)
				.WithRequired(e => e.Movie)
				.WillCascadeOnDelete(false);
		}
	}
}

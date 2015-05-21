namespace Kanbang.Core.DataAccess
{
	using System.Data.Entity;
	using Kanbang.Core.DataAccess.Mappings;
	using Kanbang.Core.Domain;

	internal class KanbangDbContext : DbContext
	{
		public KanbangDbContext()
			: this("name=Kanbang")
		{
		}

		public KanbangDbContext(string connectionString)
			: base(connectionString)
		{
		}

		public virtual DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			this.Configuration.AutoDetectChangesEnabled = true;
			this.Configuration.LazyLoadingEnabled = true;
			this.Configuration.ProxyCreationEnabled = true;
			this.Configuration.ValidateOnSaveEnabled = true;

			modelBuilder.Configurations.Add(new UserMap());
		}
	}
}
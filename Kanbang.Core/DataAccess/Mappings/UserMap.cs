namespace Kanbang.Core.DataAccess.Mappings
{
	using System.Data.Entity.ModelConfiguration;
	using Kanbang.Core.Domain;

	internal class UserMap : EntityTypeConfiguration<User>
	{
		public UserMap()
		{
			this.ToTable("User");
			this.HasKey(t => t.Id);

			this.Property(t => t.Id).HasColumnName("Id");
			this.Property(t => t.Name).HasColumnName("Name").HasMaxLength(200).IsRequired();
			this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
		}
	}
}
namespace Kanbang.Core.Migrations
{
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using System.Reflection;
	using System.Text.RegularExpressions;
	using Coderful.Core.Reflection;
	using Kanbang.Core.DataAccess;

	internal sealed class Configuration : DbMigrationsConfiguration<KanbangDbContext>
	{
		public Configuration()
		{
			this.AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(KanbangDbContext context)
		{
			// Read embedded resource.
			var sql = Assembly.GetExecutingAssembly().GetEmbeddedResourceText("Kanbang.Core.Migrations.Seed.sql");
			sql = sql.Replace("Kanbang", context.Database.Connection.Database);

			// Split into multiple statements.
			var sqlStaments = Regex.Split(sql, @"\bgo\b").Where(s => !string.IsNullOrWhiteSpace(s));

			// Execute each statement.
			foreach (var sqlStament in sqlStaments)
			{
				context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlStament);
			}
		}
	}
}
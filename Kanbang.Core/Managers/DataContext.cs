namespace Kanbang.Core.Managers
{
	using Kanbang.Core.DataAccess;

	public class DataContext
	{
		internal readonly KanbangDbContext DbContext;

		public DataContext()
		{
			this.DbContext = new KanbangDbContext();
		}

		internal DataContext(KanbangDbContext dbContext)
		{
			this.DbContext = dbContext;
		}
	}
}
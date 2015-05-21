namespace Kanbang.Core.Managers
{
	using Kanbang.Core.Domain;

	public interface IExecutionContext
	{
		/// <summary>
		/// Gets or sets user on who's behalf the code is being executed.
		/// </summary>
		User User { get; }
	}
}

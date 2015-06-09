namespace Kanbang.Web.Controllers
{
    using System.Web.Mvc;
    using Kanbang.Core.Managers;

	public partial class UserController : Controller
    {
        // GET: User
		public virtual ActionResult Index()
        {
            var model = new UserManager().GetAll();
            return View(model);
        }
    }
}
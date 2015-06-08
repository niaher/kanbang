namespace Kanbang.Web.Controllers
{
    using System.Web.Mvc;
    using Kanbang.Core.Managers;

    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var model = new UserManager().GetAll();
            return View(model);
        }
    }
}
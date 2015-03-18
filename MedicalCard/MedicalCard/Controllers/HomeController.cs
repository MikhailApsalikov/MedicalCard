namespace MedicalCard.Controllers
{
	using System.Linq;
	using System.Net;
	using System.Web;
	using System.Web.Mvc;
	using BLL;
	using BLL.Repositories;

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public JsonResult Login(string username, string password)
		{
			var repository = new AccountRepository(new MedicalCardDbContext());
			var account =
				repository.GetAll().FirstOrDefault(acc => acc.Username == username);
			if (account == null)
			{
				Response.StatusCode = (int)HttpStatusCode.NotFound;
				return Json(new
				{
					reason = "Пользователь не найден"
				});
			}

			if (account.Password != password)
			{
				Response.StatusCode = (int)HttpStatusCode.NotFound;
				return Json(new
				{
					reason = "Неверный пароль"
				});
			}

			return Json(new
			{
				id = account.Id,
				username = account.Username,
				role = account.Role,
			});
		}
	}
}
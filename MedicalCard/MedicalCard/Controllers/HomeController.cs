namespace MedicalCard.Controllers
{
	using System.Linq;
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
				return Json(new
				{
					success = false,
					reason = "Пользователь не найден"
				});
			}

			if (account.Password != password)
			{
				return Json(new
				{
					success = false,
					reason = "Неверный пароль"
				});
			}

			return Json(new
			{
				success = true,
				id = account.Id,
				username = account.Username,
				role = account.Role,
			});
		}
	}
}
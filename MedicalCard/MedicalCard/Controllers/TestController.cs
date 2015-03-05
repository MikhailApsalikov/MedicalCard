namespace MedicalCard.Controllers
{
	using System.Web.Mvc;
	using MedicalCard.BLL;

	public class TestController : Controller
	{
		public ActionResult Index()
		{
			return Json(new {done = new TestDataInitializer().Initialize()}, JsonRequestBehavior.AllowGet);
		}
	}
}
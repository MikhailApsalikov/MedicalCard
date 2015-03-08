using System.Web;
using System.Web.Optimization;

namespace MedicalCard
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/angular").Include(
				"~/Scripts/angular.js",
				"~/Scripts/angular-ui.js",
				"~/Scripts/angular-route.js",
				"~/Scripts/angular-animate.js",
				"~/Scripts/angular-toastr.js",
				"~/Scripts/angular-mocks.js",
				//"~/Scripts/angular-ui.js",
				"~/Scripts/angular-ui/ui-bootstrap.js",
				"~/Scripts/angular-ui/ui-bootstrap-tpls.js",
				"~/Scripts/angular-sanitize.js",
				"~/Scripts/angular-resource.js",
				"~/Scripts/i18n/angular-locale_ru-ru.js",
				"~/Scripts/ui-bootstrap-tpls-{version}.js",
				"~/Scripts/lodash.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/bootstrap-theme.css",
					  "~/Content/site.css"));

			// Set EnableOptimizations to false for debugging. For more information,
			// visit http://go.microsoft.com/fwlink/?LinkId=301862
			BundleTable.EnableOptimizations = false;
		}
	}
}

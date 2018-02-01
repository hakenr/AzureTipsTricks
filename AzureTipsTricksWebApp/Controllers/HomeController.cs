using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureTipsTricksWebApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			Trace.TraceInformation("Hello from AzureTipsTricks demo!");
			Trace.TraceWarning("This is a warning...");
			Trace.TraceError("This is an error.");

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Hang()
		{
			var start = DateTime.Now;
			while (start.AddSeconds(30) > DateTime.Now)
			{
				var x = Math.Sqrt(DateTime.Now.Ticks);
			}

			return View();
		}
	}
}
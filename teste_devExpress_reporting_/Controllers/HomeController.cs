using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using teste_devExpress_reporting_.Models;

namespace teste_devExpress_reporting_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TestReport()
        {
            var rptPath = "teste_devExpress_reporting_.Reports.TestReport";
            XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
            ViewBag.ReportHeader = "Test Report";
            return View("~/Views/ReportingViewer.cshtml");
        }   
    }
}
